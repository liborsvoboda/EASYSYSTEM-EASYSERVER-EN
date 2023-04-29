using SHOPINGER.DBModel;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace SHOPINGER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("SHOPINGERLoginHistoryList")]
    public class SHOPINGERLoginHistoryListApi : ControllerBase
    {
        [HttpGet("/SHOPINGERLoginHistoryList")]
        public async Task<string> GetLoginHistory()
        {
            List<LoginHistoryList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            { data = new SHOPINGERContext().LoginHistoryLists.ToList(); }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGERLoginHistoryList/Filter/{filter}")]
        public async Task<string> GetLoginHistoryListByFilter(string filter)
        {
            List<LoginHistoryList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new SHOPINGERContext().LoginHistoryLists.FromSqlRaw("SELECT * FROM LoginHistoryList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPost("/SHOPINGERLoginHistoryList")]
        [Consumes("application/json")] // ([FromBody] int Id) Body is only 17 ([FromBody] IdFilter id) Body is {"Id":17}
        public async Task<string> GetLoginHistoryListId([FromBody] IdFilter id)
        {
            if (!int.TryParse(id.Id.ToString(), out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

            LoginHistoryList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new SHOPINGERContext().LoginHistoryLists.Where(a => a.Id == id.Id).First(); }
            return JsonSerializer.Serialize(data);
        }

        /*
            [HttpPost("/SHOPINGERLoginHistory/Name")]
            [Consumes("application/json")]//([FromBody] string Name) Body is only "tester" ([FromBody] NameFilter Name) Body is {"Name":"tester"}
            public async Task<string> GetLoginHistoryName([FromBody] NameFilter Name)
            {
                if (string.IsNullOrWhiteSpace(Name.Name)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is null" });

                List<LoginHistory> data;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
                { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new SHOPINGERContext().LoginHistories.Where(a => a.UserName == Name.Name.ToString()).ToList(); }
                return JsonSerializer.Serialize(data);
            }
        */
    }
}
