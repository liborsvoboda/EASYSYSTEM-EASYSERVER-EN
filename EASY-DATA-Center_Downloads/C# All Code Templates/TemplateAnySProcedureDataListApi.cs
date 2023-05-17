namespace EASYDATACenter.Controllers {
    [Authorize]
    [ApiController]
    [Route("TemplateAnySProcedureData")]
    public class TemplateAnySProcedureDataListApi : ControllerBase {
        /// <summary>
        /// Gets the template any s procedure data list. Simple Call Procedure and the Table Result
        /// is Fill to List od Class Class must Have same Column Names as in SP result
        /// 'CollectionFromSql' and Your Class as Generic 'CollectionFromSql' is Extended for Main
        /// EASYDATACenter Schema If you implement other new schema, you must copy these extensions
        /// </summary>
        /// <returns></returns>
        [HttpGet("/TemplateAnySProcedureData")]
        public async Task<string> GetTemplateAnySProcedureDataList() {
            List<CustomString> data = new();
            data = new EASYDATACenterContext().CollectionFromSql<CustomString>("EXEC GetTables;");

            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }
    }
}