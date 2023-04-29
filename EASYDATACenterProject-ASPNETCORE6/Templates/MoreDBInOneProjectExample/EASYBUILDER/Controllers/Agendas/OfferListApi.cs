using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using EASYBUILDER.DBModel;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EASYBUILDER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("EASYBUILDEROfferList")]
    public class EASYBUILDEROfferListApi : ControllerBase
    {
        [HttpGet("/EASYBUILDEROfferList")]
        public async Task<string> GetOfferList()
        {
            List<OfferList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new EASYBUILDERContext().OfferLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EASYBUILDEROfferList/Filter/{filter}")]
        public async Task<string> GetOfferListByFilter(string filter)
        {
            List<OfferList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new EASYBUILDERContext().OfferLists.FromSqlRaw("SELECT * FROM OfferList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EASYBUILDEROfferList/{id}")]
        public async Task<string> GetOfferListKey(int id)
        {
            OfferList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new EASYBUILDERContext().OfferLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/EASYBUILDEROfferList")]
        [Consumes("application/json")]
        public async Task<string> InsertOfferList([FromBody] OfferList record)
        {
            try
            {
                //Increase and update Last Document Number
                DocumentAdviceList documentAdvice = new DocumentAdviceList(); string lastDocumentNumber = string.Empty;
                documentAdvice = new EASYBUILDERContext().DocumentAdviceLists.Where(a => a.DocumentType == "offer" && (a.StartDate == null || a.StartDate <= DateTime.UtcNow.Date) && (a.EndDate == null || a.EndDate >= DateTime.UtcNow.Date)).FirstOrDefault();
                if (documentAdvice != null)
                {
                    documentAdvice.Number = (int.Parse(documentAdvice.Number) + 1).ToString("D" + documentAdvice.Number.Length.ToString());
                    lastDocumentNumber = documentAdvice.Prefix + documentAdvice.Number;
                    var documentData = new EASYBUILDERContext().DocumentAdviceLists.Update(documentAdvice);
                    await documentData.Context.SaveChangesAsync();
                    record.DocumentNumber = lastDocumentNumber;
                }

                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new EASYBUILDERContext().OfferLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = lastDocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/EASYBUILDEROfferList")]
        [Consumes("application/json")]
        public async Task<string> UpdateOfferList([FromBody] OfferList record)
        {
            try
            {
                var data = new EASYBUILDERContext().OfferLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = record.DocumentNumber, recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/EASYBUILDEROfferList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteOfferList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                string docNumber = null;
                docNumber = new EASYBUILDERContext().OfferLists.First(a => a.Id == int.Parse(id)).DocumentNumber;
                OfferList record = new() { Id = int.Parse(id), DocumentNumber = docNumber };

                var data = new EASYBUILDERContext().OfferLists.Remove(record);
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
