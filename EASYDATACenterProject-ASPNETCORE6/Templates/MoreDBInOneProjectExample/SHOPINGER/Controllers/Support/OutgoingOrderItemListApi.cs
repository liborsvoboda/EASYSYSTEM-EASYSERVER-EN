using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SHOPINGER.DBModel;

namespace SHOPINGER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("SHOPINGEROutgoingOrderItemList")]
    public class SHOPINGEROutgoingOrderItemListApi : ControllerBase
    {
        [HttpGet("/SHOPINGEROutgoingOrderItemList/{documentNumber}")]
        public async Task<string> GetOutgoingOrderItemListKey(string documentNumber)
        {
            List<OutgoingOrderItemList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new SHOPINGERContext().OutgoingOrderItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/SHOPINGEROutgoingOrderItemList")]
        [Consumes("application/json")]
        public async Task<string> InsertAllDocOutgoingOrderItemList([FromBody] List<OutgoingOrderItemList> record)
        {
            try
            {
                int result;
                var test = new SHOPINGERContext(); test.OutgoingOrderItemLists.AddRange(record);
                result = test.SaveChanges();
               
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/SHOPINGEROutgoingOrderItemList/{documentNumber}")]
        [Consumes("application/json")]
        public async Task<string> DeleteItemList(string documentNumber)
        {
            try
            {
                List<OutgoingOrderItemList> data;
                data = new SHOPINGERContext().OutgoingOrderItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); 
                var test = new SHOPINGERContext(); test.OutgoingOrderItemLists.RemoveRange(data);
                int result = test.SaveChanges();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }
    }
}
