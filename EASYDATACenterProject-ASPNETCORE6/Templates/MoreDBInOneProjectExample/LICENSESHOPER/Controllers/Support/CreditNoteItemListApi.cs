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
    [Route("LICENSESHOPERCreditNoteItemList")]
    public class LICENSESHOPERCreditNoteItemListApi : ControllerBase
    {
        [HttpGet("/LICENSESHOPERCreditNoteItemList/{documentNumber}")]
        public async Task<string> GetCreditNoteItemListKey(string documentNumber)
        {
            List<CreditNoteItemList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new LICENSESHOPERContext().CreditNoteItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/LICENSESHOPERCreditNoteItemList")]
        [Consumes("application/json")]
        public async Task<string> InsertAllDocCreditNoteItemList([FromBody] List<CreditNoteItemList> record)
        {
            try
            {
                int result;
                var test = new LICENSESHOPERContext(); test.CreditNoteItemLists.AddRange(record);
                result = test.SaveChanges();
               
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/LICENSESHOPERCreditNoteItemList/{documentNumber}")]
        [Consumes("application/json")]
        public async Task<string> DeleteItemList(string documentNumber)
        {
            try
            {
                List<CreditNoteItemList> data;
                data = new LICENSESHOPERContext().CreditNoteItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); 
                var test = new LICENSESHOPERContext(); test.CreditNoteItemLists.RemoveRange(data);
                int result = test.SaveChanges();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }
    }
}
