using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESRV.DBModel;

namespace LICENSESRV.Controllers
{
    [Authorize]
    [ApiController]
    [Route("LICENSESRVParameterList")]
    public class LICENSESRVParameterListApi : ControllerBase
    {
        [HttpGet("/LICENSESRVParameterList")]
        public async Task<string> GetParameterList()
        {
            List<ParameterList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                data = new LICENSESRVContext().ParameterLists.Where(a => a.UserId == 0).ToList();
            }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESRVParameterList/{userId}")]
        public async Task<string> GetParameterListKey(int userId)
        {
            List<ParameterList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                data = new LICENSESRVContext().ParameterLists.Where(a => a.UserId == userId).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/LICENSESRVParameterList")]
        [Consumes("application/json")]
        public async Task<string> InsertParameterList([FromBody] ParameterList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new LICENSESRVContext().ParameterLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/LICENSESRVParameterList")]
        [Consumes("application/json")]
        public async Task<string> UpdateParameterList([FromBody] ParameterList record)
        {
            try
            {
                var data = new LICENSESRVContext().ParameterLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        //[HttpDelete("/LICENSESRVParameterList/{id}")]
        //[Consumes("application/json")]
        //public async Task<string> DeleteParameterList(string id)
        //{
        //    try
        //    {
        //        if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

        //        ParameterList record = new() { Id = int.Parse(id) };

        //        var data = new LICENSESRVContext().ParameterLists.Remove(record);
        //        int result = await data.Context.SaveChangesAsync();
        //        if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
        //        else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

        //    }
        //    catch (Exception ex)
        //    {
        //        return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
        //    }
        //}
    }
}
