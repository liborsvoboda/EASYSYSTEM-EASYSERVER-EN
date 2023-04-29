using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Transactions;
using BACKENDCORE.SharedApiClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GLOBALNET.DBModel;
using Swashbuckle.AspNetCore.Annotations;

namespace GLOBALNET.Controllers
{
    /// <summary>
    /// Universal Template For Make Any Full Backend Server
    /// One Template Has All data operation Controls for simple copy and build ANY Backend Server
    /// </summary>
    [ApiController]
    [Route("GLOBALNETIgnoredExceptionList")]
    [SwaggerTag("API Template with INSERT/UPDATE/DELETE/SELECT AND FILTERING APIs")]
    public class GLOBALNETIgnoredExceptionListApi : ControllerBase
    {

        /// <summary>
        /// Operation: Select All records
        /// Standart API for return all records from DB table
        /// </summary>
        /// <returns></returns>
        [HttpGet("/GLOBALNETIgnoredExceptionList")]
        [SwaggerOperation(Summary = "Get All records", Description = "Async standard select record API", OperationId = "Select all records", Tags = new[] { "GLOBALNETIgnoredExceptionListApi" })]
        public async Task<string> GetIgnoredExceptionList()
        {
            List<IgnoredExceptionList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().IgnoredExceptionLists.ToList();
            }

            return JsonSerializer.Serialize(data);
        }


        /// <summary>
        /// Operation: Select By sent SQL Where Condition
        /// Standart API for return records by Where condition in Query from DB table
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet("/GLOBALNETIgnoredExceptionList/Filter/{filter}")]
        [SwaggerOperation(Summary = "Get records by Advanced filter", Description = "Async standard select records by advanced filter API", OperationId = "Select records by Advanced filter", Tags = new[] { "GLOBALNETIgnoredExceptionListApi" })]
        public async Task<string> GetIgnoredExceptionListByFilter(string filter)
        {
            List<IgnoredExceptionList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new GLOBALNETContext().IgnoredExceptionLists.FromSqlRaw("SELECT * FROM IgnoredExceptionList WHERE 1=1 AND " + filter.Replace("+"," ")).AsNoTracking().ToList();
            }

            return JsonSerializer.Serialize(data);
        }


        /// <summary>
        /// Operation: Select Unique record
        /// Standart API for return one record by primary Id key from DB table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/GLOBALNETIgnoredExceptionList/{id}")]
        [SwaggerOperation(Summary = "Get Record by Id", Description = "Async standard Get record by Id API", OperationId = "Get One record", Tags = new[] { "GLOBALNETIgnoredExceptionListApi" })]
        public async Task<string> GetIgnoredExceptionListKey(int id)
        {
            IgnoredExceptionList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            }))
            {
                data = new GLOBALNETContext().IgnoredExceptionLists.Where(a => a.Id == id).First();
            }

            return JsonSerializer.Serialize(data);
        }


        /// <summary>
        /// Operation: Insert new record
        /// Standart API for insert new record to DB table
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPut("/GLOBALNETIgnoredExceptionList")]
        [Consumes("application/json")]
        [SwaggerOperation(Summary = "Create a new Record", Description = "Async standard Insert record API", OperationId = "Insert New Record", Tags = new[] { "GLOBALNETIgnoredExceptionListApi" })]
        public async Task<string> InsertIgnoredExceptionList([FromBody] IgnoredExceptionList record)
        {
            try
            {
                record.User = null;  //EntityState.Detached IDENTITY_INSERT is set to OFF
                var data = new GLOBALNETContext().IgnoredExceptionLists.Add(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Operation: Update record by unique Id key
        /// Standart API for update existing record in DB table
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost("/GLOBALNETIgnoredExceptionList")]
        [Consumes("application/json")]
        [SwaggerOperation(Summary = "Update Record", Description = "Async standard Update record API", OperationId = "Update Record", Tags = new[] { "GLOBALNETIgnoredExceptionListApi" })]
        public async Task<string> UpdateIgnoredExceptionList([FromBody] IgnoredExceptionList record)
        {
            try
            {
                var data = new GLOBALNETContext().IgnoredExceptionLists.Update(record);
                int result = await data.Context.SaveChangesAsync();
                if (result > 0) return JsonSerializer.Serialize(new DBResultMessage() { insertedId = record.Id, status = DBResult.success.ToString(), recordCount = result, ErrorMessage = string.Empty });
                else return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = result, ErrorMessage = string.Empty });
            }
            catch (Exception ex)
            { return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = SystemFunctions.GetUserApiErrMessage(ex) }); }
        }


        /// <summary>
        /// Operation: Delete record by unique Id key
        /// Standart API for delete existing record in DB table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpDelete("/GLOBALNETIgnoredExceptionList/{id}")]
        [Consumes("application/json")]
        [SwaggerOperation(Summary = "Delete Record", Description = "Async standard Delete record API", OperationId = "Delete Record", Tags = new[] { "GLOBALNETIgnoredExceptionListApi" })]
        public async Task<string> DeleteIgnoredExceptionList(string id)
        {
            try
            {
                if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new DBResultMessage() { status = DBResult.error.ToString(), recordCount = 0, ErrorMessage = "Id is not set" });

                IgnoredExceptionList record = new() { Id = int.Parse(id) };

                var data = new GLOBALNETContext().IgnoredExceptionLists.Remove(record);
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
