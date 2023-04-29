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
    [Route("GLOBALNETUserList")]
    public class GLOBALNETUserListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETUserList")]
        public async Task<string> GetUserList()
        {
            List<UserList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().UserLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETUserList/Filter/{filter}")]
        public async Task<string> GetUserListByFilter(string filter)
        {
            List<UserList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().UserLists.FromSqlRaw("SELECT * FROM UserList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETUserList/{id}")]
        public async Task<string> GetUserListKey(int id)
        {
            UserList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().UserLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/GLOBALNETUserList")]
        [Consumes("application/json")]
        public async Task<string> InsertUserList([FromBody] UserList record)
        {
            try
            {
                record.Role = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new GLOBALNETContext().UserLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/GLOBALNETUserList")]
        [Consumes("application/json")]
        public async Task<string> UpdateUserList([FromBody] UserList record)
        {
            try
            {
                var data = new GLOBALNETContext().UserLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/GLOBALNETUserList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteUserList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                UserList record = new() { Id = int.Parse(id) };

                var data = new GLOBALNETContext().UserLists.Remove(record);
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
