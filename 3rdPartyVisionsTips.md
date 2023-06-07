<a name='assembly'></a>
# EASY-SYSTEM-Builder & EASY-DATA-Center Visual Studio Help

---

### Migration between Database Types
* Install 'Mysql WorkBench' SW
* run migrations 

Help: https://severalnines.com/blog/how-migrate-mssql-mysql/  
SW: https://dev.mysql.com/downloads/file/?id=517975  

---

### Windows Store Download App Link Generator
* insert App detail link from web store
* Example: [https://apps.microsoft.com/store/detail/xaml-studio/9NTLS214TKMQ](https://apps.microsoft.com/store/detail/xaml-studio/9NTLS214TKMQ "")  
* [https://store.rg-adguard.net/](https://store.rg-adguard.net/ "")   

---

### Windows Apps & Windows Tools
* in start menu Windows Kits
* cmd Reset Store Settings
```
wsreset.exe
```

---

### MarkDown Item Template  
```cs

```

---

### API Condition for Ignore In Swagger Docs

```cs

[ApiExplorerSettings(IgnoreApi = true)]

```

---

### API Description For Descripting In Swagger Docs

```cs

[SwaggerTag("API Template with INSERT/UPDATE/DELETE/SELECT AND FILTERING APIs")]
public class TemplateListApi : ControllerBase {

[SwaggerOperation(Summary = "Get All records", Description = "Async standard select record API", OperationId = "Select all records", Tags = new[] { "TemplateListApi" })]
public async Task<string> GetTemplateList() {

[HttpDelete("/TemplateList/{id}")]
[Consumes("application/json")]
[SwaggerOperation(Summary = "Delete Record", Description = "Async standard Delete record API", OperationId = "Delete Record", Tags = new[] { "TemplateListApi" })]
public async Task<string> DeleteTemplateList(string id) {

```
---
