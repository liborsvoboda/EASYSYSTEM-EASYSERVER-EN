using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PRUVODKY.DBModel;

namespace PRUVODKY.Controllers
{
    [ApiController]
    [Route("PRUVODKYMottoList")]
    public class PRUVODKYMottoListApi : ControllerBase
    {

        [HttpGet("/PRUVODKYMottoList")]
        public async Task<string> GetMottoList()
        {
            List<MottoList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new PRUVODKYContext().MottoLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}
