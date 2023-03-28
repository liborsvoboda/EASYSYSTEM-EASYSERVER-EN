## ASPNETCORE6 & ENTITY FRAMEWORK6 - SUPER SERVER
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

> ASPNETCORE is a simple intuitive framework with a whisperer for easy development.  
> The Current Solution already contains templates and samples and can be developed with their help  
> robust system.   
> More information can be found with the linked folders.  
> The project is conceptually complex for complete laymen who learn a few steps over and over again.  
> DB Views behave the same as tables  
> Turn off foreign keys in the model To be able to work freely with the tables  


### Server configuration
The server loads the configuration from a file at startup and after connecting to the database
replaces it with the settings from the database and starts the server according to the parameters

```json
"DbConnectionString":   -  MSSQL DB connection string. Its only in config file.
"JwtLocalKey": 	        - Your JWT Local Key you can set random key. 
"DefaultApiPort":	    - Default Port for HTTP/HTTPS/SOCKET. 
"SocketTimeoutMinutes": - Default WebSocket Timeout. 
"SocketBufferSizeKb":   - Default WebSocket message size.
"TimeTokenValidation":  - Enable/Disable token Expiration.
"LoginTimeoutMinutes":  - Minutes count to token expiration.
"HttpsProtocol": - Enable/Disable HTTP/ HTTPS on this port. Only one is always in use. 
"CertificateDomain":    - Certificate for HTTPS is generated automaticaly i fis HTTPS is enabled.
                         This domain is included in the certificate. 
"CertificatePassword":     - Password for generated certificate.Its required.
"InternalCachingEnabled":  - enable Microsoft internal cache for working with Data
"LoggingCacheTimeMinutes": - Time for Purging old chache data
"EnableApiDescription": true, - Enable full automatic API documentation generator with request sending for test included
"EnableDataManager": true,    - Enable unsafed Data manager
"EnableServerHealthService":  - Enable Server Health Service with chedking if services running
```


> /BackendCheckApi - Api for checking Server Availability
> /Authentication - Basic authentication Standard message for receiving the Token

### Unique Services of severru

> /BackendCheckApi - Api for checking Server Availability  
> /Authentication - Basic authentication Standard message for receiving the Token  

> Web Services  
> /swagger - Automatic generator API model documentation and testing  
> /CoreAdmin - Data Manager for the connected database  
> /ServerHealthService - Service for setting health checks; server HW/SW  





### API Communication on the BACKEND server side



```en
//Disable foreign keys in the model by adding JsonIgnore, ValidateNever : Sample

[JsonIgnore]
[ValidateNever]
public virtual UserList User { get; set; } = null!;
```    

    


**API Template**  
> The template is ready for complete communication with the table Just RENAME  
> Authorization, INSERT/UPDATE/SELECT/DELETE  

[Standard Table API Template](https://github.com/liborsvoboda/EASYSYSTEM-EASYSERVER-EN/blob/main/EASYDATACenterProject-ASPNETCORE6/Templates/TemplateListApi.cs "")



```cs
//Inserting/Deleting Range Items into the Sub Table - for example Invoice Items  

var test = new EASYBUILDERContext(); test.OfferItemLists.AddRange(record);
result = test.SaveChanges();

var test = new EASYBUILDERContext(); test.OfferItemLists.RemoveRange(data);
int result = test.SaveChanges();                

```



**EF6 DB procedure query with response**  
```c
parameters = new List<SqlParameter> {
new SqlParameter { ParameterName = "@unlockCode", Value = unlockCode },
new SqlParameter { ParameterName = "@partNumber", Value = partNumber },
new SqlParameter { ParameterName = "@ipAddress", Value = clientIPAddr },
new SqlParameter { ParameterName = "@allowed" , Value = allowed, Direction = System.Data.ParameterDirection.Output} };
data = new GLOBALNETContext().Database.ExecuteSqlRaw("exec CheckUnlockKey @unlockCode, @partNumber , @ipAddress, @allowed output", parameters.ToArray()).ToString();
allowed = bool.Parse(parameters[3].Value.ToString());
```


---
### MSSQL IN ASPNETCORE HELP COMMANDS AND TYPES
```c
#Command for: Auto Generate full DB – complete Database Model Entity Framework
Scaffold-DbContext "Server=SQLSRV\SQLEXPRESS;Database=DATAPUB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir DBModel -ContextDir "DBContexts"
```  



**EF6 Query Check Token.Role/Issuer - UserName, Include sub table Foreign Table**
```cs
if (Request.HttpContext.User.IsInRole("Admin")) {
    data = new hotelsContext().AddressLists.ToList();
} else {
    data = new hotelsContext().AddressLists.Include(a => a.User)
        .Where(a => a.User.UserName == Request.HttpContext.User.Claims.First().Issuer).ToList();
}
```   
    
**Ignore more Sub Tables from include in API response**  
```css
return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles,WriteIndented = true });
```

**Advanced Query Select for Admin user Request suppport**
```cs
if (Request.HttpContext.User.IsInRole("Admin"))
{ data = new hotelsContext().AddressLists.FromSqlRaw("SELECT * FROM AddressList WHERE 1=1 AND " + filter.Replace("+", " ")).AsNoTracking().ToList(); }
else {
    data = new hotelsContext().AddressLists.FromSqlRaw("SELECT * FROM AddressList WHERE 1=1 AND " + filter.Replace("+", " "))
        .Include(a => a.User).Where(a => a.User.UserName == Request.HttpContext.User.Claims.First().Issuer)
        .AsNoTracking().ToList();
}
```

**Extend Table schema with columns from another table**
```cs
data = new hotelsContext().DocumentTypeLists
.Include(d => (d.SystemNameNavigation)).Select(x => new ExtendedDocumentTypeList
{
    Id = x.Id,
    SystemName = x.SystemName,
    Description = x.Description,
    DescriptionCz = x.SystemNameNavigation.DescriptionCz,
    DescriptionEn = x.SystemNameNavigation.DescriptionEn,
    UserId = x.UserId,
    Timestamp = x.Timestamp
}).ToList();
```

---
### MYSQL IN ASPNETCORE HELP COMMANDS AND TYPES

```bash
#Console command for download full database schema to Backend Server Project
Scaffold-DbContext "server=localhost;port=3306;database=lowercasedbname;uid=user;password=password;" Pomelo.EntityFrameworkCore.MySql -OutputDir DBModel
```

```c
#MYSQL Entity DB Context Connection Code with loaded configuration settings
#Absolute Detailed Logging supported, uncomment only
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    if (!optionsBuilder.IsConfigured) {
        optionsBuilder.ConfigureLoggingCacheTime(TimeSpan.FromMinutes(Program.ServerSettings.LoggingCacheTimeMinutes));
        optionsBuilder.EnableServiceProviderCaching(Program.ServerSettings.InternalCachingEnabled);  
        optionsBuilder.UseMySql(Program.ServerSettings.DbConnectionString,
            ServerVersion.AutoDetect(Program.ServerSettings.DbConnectionString))
            ;
            //.UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }))
            //.LogTo(message => Debug.WriteLine(message))
            //.LogTo(Console.WriteLine)
            ;
        }
    }
```