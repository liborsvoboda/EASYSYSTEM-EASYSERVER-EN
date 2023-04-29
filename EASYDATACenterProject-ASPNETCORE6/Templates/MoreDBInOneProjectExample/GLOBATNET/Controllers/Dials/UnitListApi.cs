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
    [Route("GLOBALNETUnitList")]
    public class GLOBALNETUnitListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETUnitList")]
        public async Task<string> GetUnitList()
        {
            List<UnitList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().UnitLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETUnitList/Filter/{filter}")]
        public async Task<string> GetUnitListByFilter(string filter)
        {
            List<UnitList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().UnitLists.FromSqlRaw("SELECT * FROM UnitList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETUnitList/{id}")]
        public async Task<string> GetUnitListId(int id)
        {
            UnitList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted 
            }))
            {
                data = new GLOBALNETContext().UnitLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/GLOBALNETUnitList")]
        [Consumes("application/json")]
        public async Task<string> InsertUnitList([FromBody] UnitList record)
        {
            try
            {
                record.User = null;
                var data = new GLOBALNETContext().UnitLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/GLOBALNETUnitList")]
        [Consumes("application/json")]
        public async Task<string> UpdateUnitList([FromBody] UnitList record)
        {
            try
            {
                var data = new GLOBALNETContext().UnitLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpDelete("/GLOBALNETUnitList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteUnitList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                UnitList record = new() { Id = int.Parse(id) };

                var data = new GLOBALNETContext().UnitLists.Remove(record);
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
