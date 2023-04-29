using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using GLOBALNET.DBModel;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GLOBALNET.Controllers
{
    [Authorize]
    [ApiController]
    [Route("GLOBALNETReceiptList")]
    public class GLOBALNETReceiptListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETReceiptList")]
        public async Task<string> GetReceiptList()
        {
            List<ReceiptList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().ReceiptLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETReceiptList/Filter/{filter}")]
        public async Task<string> GetReceiptListByFilter(string filter)
        {
            List<ReceiptList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().ReceiptLists.FromSqlRaw("SELECT * FROM ReceiptList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETReceiptList/{id}")]
        public async Task<string> GetReceiptListKey(int id)
        {
            ReceiptList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().ReceiptLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/GLOBALNETReceiptList")]
        [Consumes("application/json")]
        public async Task<string> InsertReceiptList([FromBody] ReceiptList record)
        {
            try
            {
                //Increase and update Last Document Number
                DocumentAdviceList documentAdvice = new DocumentAdviceList(); string lastDocumentNumber = string.Empty;
                documentAdvice = new GLOBALNETContext().DocumentAdviceLists.Where(a => a.DocumentType == "receipt" && (a.StartDate == null || a.StartDate <= DateTime.UtcNow.Date) && (a.EndDate == null || a.EndDate >= DateTime.UtcNow.Date)).FirstOrDefault();
                if (documentAdvice != null)
                {
                    documentAdvice.Number = (int.Parse(documentAdvice.Number) + 1).ToString("D" + documentAdvice.Number.Length.ToString());
                    lastDocumentNumber = documentAdvice.Prefix + documentAdvice.Number;
                    var documentData = new GLOBALNETContext().DocumentAdviceLists.Update(documentAdvice);
                    await documentData.Context.SaveChangesAsync();
                    record.DocumentNumber = lastDocumentNumber;
                }

                //Load Receipt Status
                PaymentStatusList receiptStatus = new GLOBALNETContext().PaymentStatusLists.Where(a => a.Receipt).FirstOrDefault();

                //Update Invoice Identificator And Receipt Status
                OutgoingInvoiceList parentInvoice = new OutgoingInvoiceList();
                parentInvoice = new GLOBALNETContext().OutgoingInvoiceLists.Where(a => a.DocumentNumber == record.InvoiceNumber).First();
                if (receiptStatus != null) { parentInvoice.PaymentStatusId = receiptStatus.Id; } //Automatic Receipt status

                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new GLOBALNETContext().ReceiptLists.Add(record);
                int result = await data.Context.SaveChangesAsync();

                //Insert ReceiptId to Invoice
                parentInvoice.ReceiptId = record.Id;
                var invoiceData = new GLOBALNETContext().OutgoingInvoiceLists.Update(parentInvoice);
                await invoiceData.Context.SaveChangesAsync();

                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = lastDocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/GLOBALNETReceiptList")]
        [Consumes("application/json")]
        public async Task<string> UpdateReceiptList([FromBody] ReceiptList record)
        {
            try
            {
                var data = new GLOBALNETContext().ReceiptLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = record.DocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/GLOBALNETReceiptList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteReceiptList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                string docNumber = null;
                docNumber = new GLOBALNETContext().ReceiptLists.First(a => a.Id == int.Parse(id)).DocumentNumber;
                ReceiptList record = new() { Id = int.Parse(id), DocumentNumber = docNumber };

                var data = new GLOBALNETContext().ReceiptLists.Remove(record);
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
