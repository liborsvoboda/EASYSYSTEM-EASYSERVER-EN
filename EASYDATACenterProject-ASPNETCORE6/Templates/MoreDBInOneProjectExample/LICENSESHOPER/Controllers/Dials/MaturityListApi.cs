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
    [Route("LICENSESHOPERMaturityList")]
    public class LICENSESHOPERMaturityListApi : ControllerBase
    {
        [HttpGet("/LICENSESHOPERMaturityList")]
        public async Task<string> GetMaturityList()
        {
            List<MaturityList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().MaturityLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERMaturityList/Filter/{filter}")]
        public async Task<string> GetMaturityListByFilter(string filter)
        {
            List<MaturityList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().MaturityLists.FromSqlRaw("SELECT * FROM MaturityList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERMaturityList/{id}")]
        public async Task<string> GetMaturityListKey(int id)
        {
            MaturityList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new LICENSESHOPERContext().MaturityLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/LICENSESHOPERMaturityList")]
        [Consumes("application/json")]
        public async Task<string> InsertMaturityList([FromBody] MaturityList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new LICENSESHOPERContext().MaturityLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/LICENSESHOPERMaturityList")]
        [Consumes("application/json")]
        public async Task<string> UpdateMaturityList([FromBody] MaturityList record)
        {
            try
            {
                var data = new LICENSESHOPERContext().MaturityLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/LICENSESHOPERMaturityList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteMaturityList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                MaturityList record = new() { Id = int.Parse(id) };

                var data = new LICENSESHOPERContext().MaturityLists.Remove(record);
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
