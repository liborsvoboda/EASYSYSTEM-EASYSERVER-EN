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
    [Route("GLOBALNETCreditNoteList")]
    public class GLOBALNETCreditNoteListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETCreditNoteList")]
        public async Task<string> GetCreditNoteList()
        {
            List<CreditNoteList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().CreditNoteLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETCreditNoteList/Filter/{filter}")]
        public async Task<string> GetCreditNoteListByFilter(string filter)
        {
            List<CreditNoteList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().CreditNoteLists.FromSqlRaw("SELECT * FROM CreditNoteList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETCreditNoteList/{id}")]
        public async Task<string> GetCreditNoteListKey(int id)
        {
            CreditNoteList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().CreditNoteLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/GLOBALNETCreditNoteList")]
        [Consumes("application/json")]
        public async Task<string> InsertCreditNoteList([FromBody] CreditNoteList record)
        {
            try
            {
                //Increase and update Last Document Number
                DocumentAdviceList documentAdvice = new DocumentAdviceList(); string lastDocumentNumber = string.Empty;
                documentAdvice = new GLOBALNETContext().DocumentAdviceLists.Where(a => a.DocumentType == "creditNote" && (a.StartDate == null || a.StartDate <= DateTime.UtcNow.Date) && (a.EndDate == null || a.EndDate >= DateTime.UtcNow.Date)).FirstOrDefault();
                if (documentAdvice != null)
                {
                    documentAdvice.Number = (int.Parse(documentAdvice.Number) + 1).ToString("D" + documentAdvice.Number.Length.ToString());
                    lastDocumentNumber = documentAdvice.Prefix + documentAdvice.Number;
                    var documentData = new GLOBALNETContext().DocumentAdviceLists.Update(documentAdvice);
                    await documentData.Context.SaveChangesAsync();
                    record.DocumentNumber = lastDocumentNumber;
                }

                //Load Credit Note Status
                PaymentStatusList creditNoteStatus = new GLOBALNETContext().PaymentStatusLists.Where(a => a.CreditNote).FirstOrDefault();

                //Update Invoice Identificator And Credit Note Status
                OutgoingInvoiceList parentInvoice = new OutgoingInvoiceList();
                parentInvoice = new GLOBALNETContext().OutgoingInvoiceLists.Where(a => a.DocumentNumber == record.InvoiceNumber).First();
                if (creditNoteStatus != null) { parentInvoice.PaymentStatusId = creditNoteStatus.Id; } //Automatic Credit Note status

                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new GLOBALNETContext().CreditNoteLists.Add(record);
                int result = await data.Context.SaveChangesAsync();

                //Insert CreditNoteId to Invoice
                parentInvoice.CreditNoteId = record.Id;
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

        [HttpPost("/GLOBALNETCreditNoteList")]
        [Consumes("application/json")]
        public async Task<string> UpdateCreditNoteList([FromBody] CreditNoteList record)
        {
            try
            {
                var data = new GLOBALNETContext().CreditNoteLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = record.DocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/GLOBALNETCreditNoteList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteCreditNoteList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                string docNumber = null;
                docNumber = new GLOBALNETContext().CreditNoteLists.First(a => a.Id == int.Parse(id)).DocumentNumber;
                CreditNoteList record = new() { Id = int.Parse(id), DocumentNumber = docNumber };

                var data = new GLOBALNETContext().CreditNoteLists.Remove(record);
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
