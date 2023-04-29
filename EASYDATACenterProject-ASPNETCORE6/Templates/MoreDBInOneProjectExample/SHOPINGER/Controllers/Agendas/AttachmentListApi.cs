using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SHOPINGER.DBModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SHOPINGER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("SHOPINGERAttachmentList")]
    public class SHOPINGERAttachmentListApi : ControllerBase
    {
        [HttpGet("/SHOPINGERAttachmentList")]
        public async Task<string> GetAttachmentList()
        {
            List<ViewAttachmentList> data = new();
            try
            {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new SHOPINGERContext().ViewAttachmentLists.ToList(); }
            }
            catch (Exception ex)
            { }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGERAttachmentList/Filter/{filter}")]
        public async Task<string> GetAttachmentListByFilter(string filter)
        {
            List<ViewAttachmentList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new SHOPINGERContext().ViewAttachmentLists.FromSqlRaw("SELECT * FROM ViewAttachmentList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGERAttachmentList/{id}")]
        public async Task<string> GetAttachmentListByKey(int id)
        {
            AttachmentList data = new();
            try
            {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new SHOPINGERContext().AttachmentLists.Where(a => a.Id == id).First(); }
            }
            catch (Exception ex)
            { }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGERAttachmentList/{type}/{parentId}")]
        public async Task<string> GetAttachmentListKey(string type, int parentId)
        {
            List<AttachmentList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new SHOPINGERContext().AttachmentLists.Where(a => a.ParentType == type && a.ParentId == parentId).ToList(); }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/SHOPINGERAttachmentList")]
        [Consumes("application/json")]
        public async Task<string> InsertAllDocAttachmentList([FromBody] List<AttachmentList> record)
        {
            try
            {
                int result;
                var test = new SHOPINGERContext(); test.AttachmentLists.AddRange(record);
                result = test.SaveChanges();

                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpDelete("/SHOPINGERAttachmentList/{type}/{parentId}")]
        [Consumes("application/json")]
        public async Task<string> DeleteItemList(string type, int parentId)
        {
            try
            {
                List<AttachmentList> data;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new SHOPINGERContext().AttachmentLists.Where(a => a.ParentType == type && a.ParentId == parentId).ToList(); }

                var test = new SHOPINGERContext(); test.AttachmentLists.RemoveRange(data);
                int result = test.SaveChanges();

                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });

            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }
    }
}
