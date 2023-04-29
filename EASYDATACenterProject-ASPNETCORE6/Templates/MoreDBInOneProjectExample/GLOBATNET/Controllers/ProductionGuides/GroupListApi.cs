using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PRUVODKY.DBModel;

namespace PRUVODKY.Controllers
{
    [Authorize]
    [ApiController]
    [Route("PRUVODKYGroupList")]
    public class PRUVODKYGroupListApi : ControllerBase
    {
        [HttpGet("/PRUVODKYGroupList")]
        public async Task<string> GetGroupList()
        {
            List<GroupList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new PRUVODKYContext().GroupLists.OrderBy(a => a.Name ).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/PRUVODKYGroupList/{id}")]
        public async Task<string> GetGroupListKey(int id)
        {
            GroupList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new PRUVODKYContext().GroupLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/PRUVODKYGroupList")]
        [Consumes("application/json")]
        public async Task<string> InsertGroupList([FromBody] GroupList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new PRUVODKYContext().GroupLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/PRUVODKYGroupList")]
        [Consumes("application/json")]
        public async Task<string> UpdateGroupList([FromBody] GroupList record)
        {
            try
            {
                var data = new PRUVODKYContext().GroupLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/PRUVODKYGroupList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteGroupList(string id)
        {
            try
            {
                int Ids;
                if (!int.TryParse(id, out Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                GroupList deleteRecord = new() { Id = int.Parse(id) };

                var data = new PRUVODKYContext().GroupLists.Remove(deleteRecord);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }
    }
}
