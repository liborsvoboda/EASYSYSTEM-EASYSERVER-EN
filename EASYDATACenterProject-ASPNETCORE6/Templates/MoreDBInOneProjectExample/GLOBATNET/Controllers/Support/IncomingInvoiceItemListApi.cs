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
    [Route("GLOBALNETIncomingInvoiceItemList")]
    public class GLOBALNETIncomingInvoiceItemListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETIncomingInvoiceItemList/{documentNumber}")]
        public async Task<string> GetIncomingInvoiceItemListKey(string documentNumber)
        {
            List<IncomingInvoiceItemList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new GLOBALNETContext().IncomingInvoiceItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/GLOBALNETIncomingInvoiceItemList")]
        [Consumes("application/json")]
        public async Task<string> InsertAllDocIncomingInvoiceItemList([FromBody] List<IncomingInvoiceItemList> record)
        {
            try
            {
                int result;
                var test = new GLOBALNETContext(); test.IncomingInvoiceItemLists.AddRange(record);
                result = test.SaveChanges();
               
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/GLOBALNETIncomingInvoiceItemList/{documentNumber}")]
        [Consumes("application/json")]
        public async Task<string> DeleteItemList(string documentNumber)
        {
            try
            {
                List<IncomingInvoiceItemList> data;
                data = new GLOBALNETContext().IncomingInvoiceItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); 
                var test = new GLOBALNETContext(); test.IncomingInvoiceItemLists.RemoveRange(data);
                int result = test.SaveChanges();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }
    }
}
