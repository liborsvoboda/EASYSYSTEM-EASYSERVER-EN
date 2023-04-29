using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using GLOBALNET.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using GLOBALNET.DBModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.Json.Serialization;
using BACKENDCORE.SharedApiClasses;

namespace GLOBALNET.Controllers
{
    [Authorize]
    [ApiController]
    [Route("DocumentTypeList")]
    public class DocumentTypeListApi : ControllerBase
    {
        [HttpGet("/DocumentTypeList")]
        public async Task<string> GetDocumentTypeList()
        {
            List<DocumentTypeList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().DocumentTypeLists.ToList();

            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }

        [HttpGet("/DocumentTypeList/Filter/{filter}")]
        public async Task<string> GetDocumentTypeListByFilter(string filter)
        {
            List<DocumentTypeList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().DocumentTypeLists.FromSqlRaw("SELECT * FROM DocumentTypeList WHERE 1=1 AND " + filter.Replace("+"," "))
                .AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }

        [HttpGet("/DocumentTypeList/{id}")]
        public async Task<string> GetDocumentTypeListKey(int id)
        {
            DocumentTypeList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().DocumentTypeLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }

        [HttpPut("/DocumentTypeList")]
        [Consumes("application/json")]
        public async Task<string> InsertDocumentTypeList([FromBody] DocumentTypeList record)
        {
            try
            {
                //Check exist  translations
                LanguageList languageRec = new GLOBALNETContext().LanguageLists.Where(a => a.SystemName == record.SystemName).FirstOrDefault();

                //Insert translation before save new Document Type
                if (languageRec == null)
                {
                    languageRec = new LanguageList() { SystemName = record.SystemName, UserId = record.UserId, DescriptionCz= record.SystemName,DescriptionEn = record.SystemName };
                    await new GLOBALNETContext().LanguageLists.Add(languageRec).Context.SaveChangesAsync();
                }
                

                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new GLOBALNETContext().DocumentTypeLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/DocumentTypeList")]
        [Consumes("application/json")]
        public async Task<string> UpdateDocumentTypeList([FromBody] DocumentTypeList record)
        {
            try
            {
                var data = new GLOBALNETContext().DocumentTypeLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/DocumentTypeList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteDocumentTypeList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                DocumentTypeList record = new() { Id = int.Parse(id) };

                var data = new GLOBALNETContext().DocumentTypeLists.Remove(record);
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
