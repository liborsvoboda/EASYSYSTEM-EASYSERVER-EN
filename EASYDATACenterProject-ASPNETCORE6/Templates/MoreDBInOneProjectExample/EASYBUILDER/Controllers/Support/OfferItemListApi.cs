using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using EASYBUILDER.DBModel;

namespace EASYBUILDER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("EASYBUILDEROfferItemList")]
    public class EASYBUILDEROfferItemListApi : ControllerBase
    {
        [HttpGet("/EASYBUILDEROfferItemList/{documentNumber}")]
        public async Task<string> GetOfferItemListKey(string documentNumber)
        {
            List<OfferItemList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new EASYBUILDERContext().OfferItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/EASYBUILDEROfferItemList")]
        [Consumes("application/json")]
        public async Task<string> InsertAllDocOfferItemList([FromBody] List<OfferItemList> record)
        {
            try
            {
                int result;
                var test = new EASYBUILDERContext(); test.OfferItemLists.AddRange(record);
                result = test.SaveChanges();
               
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/EASYBUILDEROfferItemList/{documentNumber}")]
        [Consumes("application/json")]
        public async Task<string> DeleteItemList(string documentNumber)
        {
            try
            {
                List<OfferItemList> data;
                data = new EASYBUILDERContext().OfferItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); 
                var test = new EASYBUILDERContext(); test.OfferItemLists.RemoveRange(data);
                int result = test.SaveChanges();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }
    }
}
