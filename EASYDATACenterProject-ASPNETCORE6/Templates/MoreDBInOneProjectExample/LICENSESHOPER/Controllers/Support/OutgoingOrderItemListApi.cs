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
    [Route("LICENSESHOPEROutgoingOrderItemList")]
    public class LICENSESHOPEROutgoingOrderItemListApi : ControllerBase
    {
        [HttpGet("/LICENSESHOPEROutgoingOrderItemList/{documentNumber}")]
        public async Task<string> GetOutgoingOrderItemListKey(string documentNumber)
        {
            List<OutgoingOrderItemList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { data = new LICENSESHOPERContext().OutgoingOrderItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/LICENSESHOPEROutgoingOrderItemList")]
        [Consumes("application/json")]
        public async Task<string> InsertAllDocOutgoingOrderItemList([FromBody] List<OutgoingOrderItemList> record)
        {
            try
            {
                int result;
                var test = new LICENSESHOPERContext(); test.OutgoingOrderItemLists.AddRange(record);
                result = test.SaveChanges();
               
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/LICENSESHOPEROutgoingOrderItemList/{documentNumber}")]
        [Consumes("application/json")]
        public async Task<string> DeleteItemList(string documentNumber)
        {
            try
            {
                List<OutgoingOrderItemList> data;
                data = new LICENSESHOPERContext().OutgoingOrderItemLists.Where(a => a.DocumentNumber == documentNumber).ToList(); 
                var test = new LICENSESHOPERContext(); test.OutgoingOrderItemLists.RemoveRange(data);
                int result = test.SaveChanges();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = 0, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            } catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }
    }
}
