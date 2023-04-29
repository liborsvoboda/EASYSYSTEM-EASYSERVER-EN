using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESHOPER.DBModel;

namespace LICENSESHOPER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("LICENSESHOPERLicenseActivationFailList")]
    public class LICENSESHOPERLicenseActivationFailListApi : ControllerBase
    {
        [HttpGet("/LICENSESHOPERLicenseActivationFailList")]
        public async Task<string> GetLicenseActivationFailList()
        {
            List<LicenseActivationFailList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().LicenseActivationFailLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERLicenseActivationFailList/Filter/{filter}")]
        public async Task<string> GetLicenseActivationFailListByFilter(string filter)
        {
            List<LicenseActivationFailList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().LicenseActivationFailLists.FromSqlRaw("SELECT * FROM LicenseActivationFailList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERLicenseActivationFailList/{id}")]
        public async Task<string> GetLicenseActivationFailListKey(int id)
        {
            LicenseActivationFailList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new LICENSESHOPERContext().LicenseActivationFailLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}
