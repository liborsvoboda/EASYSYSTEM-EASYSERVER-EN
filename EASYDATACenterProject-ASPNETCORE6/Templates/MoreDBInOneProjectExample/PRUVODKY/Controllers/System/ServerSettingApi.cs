using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using PRUVODKY.DBModel;

namespace PRUVODKY.Controllers
{
    [ApiController]
    [Route("PRUVODKYServerSetting")]
    public class PRUVODKYServerSettingApi : ControllerBase
    {
        [HttpGet("/PRUVODKYServerSetting")]
        public async Task<string> GetServerSetting()
        {
            List<ServerSetting> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new PRUVODKYContext().ServerSettings.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/PRUVODKYServerSetting/{key}")]
        public async Task<string> GetServerSettingKey(string key)
        {
            ServerSetting data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted 
            }))
            {
                data = new PRUVODKYContext().ServerSettings.Where(a => a.Key == key).First();
            }
            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpPost("/PRUVODKYServerSetting")]
        [Consumes("application/json")]
        public async Task<string> SetServerSettingUpdate([FromBody] List<ServerSetting> record)
        {
            try
            {
                int count = 0;
                foreach (ServerSetting item in record)
                {
                    var data = new PRUVODKYContext().ServerSettings.Update(item);
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
