using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SHOPINGER.DBModel;

namespace SHOPINGER.Controllers
{
    [ApiController]
    [Route("SHOPINGERParameterList")]
    public class SHOPINGERParameterListApi : ControllerBase
    {
        [HttpGet("/SHOPINGERParameterList")]
        public async Task<string> GetParameterList()
        {
            List<ParameterList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                data = new SHOPINGERContext().ParameterLists.Where(a => a.UserId == null).ToList();
            }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGERParameterList/Filter/{filter}")]
        public async Task<string> GetParameterListByFilter(string filter)
        {
            List<ParameterList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new SHOPINGERContext().ParameterLists.FromSqlRaw("SELECT * FROM ParameterList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpGet("/SHOPINGERParameterList/{userId}")]
        public async Task<string> GetParameterListKey(int userId)
        {
            List<ParameterList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                data = new SHOPINGERContext().ParameterLists.Where(a => a.UserId == userId).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpPut("/SHOPINGERParameterList")]
        [Consumes("application/json")]
        public async Task<string> InsertParameterList([FromBody] ParameterList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new SHOPINGERContext().ParameterLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [Authorize]
        [HttpPost("/SHOPINGERParameterList")]
        [Consumes("application/json")]
        public async Task<string> UpdateParameterList([FromBody] ParameterList record)
        {
            try
            {
                var data = new SHOPINGERContext().ParameterLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [Authorize]
        [HttpDelete("/SHOPINGERParameterList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteParameterList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                ParameterList record = new() { Id = int.Parse(id) };

                var data = new SHOPINGERContext().ParameterLists.Remove(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }
    }
}
