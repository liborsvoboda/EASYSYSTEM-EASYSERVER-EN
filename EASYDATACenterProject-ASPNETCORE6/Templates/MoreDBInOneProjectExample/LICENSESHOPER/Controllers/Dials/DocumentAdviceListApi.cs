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
    [Route("LICENSESHOPERDocumentAdviceList")]
    public class LICENSESHOPERDocumentAdviceListApi : ControllerBase
    {
        [HttpGet("/LICENSESHOPERDocumentAdviceList")]
        public async Task<string> GetDocumentAdviceList()
        {
            List<DocumentAdviceList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().DocumentAdviceLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERDocumentAdviceList/Filter/{filter}")]
        public async Task<string> GetDocumentAdviceListByFilter(string filter)
        {
            List<DocumentAdviceList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new LICENSESHOPERContext().DocumentAdviceLists.FromSqlRaw("SELECT * FROM DocumentAdviceList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/LICENSESHOPERDocumentAdviceList/{documentType}/{branchId}")]
        public async Task<string> GetDocumentAdviceListType(string documentType, int branchId)
        {
            DocumentAdviceList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new LICENSESHOPERContext().DocumentAdviceLists.Where(a => a.DocumentType == documentType && a.Active == true && a.BranchId == branchId &&
                (a.StartDate == null || a.StartDate <= DateTime.UtcNow.Date) && (a.EndDate == null || a.EndDate >= DateTime.UtcNow.Date)).FirstOrDefault();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/LICENSESHOPERDocumentAdviceList")]
        [Consumes("application/json")]
        public async Task<string> InsertDocumentAdviceList([FromBody] DocumentAdviceList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new LICENSESHOPERContext().DocumentAdviceLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/LICENSESHOPERDocumentAdviceList")]
        [Consumes("application/json")]
        public async Task<string> UpdateDocumentAdviceList([FromBody] DocumentAdviceList record)
        {
            try
            {
                var data = new LICENSESHOPERContext().DocumentAdviceLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/LICENSESHOPERDocumentAdviceList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteDocumentAdviceList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                DocumentAdviceList record = new() { Id = int.Parse(id) };

                var data = new LICENSESHOPERContext().DocumentAdviceLists.Remove(record);
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
