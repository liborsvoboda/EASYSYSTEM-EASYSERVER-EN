using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using SHOPINGER.DBModel;

namespace SHOPINGER.Controllers
{
    [ApiController]
    [Route("SHOPINGERServerSetting")]
    public class SHOPINGERServerSettingApi : ControllerBase
    {
        [HttpGet("/SHOPINGERServerSetting")]
        public async Task<string> GetServerSetting()
        {
            List<ServerSetting> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new SHOPINGERContext().ServerSettings.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGERServerSetting/{key}")]
        public async Task<string> GetServerSettingKey(string key)
        {
            ServerSetting data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted 
            }))
            {
                data = new SHOPINGERContext().ServerSettings.Where(a => a.Key == key).First();
            }
            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpPost("/SHOPINGERServerSetting")]
        [Consumes("application/json")]
        public async Task<string> SetServerSettingUpdate([FromBody] List<ServerSetting> record)
        {
            try
            {
                int count = 0;
                foreach (ServerSetting item in record)
                {
                    var data = new SHOPINGERContext().ServerSettings.Update(item);
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
