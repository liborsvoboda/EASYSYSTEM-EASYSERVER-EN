using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESRV.DBModel;

namespace LICENSESRV.Controllers
{
    [Authorize]
    [ApiController]
    [Route("LICENSESRVUsedLicenseList")]
    public class LICENSESRVUsedLicenseListApi : ControllerBase
    {
        [HttpGet("/LICENSESRVUsedLicenseList")]
        public async Task<string> GetUsedLicenseList()
        {
            List<UsedLicenseList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESRVContext().UsedLicenseLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESRVUsedLicenseList/{id}")]
        public async Task<string> GetUsedLicenseListKey(int id)
        {
            UsedLicenseList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new LICENSESRVContext().UsedLicenseLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

    }
}
