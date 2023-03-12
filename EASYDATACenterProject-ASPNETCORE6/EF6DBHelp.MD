### Literature:

[https://code-maze.com/net-core-web-development-part1/](https://code-maze.com/net-core-web-development-part1/ "")  
[https://docs.microsoft.com/cs-cz/aspnet/core/security/cors?view=aspnetcore-6.0](https://docs.microsoft.com/cs-cz/aspnet/core/security/cors?view=aspnetcore-6.0 "")
[https://docs.microsoft.com/cs-cz/ef/core/cli/dotnet](https://docs.microsoft.com/cs-cz/ef/core/cli/dotnet "")
[https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28](https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28 "")
[https://stackoverflow.com/questions/48282223/scaffold-dbcontext-to-different-output-folder](https://stackoverflow.com/questions/48282223/scaffold-dbcontext-to-different-output-folder "")  

[https://codewithmukesh.com/blog/repository-pattern-caching-hangfire-aspnet-core/](https://codewithmukesh.com/blog/repository-pattern-caching-hangfire-aspnet-core/ "")  

---

**Administration tools included in Backend server**  
* ApiDescription Generator - on url: /swagger   
* Data manager for connected DB - on url: /CoreAdmin  
* Server Health Service - on url: /ServerHealthService  
* WEB root  - with Websocket test utility

---
###JSON configuration  (folder Data/config.json):

> "DbConnectionString":      -  MSSQL DB connection string. Its only in config file.   
"JwtLocalKey": 	        - Your JWT Local Key you can set random key.   
"DefaultApiPort":	        - Default Port for HTTP/HTTPS/SOCKET.  
"SocketTimeoutMinutes":  - Default WebSocket Timeout.  
"SocketBufferSizeKb":      - Default WebSocket message size.   
"TimeTokenValidation":    - Enable/Disable token Expiration.  
"LoginTimeoutMinutes":    - Minutes count to token expiration.  
"HttpsProtocol":	        - Enable/Disable HTTP/ HTTPS on this port. Only one is always in use.  
"CertificateDomain":         - Certificate for HTTPS is generated automaticaly i fis HTTPS is enabled.  
                               This domain is included in the certificate.  
"CertificatePassword":       - Password for generated certificate.Its required.  
"InternalCachingEnabled":  - enable Microsoft internal cache for working with Data  
"LoggingCacheTimeMinutes": - Time for Purging old chache data   
"EnableApiDescription": true, - Enable full automatic API documentation generator with request sending for test included  
"EnableDataManager": true,    - Enable unsafed Data manager  
"EnableServerHealthService":  - Enable Server Health Service with chedking if services   running


---


**Used technologies:**

-	AspNetCore 6
-	Entity Framewok 6
-	Log4Net
-	MSSQL connection
-	HTTP/HTTPS/WebSocket/RestFull / [GET,POST,PATCH,PUT,DELETE,OPTION]
-	Windows Service / Docker Service / Console application
-	CookiePolicy
-	CorsPolicy
-	Authentification / Authorization / Basic – JwtBearer
-	Automatic EndPoints /Controllers

---
##Database Model snapshot to Entity Entity Framework 6:

The first green descriptions commands is for simple direct working with MSSQL database. 
This command generating „full DB Model Entity“ and „full DB API documentation“. 
Command must be run from „package manager console“.

1)
Command for: generate full Entity – Database Model Entity Framework
Scaffold-DbContext "Server=SQLSRV\SQLEXPRESS;Database=DATAPUB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir DBModel -ContextDir "DBContexts"

Scaffold-DbContext "Server=SQLSRV;Database=DATAPUB;Persist Security Info=False;User ID=datapub;Password=datapub;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir DBModel -ContextDir "DBContexts"
Scaffold-DbContext "Server=192.168.1.35;Database=DATAPUB;User ID=datapub;Password=datapub;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir DBModel


Command for: generate full DB Context – Database API documentation
Scaffold-DbContext "Server=SQLSRV\SQLEXPRESS;Database=DATAPUB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir "DbContexts"

2)
Replace Connection string in DBContect folder/Context filewith this program part. 
(here you can enable SQL debuging)

```cs
public DATAPUBContext(DbContextOptions<DATAPUBContext> options)
    : base(options)
{ 
    ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
}

if (!optionsBuilder.IsConfigured)
{

    optionsBuilder.ConfigureLoggingCacheTime(TimeSpan.FromMinutes(Program.ServerSettings.SimpleCacheTimeMinutes));
    optionsBuilder.EnableServiceProviderCaching(Program.ServerSettings.SimpleCachingEnabled);

    optionsBuilder.UseSqlServer(Program.ServerSettings.DbConnectionString,
            x => x.MigrationsHistoryTable("MigrationsHistory", "dbo"));
    //.UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }))
    //.LogTo(message => Debug.WriteLine(message));
    //.LogTo(Console.WriteLine);
}
```

---

3) Dissable ForeignKey control you must set JSONIgnore & ValidateNever params for key in DBModel. Example is in UserList:

```cs
[JsonIgnore]
[ValidateNever]
public virtual UserRoleList Role { get; set; } = null!;
```


---
4)

Initite Migrations files to DOTNET migration management for Upload/Manage Database Migrations:   
Add-Migration Initial -Context Company.WebApplication1.Data.ApplicationDbContext

Upload migrations to DATABASE  
dotnet ef database update 

Export Database model to SQL script  
dotnet ef dbcontext script --output Migrations/BasicDBModel.sql

These nexts commands are for working with database migrations:  
Command for: generate script with full database model  
dotnet ef dbcontext script --output Migrations/BasicDBModel.sql

Command for: generate new migration script  
dotnet ef migrations add ServerSetting.sql

Command for: generate script for database update  
dotnet ef migrations bundle --output Migrations/BasicDBModel.sql

Command for: show all migration List  
dotnet ef migrations list

Command for: remove Last migration  
dotnet ef migrations remove

Command for: run all waiting migrations scripts   
dotnet ef database update

---

Generate executable Files 

[https://learn.microsoft.com/cs-cz/dotnet/core/tools/dotnet-publish](https://learn.microsoft.com/cs-cz/dotnet/core/tools/dotnet-publish "")

**Run debug**   
dotnet run --project BACKENDCORE -r win-x64 -c Debug --self-contained

Generate exe file Without WebPage support
dotnet publish BACKENDCORE -c Release -o bin -r win-x64 /p:PublishSingleFile=true

