using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using GLOBALNET.DBModel;

namespace GLOBALNET.Controllers
{
    [ApiController]
    [Route("GLOBALNETMottoList")]
    public class GLOBALNETMottoListApi : ControllerBase
    {

        [HttpGet("/GLOBALNETMottoList")]
        public async Task<string> GetMottoList()
        {
            List<MottoList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().MottoLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}
