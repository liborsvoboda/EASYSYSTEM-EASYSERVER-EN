using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using GLOBALNET.DBModel;

namespace GLOBALNET.Controllers
{
    [Authorize]
    [ApiController]
    [Route("GLOBALNETUsedLicenseList")]
    public class GLOBALNETUsedLicenseListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETUsedLicenseList")]
        public async Task<string> GetUsedLicenseList()
        {
            List<UsedLicenseList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().UsedLicenseLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETUsedLicenseList/Filter/{filter}")]
        public async Task<string> GetUsedLicenseListByFilter(string filter)
        {
            List<UsedLicenseList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().UsedLicenseLists.FromSqlRaw("SELECT * FROM UsedLicenseList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETUsedLicenseList/{id}")]
        public async Task<string> GetUsedLicenseListKey(int id)
        {
            UsedLicenseList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().UsedLicenseLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

    }
}
