using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using GLOBALNET.DBModel;
using static GLOBALNET.SharedApiClasses.ApiClassesExtension;

namespace GLOBALNET.Controllers
{
    [Authorize]
    [ApiController]
    [Route("GLOBALNETReportQueueList")]
    public class GLOBALNETReportQueueListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETReportQueueList")]
        public async Task<string> GetReportQueueList()
        {
            List<ReportQueueList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().ReportQueueLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETReportQueueList/Filter/{filter}")]
        public async Task<string> GetReportQueueListByFilter(string filter)
        {
            List<ReportQueueList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().ReportQueueLists.FromSqlRaw("SELECT * FROM ReportQueueList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETReportQueueList/{id}")]
        public async Task<string> GetReportQueueListKey(int id)
        {
            ReportQueueList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().ReportQueueLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/GLOBALNETReportQueueList")]
        [Consumes("application/json")]
        public async Task<string> InsertReportQueueList([FromBody] ReportQueueList record)
        {
            try
            {
                var data = new GLOBALNETContext().ReportQueueLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/GLOBALNETReportQueueList/WriteFilter")]
        [Consumes("application/json")]
        public async Task<string> UpdateReportQueueListWriteFilter([FromBody] SetReportFilter record)
        {
            try
            {
                List<ReportQueueList> dbData;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { dbData = new GLOBALNETContext().ReportQueueLists.Where(a => a.TableName == record.TableName).ToList(); }
                dbData.ForEach(rec => { rec.Filter = record.Filter; rec.Search = record.Search; rec.RecId = record.RecId; });

                var data = new GLOBALNETContext();
                data.ReportQueueLists.UpdateRange(dbData);
                int result = await data.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpPost("/GLOBALNETReportQueueList")]
        [Consumes("application/json")]
        public async Task<string> UpdateReportQueueList([FromBody] ReportQueueList record)
        {
            try
            {
                var data = new GLOBALNETContext().ReportQueueLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/GLOBALNETReportQueueList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteReportQueueList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                ReportQueueList record = new() { Id = int.Parse(id) };

                var data = new GLOBALNETContext().ReportQueueLists.Remove(record);
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
