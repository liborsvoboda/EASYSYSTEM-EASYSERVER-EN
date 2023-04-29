using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using GLOBALNET.DBModel;

namespace GLOBALNET.Controllers
{
    [ApiController]
    [Route("GLOBALNETParameterList")]
    public class GLOBALNETParameterListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETParameterList")]
        public async Task<string> GetParameterList()
        {
            List<ParameterList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                data = new GLOBALNETContext().ParameterLists.Where(a => a.UserId == null).ToList();
            }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETParameterList/Filter/{filter}")]
        public async Task<string> GetParameterListByFilter(string filter)
        {
            List<ParameterList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().ParameterLists.FromSqlRaw("SELECT * FROM ParameterList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpGet("/GLOBALNETParameterList/{userId}")]
        public async Task<string> GetParameterListKey(int userId)
        {
            List<ParameterList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                data = new GLOBALNETContext().ParameterLists.Where(a => a.UserId == userId || a.UserId == null).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpPut("/GLOBALNETParameterList")]
        [Consumes("application/json")]
        public async Task<string> InsertParameterList([FromBody] ParameterList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new GLOBALNETContext().ParameterLists.Add(record);
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
        [HttpPost("/GLOBALNETParameterList")]
        [Consumes("application/json")]
        public async Task<string> UpdateParameterList([FromBody] ParameterList record)
        {
            try
            {
                var data = new GLOBALNETContext().ParameterLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [Authorize]
        [HttpDelete("/GLOBALNETParameterList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteParameterList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                ParameterList record = new() { Id = int.Parse(id) };

                var data = new GLOBALNETContext().ParameterLists.Remove(record);
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
