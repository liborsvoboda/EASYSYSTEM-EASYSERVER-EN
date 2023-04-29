using LICENSESHOPER.DBModel;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using BACKENDCORE.SharedApiClasses;

namespace LICENSESHOPER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("LICENSESHOPERLoginHistoryList")]
    public class LICENSESHOPERLoginHistoryListApi : ControllerBase
    {
        [HttpGet("/LICENSESHOPERLoginHistoryList")]
        public async Task<string> GetLoginHistory()
        {
            List<LoginHistoryList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            { data = new LICENSESHOPERContext().LoginHistoryLists.ToList(); }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERLoginHistoryList/Filter/{filter}")]
        public async Task<string> GetLoginHistoryListByFilter(string filter)
        {
            List<LoginHistoryList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().LoginHistoryLists.FromSqlRaw("SELECT * FROM LoginHistoryList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPost("/LICENSESHOPERLoginHistoryList")]
        [Consumes("application/json")] // ([FromBody] int Id) Body is only 17 ([FromBody] IdFilter id) Body is {"Id":17}
        public async Task<string> GetLoginHistoryListId([FromBody] IdFilter id)
        {
            if (!int.TryParse(id.Id.ToString(), out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

            LoginHistoryList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new LICENSESHOPERContext().LoginHistoryLists.Where(a => a.Id == id.Id).First(); }
            return JsonSerializer.Serialize(data);
        }

        /*
            [HttpPost("/LICENSESHOPERLoginHistory/Name")]
            [Consumes("application/json")]//([FromBody] string Name) Body is only "tester" ([FromBody] NameFilter Name) Body is {"Name":"tester"}
            public async Task<string> GetLoginHistoryName([FromBody] NameFilter Name)
            {
                if (string.IsNullOrWhiteSpace(Name.Name)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is null" });

                List<LoginHistory> data;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
                { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new LICENSESHOPERContext().LoginHistories.Where(a => a.UserName == Name.Name.ToString()).ToList(); }
                return JsonSerializer.Serialize(data);
            }
        */
    }
}
