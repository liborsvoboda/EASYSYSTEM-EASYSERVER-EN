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
    [Route("PRUVODKYPersonList")]
    public class PRUVODKYPersonListApi : ControllerBase
    {
        [HttpGet("/PRUVODKYPersonList")]
        public async Task<string> GetPersonList()
        {
            List<PersonList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new PRUVODKYContext().PersonLists.OrderBy(a => a.SurName ).ThenBy(b => b.Name).ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/PRUVODKYPersonList/{id}")]
        public async Task<string> GetPersonListKey(int id)
        {
            PersonList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new PRUVODKYContext().PersonLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/PRUVODKYPersonList")]
        [Consumes("application/json")]
        public async Task<string> InsertPersonList([FromBody] PersonList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new PRUVODKYContext().PersonLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/PRUVODKYPersonList")]
        [Consumes("application/json")]
        public async Task<string> UpdatePersonList([FromBody] PersonList record)
        {
            try
            {
                var data = new PRUVODKYContext().PersonLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/PRUVODKYPersonList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeletePersonList(string id)
        {
            try
            {
                int Ids;
                if (!int.TryParse(id, out Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                PersonList deleteRecord = new() { Id = int.Parse(id) };

                var data = new PRUVODKYContext().PersonLists.Remove(deleteRecord);
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
