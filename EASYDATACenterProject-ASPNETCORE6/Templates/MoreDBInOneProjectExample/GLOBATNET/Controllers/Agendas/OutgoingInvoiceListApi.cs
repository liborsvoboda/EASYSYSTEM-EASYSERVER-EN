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
    [Route("GLOBALNETOutgoingInvoiceList")]
    public class GLOBALNETOutgoingInvoiceListApi : ControllerBase
    {
        [HttpGet("/GLOBALNETOutgoingInvoiceList")]
        public async Task<string> GetOutgoingInvoiceList()
        {
            List<OutgoingInvoiceList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().OutgoingInvoiceLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETOutgoingInvoiceList/Filter/{filter}")]
        public async Task<string> GetOutgoingInvoiceListByFilter(string filter)
        {
            List<OutgoingInvoiceList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().OutgoingInvoiceLists.FromSqlRaw("SELECT * FROM OutgoingInvoiceList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/GLOBALNETOutgoingInvoiceList/{id}")]
        public async Task<string> GetOutgoingInvoiceListKey(int id)
        {
            OutgoingInvoiceList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().OutgoingInvoiceLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/GLOBALNETOutgoingInvoiceList")]
        [Consumes("application/json")]
        public async Task<string> InsertOutgoingInvoiceList([FromBody] OutgoingInvoiceList record)
        {
            try
            {
                //Increase and update Last Document Number
                DocumentAdviceList documentAdvice = new DocumentAdviceList(); string lastDocumentNumber = string.Empty;
                documentAdvice = new GLOBALNETContext().DocumentAdviceLists.Where(a => a.DocumentType == "outgoingInvoice" && (a.StartDate == null || a.StartDate <= DateTime.UtcNow.Date) && (a.EndDate == null || a.EndDate >= DateTime.UtcNow.Date)).FirstOrDefault();
                if (documentAdvice != null)
                {
                    documentAdvice.Number = (int.Parse(documentAdvice.Number) + 1).ToString("D" + documentAdvice.Number.Length.ToString());
                    lastDocumentNumber = documentAdvice.Prefix + documentAdvice.Number;
                    var documentData = new GLOBALNETContext().DocumentAdviceLists.Update(documentAdvice);
                    await documentData.Context.SaveChangesAsync();
                    record.DocumentNumber = lastDocumentNumber;
                }

                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new GLOBALNETContext().OutgoingInvoiceLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = lastDocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/GLOBALNETOutgoingInvoiceList")]
        [Consumes("application/json")]
        public async Task<string> UpdateOutgoingInvoiceList([FromBody] OutgoingInvoiceList record)
        {
            try
            {
                var data = new GLOBALNETContext().OutgoingInvoiceLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = record.DocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/GLOBALNETOutgoingInvoiceList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteOutgoingInvoiceList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                string docNumber = null;
                docNumber = new GLOBALNETContext().OutgoingInvoiceLists.First(a => a.Id == int.Parse(id)).DocumentNumber;
                OutgoingInvoiceList record = new() { Id = int.Parse(id), DocumentNumber = docNumber };

                var data = new GLOBALNETContext().OutgoingInvoiceLists.Remove(record);
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
