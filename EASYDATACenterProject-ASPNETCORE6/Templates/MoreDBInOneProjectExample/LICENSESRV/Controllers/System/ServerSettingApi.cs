using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using LICENSESRV.DBModel;

namespace LICENSESRV.Controllers
{
    [ApiController]
    [Route("LICENSESRVServerSetting")]
    public class LICENSESRVServerSettingApi : ControllerBase
    {
        [HttpGet("/LICENSESRVServerSetting")]
        public async Task<string> GetServerSetting()
        {
            List<ServerSetting> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESRVContext().ServerSettings.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESRVServerSetting/{key}")]
        public async Task<string> GetServerSettingKey(string key)
        {
            ServerSetting data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted 
            }))
            {
                data = new LICENSESRVContext().ServerSettings.Where(a => a.Key == key).First();
            }
            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpPost("/LICENSESRVServerSetting")]
        [Consumes("application/json")]
        public async Task<string> SetServerSettingUpdate([FromBody] List<ServerSetting> record)
        {
            try
            {
                int count = 0;
                foreach (ServerSetting item in record)
                {
                    var data = new LICENSESRVContext().ServerSettings.Update(item);
                    int result = await data.Context.SaveChangesAsync();
                    count += result;
                }
                if (count > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = count, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = count, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }
    }
}
