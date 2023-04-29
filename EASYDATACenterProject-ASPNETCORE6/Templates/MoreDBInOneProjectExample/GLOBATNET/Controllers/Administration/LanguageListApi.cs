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
using BACKENDCORE;

namespace GLOBALNET.Controllers
{
    [Authorize]
    [ApiController]
    [Route("LanguageList")]
    public class LanguageListApi : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("/LanguageList")]
        public async Task<string> GetLanguageList()
        {
            List<LanguageList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().LanguageLists.ToList();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }

        [AllowAnonymous]
        [HttpGet("/LanguageList/Filter/{filter}")]
        public async Task<string> GetLanguageListByFilter(string filter)
        {
            List<LanguageList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().LanguageLists.FromSqlRaw("SELECT * FROM LanguageList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }

        [AllowAnonymous]
        [HttpGet("/LanguageList/{id}")]
        public async Task<string> GetLanguageListKey(int id)
        {
            LanguageList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().LanguageLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }

        [HttpPut("/LanguageList")]
        [Consumes("application/json")]
        public async Task<string> InsertLanguageList([FromBody] LanguageList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new GLOBALNETContext().LanguageLists.Add(record);
                int result = await data.Context.SaveChangesAsync();

                //Server LocalFile
                DBOperations.LoadStaticDbDials(ServerLocalDbDials.LanguageList);

                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/LanguageList")]
        [Consumes("application/json")]
        public async Task<string> UpdateLanguageList([FromBody] LanguageList record)
        {
            try
            {
                var data = new GLOBALNETContext().LanguageLists.Update(record);
                int result = await data.Context.SaveChangesAsync();

                //Server LocalFile
                DBOperations.LoadStaticDbDials(ServerLocalDbDials.LanguageList);

                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/LanguageList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteLanguageList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                LanguageList record = new() { Id = int.Parse(id) };

                var data = new GLOBALNETContext().LanguageLists.Remove(record);
                int result = await data.Context.SaveChangesAsync();

                //Server LocalFile
                DBOperations.LoadStaticDbDials(ServerLocalDbDials.LanguageList);

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
