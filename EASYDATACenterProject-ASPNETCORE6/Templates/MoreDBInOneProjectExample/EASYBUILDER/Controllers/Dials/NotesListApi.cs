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
    [Route("EASYBUILDERNotesList")]
    public class EASYBUILDERNotesListApi : ControllerBase
    {
        [HttpGet("/EASYBUILDERNotesList")]
        public async Task<string> GetNotesList()
        {
            List<NotesList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new EASYBUILDERContext().NotesLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EASYBUILDERNotesList/Filter/{filter}")]
        public async Task<string> GetNotesListByFilter(string filter)
        {
            List<NotesList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new EASYBUILDERContext().NotesLists.FromSqlRaw("SELECT * FROM NotesList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpGet("/EASYBUILDERNotesList/{id}")]
        public async Task<string> GetNotesListKey(int id)
        {
            NotesList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new EASYBUILDERContext().NotesLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }

        [HttpPut("/EASYBUILDERNotesList")]
        [Consumes("application/json")]
        public async Task<string> InsertNotesList([FromBody] NotesList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new EASYBUILDERContext().NotesLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }

        [HttpPost("/EASYBUILDERNotesList")]
        [Consumes("application/json")]
        public async Task<string> UpdateNotesList([FromBody] NotesList record)
        {
            try
            {
                var data = new EASYBUILDERContext().NotesLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }

        [HttpDelete("/EASYBUILDERNotesList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteNotesList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                NotesList record = new() { Id = int.Parse(id) };

                var data = new EASYBUILDERContext().NotesLists.Remove(record);
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
