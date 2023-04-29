using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SHOPINGER.DBModel;
using System.Text.Json.Serialization;

namespace SHOPINGER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("SHOPINGERExchangeRateList")]
    public class SHOPINGERExchangeRateListApi : ControllerBase
    {
        [HttpGet("/SHOPINGERExchangeRateList")]
        public async Task<string> GetExchangeRateList()
        {
            List<ExchangeRateList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new SHOPINGERContext().ExchangeRateLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGERExchangeRateList/Filter/{filter}")]
        public async Task<string> GetExchangeRateListByFilter(string filter)
        {
            List<ExchangeRateList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new SHOPINGERContext().ExchangeRateLists.FromSqlRaw("SELECT * FROM ExchangeRateList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGERExchangeRateList/{currency}")]
        public async Task<string> GetActualExchangeRate(string currency)
        {
            ExchangeRateList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new SHOPINGERContext().ExchangeRateLists.Include(a => a.Currency).Where(a => a.Currency.Name == currency).First();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }

        [HttpPut("/SHOPINGERExchangeRateList")]
        [Consumes("application/json")]
        public async Task<string> InsertExchangeRateList([FromBody] ExchangeRateList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                record.Currency = null;
                var data = new SHOPINGERContext().ExchangeRateLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/SHOPINGERExchangeRateList")]
        [Consumes("application/json")]
        public async Task<string> UpdateExchangeRateList([FromBody] ExchangeRateList record)
        {
            try
            {
                var data = new SHOPINGERContext().ExchangeRateLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/SHOPINGERExchangeRateList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteExchangeRateList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                ExchangeRateList record = new() { Id = int.Parse(id) };

                var data = new SHOPINGERContext().ExchangeRateLists.Remove(record);
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
