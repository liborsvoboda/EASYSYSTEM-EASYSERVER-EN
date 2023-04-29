using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using GLOBALNET.DBModel;

namespace GLOBALNET.Controllers
{
    [Authorize]
    [ApiController]
    [Route("GLOBALNETLicenseActivationFailList")]
    public class GLOBALNETLicenseActivationFailListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETLicenseActivationFailList")]
        public async Task<string> GetLicenseActivationFailList()
        {
            List<LicenseActivationFailList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().LicenseActivationFailLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETLicenseActivationFailList/Filter/{filter}")]
        public async Task<string> GetLicenseActivationFailListByFilter(string filter)
        {
            List<LicenseActivationFailList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().LicenseActivationFailLists.FromSqlRaw("SELECT * FROM LicenseActivationFailList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETLicenseActivationFailList/{id}")]
        public async Task<string> GetLicenseActivationFailListKey(int id)
        {
            LicenseActivationFailList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().LicenseActivationFailLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }
    }
}
