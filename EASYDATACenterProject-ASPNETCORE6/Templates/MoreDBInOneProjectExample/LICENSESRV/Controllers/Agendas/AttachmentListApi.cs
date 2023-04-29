using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LICENSESRV.DBModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LICENSESRV.Controllers
{
    [Authorize]
    [ApiController]
    [Route("LICENSESRVAttachmentList")]
    public class LICENSESRVAttachmentListApi : ControllerBase
    {
        [HttpGet("/LICENSESRVAttachmentList")]
        public async Task<string> GetAttachmentList()
        {
            List<ViewAttachmentList> data = new();
            try
            {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new LICENSESRVContext().ViewAttachmentLists.ToList(); }
            }
            catch (Exception ex)
            { }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESRVAttachmentList/{id}")]
        public async Task<string> GetAttachmentListByKey(int id)
        {
            AttachmentList data = new();
            try
            {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new LICENSESRVContext().AttachmentLists.Where(a => a.Id == id).First(); }
            }
            catch (Exception ex)
            { }
            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESRVAttachmentList/{type}/{parentId}")]
        public async Task<string> GetAttachmentListKey(string type, int parentId)
        {
            List<AttachmentList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new LICENSESRVContext().AttachmentLists.Where(a => a.ParentType == type && a.ParentId == parentId).ToList(); }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/LICENSESRVAttachmentList")]
        [Consumes("application/json")]
        public async Task<string> InsertAllDocAttachmentList([FromBody] List<AttachmentList> record)
        {
            try
            {
                int result;
                var test = new LICENSESRVContext(); test.AttachmentLists.AddRange(record);
                result = test.SaveChanges();

                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpDelete("/LICENSESRVAttachmentList/{type}/{parentId}")]
        [Consumes("application/json")]
        public async Task<string> DeleteItemList(string type, int parentId)
        {
            try
            {
                List<AttachmentList> data;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { data = new LICENSESRVContext().AttachmentLists.Where(a => a.ParentType == type && a.ParentId == parentId).ToList(); }

                var test = new LICENSESRVContext(); test.AttachmentLists.RemoveRange(data);
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
