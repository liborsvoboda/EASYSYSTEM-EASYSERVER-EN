using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using GLOBALNET.DBModel;

namespace GLOBALNET.Controllers
{
    [ApiController]
    [Route("GLOBALNETServerSetting")]
    public class GLOBALNETServerSettingApi : ControllerBase
    {
        [HttpGet("/GLOBALNETServerSetting")]
        public async Task<string> GetServerSetting()
        {
            List<ServerSetting> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().ServerSettings.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETServerSetting/{key}")]
        public async Task<string> GetServerSettingKey(string key)
        {
            ServerSetting data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted 
            }))
            {
                data = new GLOBALNETContext().ServerSettings.Where(a => a.Key == key).First();
            }
            return JsonSerializer.Serialize(data);
        }

        [Authorize]
        [HttpPost("/GLOBALNETServerSetting")]
        [Consumes("application/json")]
        public async Task<string> SetServerSettingUpdate([FromBody] List<ServerSetting> record)
        {
            try
            {
                int count = 0;
                foreach (ServerSetting item in record)
                {
                    var data = new GLOBALNETContext().ServerSettings.Update(item);
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
