using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESHOPER.DBModel;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace LICENSESHOPER.Controllers
{
    [ApiController]
    [Route("LICENSESHOPERLicenseActivator")]
    public class LICENSESHOPERLicenseActivatorApi : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("/LICENSESHOPERLicenseActivator/{UnlockCode}/{PartNumber}")]
        public async Task<string> GetLicenseActivator(string unlockCode, string partNumber)
        {
            string data = string.Empty; List<SqlParameter> parameters = new(); bool allowed = false;bool catched=false;
            try
            {
                if (HttpContext.Connection.RemoteIpAddress != null)
                {
                    string clientIPAddr = System.Net.Dns.GetHostEntry(HttpContext.Connection.RemoteIpAddress).AddressList.First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
                    if (!string.IsNullOrWhiteSpace(clientIPAddr))
                    {
                        parameters = new List<SqlParameter> {
                        new SqlParameter { ParameterName = "@unlockCode", Value = unlockCode },
                        new SqlParameter { ParameterName = "@partNumber", Value = partNumber },
                        new SqlParameter { ParameterName = "@ipAddress", Value = clientIPAddr },
                        new SqlParameter { ParameterName = "@allowed" , Value = allowed, Direction = System.Data.ParameterDirection.Output} };

                        data = new LICENSESHOPERContext().Database.ExecuteSqlRaw("exec CheckUnlockKey @unlockCode, @partNumber , @ipAddress, @allowed output", parameters.ToArray()).ToString();
                        allowed = bool.Parse(parameters[3].Value.ToString());
                    }
                }
            } catch { catched = true; }
            try { if (catched) {
                    parameters = new List<SqlParameter> {
                    new SqlParameter { ParameterName = "@unlockCode", Value = unlockCode },
                    new SqlParameter { ParameterName = "@partNumber", Value = partNumber },
                    new SqlParameter { ParameterName = "@ipAddress", Value = "Unknown" },
                    new SqlParameter { ParameterName = "@allowed" , Value = allowed, Direction = System.Data.ParameterDirection.Output} };

                    data = new LICENSESHOPERContext().Database.ExecuteSqlRaw("exec CheckUnlockKey @unlockCode, @partNumber , @ipAddress, @allowed output", parameters.ToArray()).ToString();
                    allowed = bool.Parse(parameters[3].Value.ToString());
                } } catch { }
            return JsonSerializer.Serialize(allowed);
        }

        [AllowAnonymous]
        [HttpPost("/LICENSESHOPERLicenseActivator")]
        [Consumes("application/json")]
        public async Task<string> PostLicenseActivator([FromBody] LicenseActivator record)
        {
            string data = string.Empty; List<SqlParameter> parameters = new(); bool allowed = false; bool catched = false;
            try
            {
                if (HttpContext.Connection.RemoteIpAddress != null)
                {
                    string clientIPAddr = System.Net.Dns.GetHostEntry(HttpContext.Connection.RemoteIpAddress).AddressList.First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
                    if (!string.IsNullOrWhiteSpace(clientIPAddr))
                    {
                        parameters = new List<SqlParameter> {
                        new SqlParameter { ParameterName = "@unlockCode", Value = record.UnlockCode },
                        new SqlParameter { ParameterName = "@partNumber", Value = record.PartNumber },
                        new SqlParameter { ParameterName = "@ipAddress", Value = clientIPAddr },
                        new SqlParameter { ParameterName = "@allowed" , Value = allowed, Direction = System.Data.ParameterDirection.Output} };

                        data = new LICENSESHOPERContext().Database.ExecuteSqlRaw("exec CheckUnlockKey @unlockCode, @partNumber , @ipAddress, @allowed output", parameters.ToArray()).ToString();
                        allowed = bool.Parse(parameters[3].Value.ToString());
                    }
                }
            } catch { catched = true; }
            try { if (catched) {
                    parameters = new List<SqlParameter> {
                        new SqlParameter { ParameterName = "@unlockCode", Value = record.UnlockCode },
                        new SqlParameter { ParameterName = "@partNumber", Value = record.PartNumber },
                        new SqlParameter { ParameterName = "@ipAddress", Value = "Unknown" },
                        new SqlParameter { ParameterName = "@allowed" , Value = allowed, Direction = System.Data.ParameterDirection.Output} };

                    data = new LICENSESHOPERContext().Database.ExecuteSqlRaw("exec CheckUnlockKey @unlockCode, @partNumber , @ipAddress, @allowed output", parameters.ToArray()).ToString();
                    allowed = bool.Parse(parameters[3].Value.ToString());

                } } catch { }
            return JsonSerializer.Serialize(allowed);
        }
    }
}
