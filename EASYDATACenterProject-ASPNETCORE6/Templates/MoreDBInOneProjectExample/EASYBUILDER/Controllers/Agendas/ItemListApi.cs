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
    [Route("EASYBUILDERItemList")]
    public class EASYBUILDERItemListApi : ControllerBase
    {
        [HttpGet("/EASYBUILDERItemList")]
        public async Task<string> GetItemList()
        {
            List<ItemList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new EASYBUILDERContext().ItemLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EASYBUILDERItemList/Filter/{filter}")]
        public async Task<string> GetItemListByFilter(string filter)
        {
            List<ItemList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new EASYBUILDERContext().ItemLists.FromSqlRaw("SELECT * FROM ItemList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EASYBUILDERItemList/{id}")]
        public async Task<string> GetItemListKey(int id)
        {
            ItemList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new EASYBUILDERContext().ItemLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/EASYBUILDERItemList")]
        [Consumes("application/json")]
        public async Task<string> InsertItemList([FromBody] ItemList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new EASYBUILDERContext().ItemLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/EASYBUILDERItemList")]
        [Consumes("application/json")]
        public async Task<string> UpdateItemList([FromBody] ItemList record)
        {
            try
            {
                var data = new EASYBUILDERContext().ItemLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/EASYBUILDERItemList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteItemList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                ItemList record = new() { Id = int.Parse(id) };

                var data = new EASYBUILDERContext().ItemLists.Remove(record);
                int result = await data.Context.SaveChangesAsync();

                //Remove Item Attachments Previous delete Item HERE is not deleted BY foreign key
                List<AttachmentList> Attachmentdata;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                { Attachmentdata = new EASYBUILDERContext().AttachmentLists.Where(a => a.ParentType == "ITEM" && a.ParentId == int.Parse(id)).ToList(); }
                var itemData = new EASYBUILDERContext(); itemData.AttachmentLists.RemoveRange(Attachmentdata);
                itemData.SaveChanges();

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
