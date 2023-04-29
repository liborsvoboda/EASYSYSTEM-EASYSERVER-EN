using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PRUVODKY.DBModel;

namespace PRUVODKY.Controllers
{
    [Authorize]
    [ApiController]
    [Route("PRUVODKYCalendar")]
    public class PRUVODKYCalendarApi : ControllerBase
    {
        [HttpGet("/PRUVODKYCalendar/{userId}")]
        public async Task<string> GetCalendarById(int userId)
        {
            List<DBModel.Calendar> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new PRUVODKYContext().Calendars.Where(a => a.UserId == userId).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPost("/PRUVODKYCalendar")]
        [Consumes("application/json")]
        public async Task<string> InsertOrUpdateCalendar([FromBody] DBModel.Calendar record)
        {
            try
            {
                int result = 0;
                using (var db = new PRUVODKYContext())
                {
                    db.Entry(record).State = !db.Calendars.Any(a => a.UserId == record.UserId && a.Date == record.Date) ? EntityState.Added : EntityState.Modified;
                    result = await db.SaveChangesAsync();
                }

                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }
    }
}
