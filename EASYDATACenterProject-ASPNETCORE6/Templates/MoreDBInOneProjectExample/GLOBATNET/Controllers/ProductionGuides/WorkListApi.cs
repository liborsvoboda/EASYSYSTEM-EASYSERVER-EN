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
    [Route("PRUVODKYWorkList")]
    public class PRUVODKYWorkListApi : ControllerBase
    {
        [HttpGet("/PRUVODKYWorkList")]
        public async Task<string> GetWorkList()
        {
            List<WorkList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new PRUVODKYContext().WorkLists.OrderBy(a => a.WorkPlace).ThenBy(b => b.Date).ThenBy(c => c.PersonalNumber).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/PRUVODKYWorkList/{id}")]
        public async Task<string> GetWorkListKey(int id)
        {
            WorkList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new PRUVODKYContext().WorkLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/PRUVODKYWorkList")]
        [Consumes("application/json")]
        public async Task<string> InsertWorkList([FromBody] WorkList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new PRUVODKYContext().WorkLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/PRUVODKYWorkList")]
        [Consumes("application/json")]
        public async Task<string> UpdateWorkList([FromBody] WorkList record)
        {
            try
            {
                var data = new PRUVODKYContext().WorkLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/PRUVODKYWorkList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteWorkList(string id)
        {
            try
            {
                int Ids;
                if (!int.TryParse(id, out Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                WorkList deleteRecord = new() { Id = int.Parse(id) };

                var data = new PRUVODKYContext().WorkLists.Remove(deleteRecord);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }
    }
}
