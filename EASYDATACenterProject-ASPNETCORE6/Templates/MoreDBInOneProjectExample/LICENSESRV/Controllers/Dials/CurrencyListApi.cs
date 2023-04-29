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
    [Route("LICENSESRVCurrencyList")]
    public class LICENSESRVCurrencyListApi : ControllerBase
    {
        [HttpGet("/LICENSESRVCurrencyList")]
        public async Task<string> GetCurrencyList()
        {
            List<CurrencyList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESRVContext().CurrencyLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESRVCurrencyList/{id}")]
        public async Task<string> GetCurrencyListId(int id)
        {
            CurrencyList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted 
            }))
            {
                data = new LICENSESRVContext().CurrencyLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/LICENSESRVCurrencyList")]
        [Consumes("application/json")]
        public async Task<string> InsertCurrencyList([FromBody] CurrencyList record)
        {
            try
            {
                record.User = null;
                var data = new LICENSESRVContext().CurrencyLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/LICENSESRVCurrencyList")]
        [Consumes("application/json")]
        public async Task<string> UpdateCurrencyList([FromBody] CurrencyList record)
        {
            try
            {
                var data = new LICENSESRVContext().CurrencyLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpDelete("/LICENSESRVCurrencyList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteCurrencyList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                CurrencyList record = new() { Id = int.Parse(id) };

                var data = new LICENSESRVContext().CurrencyLists.Remove(record);
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
