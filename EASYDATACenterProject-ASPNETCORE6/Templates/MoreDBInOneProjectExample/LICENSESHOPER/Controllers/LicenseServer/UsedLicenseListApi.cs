using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESHOPER.DBModel;

namespace LICENSESHOPER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("LICENSESHOPERUsedLicenseList")]
    public class LICENSESHOPERUsedLicenseListApi : ControllerBase
    {
        [HttpGet("/LICENSESHOPERUsedLicenseList")]
        public async Task<string> GetUsedLicenseList()
        {
            List<UsedLicenseList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().UsedLicenseLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERUsedLicenseList/Filter/{filter}")]
        public async Task<string> GetUsedLicenseListByFilter(string filter)
        {
            List<UsedLicenseList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().UsedLicenseLists.FromSqlRaw("SELECT * FROM UsedLicenseList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERUsedLicenseList/{id}")]
        public async Task<string> GetUsedLicenseListKey(int id)
        {
            UsedLicenseList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new LICENSESHOPERContext().UsedLicenseLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

    }
}
