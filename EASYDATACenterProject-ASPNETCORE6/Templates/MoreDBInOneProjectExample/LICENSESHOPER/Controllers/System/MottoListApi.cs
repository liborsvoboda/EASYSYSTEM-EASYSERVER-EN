using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESHOPER.DBModel;

namespace LICENSESHOPER.Controllers
{
    [ApiController]
    [Route("LICENSESHOPERMottoList")]
    public class LICENSESHOPERMottoListApi : ControllerBase
    {

        [HttpGet("/LICENSESHOPERMottoList")]
        public async Task<string> GetMottoList()
        {
            List<MottoList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().MottoLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}
