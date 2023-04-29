using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESRV.DBModel;

namespace LICENSESRV.Controllers
{
    [Authorize]
    [ApiController]
    [Route("LICENSESRVLicenseActivationFailList")]
    public class LICENSESRVLicenseActivationFailListApi : ControllerBase
    {
        [HttpGet("/LICENSESRVLicenseActivationFailList")]
        public async Task<string> GetLicenseActivationFailList()
        {
            List<LicenseActivationFailList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESRVContext().LicenseActivationFailLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESRVLicenseActivationFailList/{id}")]
        public async Task<string> GetLicenseActivationFailListKey(int id)
        {
            LicenseActivationFailList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new LICENSESRVContext().LicenseActivationFailLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}
