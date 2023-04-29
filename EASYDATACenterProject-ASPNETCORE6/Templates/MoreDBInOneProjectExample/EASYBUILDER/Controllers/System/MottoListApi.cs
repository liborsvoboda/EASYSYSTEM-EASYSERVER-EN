using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using EASYBUILDER.DBModel;

namespace EASYBUILDER.Controllers
{
    [ApiController]
    [Route("EASYBUILDERMottoList")]
    public class EASYBUILDERMottoListApi : ControllerBase
    {

        [HttpGet("/EASYBUILDERMottoList")]
        public async Task<string> GetMottoList()
        {
            List<MottoList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new EASYBUILDERContext().MottoLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}
