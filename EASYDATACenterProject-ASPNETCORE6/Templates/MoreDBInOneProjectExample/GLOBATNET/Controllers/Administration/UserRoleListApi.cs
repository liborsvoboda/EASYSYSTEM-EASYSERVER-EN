using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using GLOBALNET.DBModel;
using System.Text.Json.Serialization;

namespace GLOBALNET.Controllers
{
    [Authorize]
    [ApiController]
    [Route("UserRoleList")]
    public class UserRoleListApi : ControllerBase
    {
        [HttpGet("/UserRoleList")]
        public async Task<string> GetUserRoleList()
        {
            List<UserRoleList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {   //new GLOBALNETContext().FreeLicenseLists.Include(co => co.Item).ToList();       
                data = new GLOBALNETContext().UserRoleLists.ToList();
            }
            //return JsonSerializer.Serialize(data, new JsonSerializerOptions() { WriteIndented = true, IncludeFields = true });
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }

        [HttpGet("/UserRoleList/Filter/{filter}")]
        public async Task<string> GetUserRoleListByFilter(string filter)
        {
            List<UserRoleList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().UserRoleLists.FromSqlRaw("SELECT * FROM UserRoleList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/UserRoleList/{id}")]
        public async Task<string> GetUserRoleListId(int id)
        {
            UserRoleList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted 
            }))
            {
                data = new GLOBALNETContext().UserRoleLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/UserRoleList")]
        [Consumes("application/json")]
        public async Task<string> InsertUserRoleList([FromBody] UserRoleList record)
        {
            try
            {
                var data = new GLOBALNETContext().UserRoleLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/UserRoleList")]
        [Consumes("application/json")]
        public async Task<string> UpdateUserRoleList([FromBody] UserRoleList record)
        {
            try
            {
                var data = new GLOBALNETContext().UserRoleLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpDelete("/UserRoleList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteUserRoleList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                UserRoleList record = new() { Id = int.Parse(id) };

                var data = new GLOBALNETContext().UserRoleLists.Remove(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }
    }
}
