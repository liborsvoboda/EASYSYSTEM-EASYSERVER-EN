using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SHOPINGER.DBModel;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SHOPINGER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("SHOPINGEROutgoingOrderList")]
    public class SHOPINGEROutgoingOrderListApi : ControllerBase
    {
        [HttpGet("/SHOPINGEROutgoingOrderList")]
        public async Task<string> GetOutgoingOrderList()
        {
            List<OutgoingOrderList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new SHOPINGERContext().OutgoingOrderLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGEROutgoingOrderList/Filter/{filter}")]
        public async Task<string> GetOutgoingOrderListByFilter(string filter)
        {
            List<OutgoingOrderList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new SHOPINGERContext().OutgoingOrderLists.FromSqlRaw("SELECT * FROM OutgoingOrderList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/SHOPINGEROutgoingOrderList/{id}")]
        public async Task<string> GetOutgoingOrderListKey(int id)
        {
            OutgoingOrderList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new SHOPINGERContext().OutgoingOrderLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/SHOPINGEROutgoingOrderList")]
        [Consumes("application/json")]
        public async Task<string> InsertOutgoingOrderList([FromBody] OutgoingOrderList record)
        {
            try
            {
                //Increase and update Last Document Number
                DocumentAdviceList documentAdvice = new DocumentAdviceList(); string lastDocumentNumber = string.Empty;
                documentAdvice = new SHOPINGERContext().DocumentAdviceLists.Where(a => a.DocumentType == "outgoingOrder" && (a.StartDate == null || a.StartDate <= DateTime.UtcNow.Date) && (a.EndDate == null || a.EndDate >= DateTime.UtcNow.Date)).FirstOrDefault();
                if (documentAdvice != null)
                {
                    documentAdvice.Number = (int.Parse(documentAdvice.Number) + 1).ToString("D" + documentAdvice.Number.Length.ToString());
                    lastDocumentNumber = documentAdvice.Prefix + documentAdvice.Number;
                    var documentData = new SHOPINGERContext().DocumentAdviceLists.Update(documentAdvice);
                    await documentData.Context.SaveChangesAsync();
                    record.DocumentNumber = lastDocumentNumber;
                }

                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new SHOPINGERContext().OutgoingOrderLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = lastDocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/SHOPINGEROutgoingOrderList")]
        [Consumes("application/json")]
        public async Task<string> UpdateOutgoingOrderList([FromBody] OutgoingOrderList record)
        {
            try
            {
                var data = new SHOPINGERContext().OutgoingOrderLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = record.DocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/SHOPINGEROutgoingOrderList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteOutgoingOrderList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                string docNumber = null;
                docNumber = new SHOPINGERContext().OutgoingOrderLists.First(a => a.Id == int.Parse(id)).DocumentNumber;
                OutgoingOrderList record = new() { Id = int.Parse(id), DocumentNumber = docNumber };

                var data = new SHOPINGERContext().OutgoingOrderLists.Remove(record);
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
