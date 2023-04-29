using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESRV.DBModel;

namespace LICENSESRV.Controllers
{
    [ApiController]
    [Route("LICENSESRVMottoList")]
    public class LICENSESRVMottoListApi : ControllerBase
    {

        [HttpGet("/LICENSESRVMottoList")]
        public async Task<string> GetMottoList()
        {
            List<MottoList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESRVContext().MottoLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}
