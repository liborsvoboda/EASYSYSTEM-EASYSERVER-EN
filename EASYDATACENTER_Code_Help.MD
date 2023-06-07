### Literature:

[https://code-maze.com/net-core-web-development-part1/](https://code-maze.com/net-core-web-development-part1/ "")  
[https://docs.microsoft.com/cs-cz/aspnet/core/security/cors?view=aspnetcore-6.0](https://docs.microsoft.com/cs-cz/aspnet/core/security/cors?view=aspnetcore-6.0 "")
[https://docs.microsoft.com/cs-cz/ef/core/cli/dotnet](https://docs.microsoft.com/cs-cz/ef/core/cli/dotnet "")
[https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28](https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28 "")
[https://stackoverflow.com/questions/48282223/scaffold-dbcontext-to-different-output-folder](https://stackoverflow.com/questions/48282223/scaffold-dbcontext-to-different-output-folder "")  

[https://codewithmukesh.com/blog/repository-pattern-caching-hangfire-aspnet-core/](https://codewithmukesh.com/blog/repository-pattern-caching-hangfire-aspnet-core/ "")  

[Swagger Documentation](https://github.com/domaindrivendev/Swashbuckle.AspNetCore#swashbuckleaspnetcoreswaggergen "")
---

### Administration tools included in Backend server    
* ApiDescription Generator - on url: /swagger   
* Data manager for connected DB - on url: /CoreAdmin  
* Server Health Service - on url: /ServerHealthService  
* WEB root  - with Websocket test utility

---
### JSON configuration Older Example  (folder Data/config.json):

> "DatabaseConnectionString":      -  MSSQL DB connection string. Its only in config file.   
"ConfigJwtLocalKey": 	        - Your JWT Local Key you can set random key.   
"DefaultConfigServerStartupPort":	        - Default Port for HTTP/HTTPS/SOCKET.  
"ConfigWebSocketTimeoutMin":  - Default WebSocket Timeout.  
"SocketBufferSizeKb":      - Default WebSocket message size.   
"ServerTimeTokenValidationEnabled":    - Enable/Disable token Expiration.  
"ConfigApiTokenTimeoutMin":    - Minutes count to token expiration.  
"HttpsProtocol":	        - Enable/Disable HTTP/ HTTPS on this port. Only one is always in use.  
"ConfigCertificateDomain":         - Certificate for HTTPS is generated automaticaly i fis HTTPS is enabled.  
                               This domain is included in the certificate.  
"ConfigCertificatePassword":       - Password for generated certificate.Its required.  
"DatabaseInternalCachingEnabled":  - enable Microsoft internal cache for working with Data  
"DatabaseInternalCacheTimeoutMin": - Time for Purging old chache data   
"EnableApiDescription": true, - Enable full automatic API documentation generator with request sending for test included  
"ModuleDataManagerEnabled": true,    - Enable unsafed Data manager  
"ModuleHealthServiceEnabled":  - Enable Server Health Service with chedking if services   running


---
### EASYDATACenter Universal BACKEND Server Solution foe ANY LIN/WIN/DB 
*     Universal Secure MultiPlatform MultiDATABASE BackEnd Server Project 
*     WiTH RESTFULL / WEBSOCKET implementations
*     With All Template types for INSERT / UPDATE / DELETE / SELECT / 
*     PROCEDURES / VIEWS/ SUBFORMDATA and more Other
*     With DATABASE , Table Template, Procedure Template, View Template, 
*     Backup/Restore and more Examples
*     With Tables, Indexes, ForeignKeys in All Standard DB Using 
*     FOR SIMPLE COPY / PASTE DEVELOPMENT IN EXTREMELY LOW PRICE 5000Kč/200EURO

---

### USED TECHNOLOGIES (SUPPORT by CORE) IN SOLUTION CORE
* DB types: SQL Server, Oracle, MySQL, SQLite, PostgreSQL, DB2, etc.
* LINUX, WINDOWS, GCLOUD, DOCKER, AZURE implementation
* HTTP/HTTPS/WebSocket/RestFull / GET,POST,PATCH,PUT,DELETE,OPTION,etc.
* Detailed Logging, EASY Debugging ON ALL Dev layers
* CookiePolicy , CorsPolicy / Authentication / Authorization / Basic–JwtBearer Tokens
* Automatic API EndPoints /Controllers
* IMPORT FULL DB Schema/Tables/Procedures/Views from DB by ONE Scaffold Command 
* DB Migrations AND Management of any layer supported
* Implemented SWAGGER AUTO API Generator: API Tester and Documentation
* Implemented DIRECT DATA MANAGER for view/editing data in Database
* Implemented Server HEALTH Check with support All statuses,communications,etc. for Server Control
* Custom WebPage for BackEnd Controlling supported
* LOW/NO code developing supported by DB/TABLE/API/CLASS Templates
* FULL code development supported
* More others tools and AddOns are on GitHub for implement by Package Install

--- 

### Databases - EASY Way with AUTO Management  

- ASPNETCORE6 and Entity Framework 6 are perfect managing solution for any DATABASE   
- Simple using is Domain for these Technologies, which is simple for each Power User
- Automatic Code Correction, Auto Helper, Generation DB Schema for Visual Control will not allow to make a mistake  
- lot of Free Tools on GitHub, can be simple included with High effect

---

### These Tools are Included to Solution Core  
- Complex Tool DB Data management  
- Automatic API Tester and Documentation Generator
- System Checker with controlling and logging more than 100 Server/Network/DB/IS/OS events

---

### Used Primary Technologies for Unlimited Vision - Older

-	AspNetCore 6
-	Entity Framework 6
-	Log4Net
-	MSSQL connection
-	HTTP/HTTPS/WebSocket/RestFull / [GET,POST,PATCH,PUT,DELETE,OPTION]
-	Windows Service / Docker Service / Console application
-	CookiePolicy
-	CorsPolicy
-	Authentication / Authorization / Basic – JwtBearer
-	Automatic EndPoints /Controllers

---

### Database Model snapshot to Entity Entity Framework 6:

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
Replace Connection string in DBContect folder/Context file with this program part. 
(here you can enable SQL debugging)

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

    optionsBuilder.UseSqlServer(Program.ServerSettings.DatabaseConnectionString,
            x => x.MigrationsHistoryTable("MigrationsHistory", "dbo"));
    //.UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }))
    //.LogTo(message => Debug.WriteLine(message));
    //.LogTo(Console.WriteLine);
}
```

---

3) Disable ForeignKey control you must set JSONIgnore & ValidateNever params for key in DBModel. Example is in UserList:

```cs
[JsonIgnore]
[ValidateNever]
public virtual UserRoleList Role { get; set; } = null!;
```


---
4)

Init Migrations files to DOTNET migration management for Upload/Manage Database Migrations:   
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

### Generate executable Files 

[https://learn.microsoft.com/cs-cz/dotnet/core/tools/dotnet-publish](https://learn.microsoft.com/cs-cz/dotnet/core/tools/dotnet-publish "")

---

### Run debug     
dotnet run --project BACKENDCORE -r win-x64 -c Debug --self-contained

Generate exe file Without WebPage support
dotnet publish BACKENDCORE -c Release -o bin -r win-x64 /p:PublishSingleFile=true

--- 

### DB backup procedure in Linux    
```sql
CREATE procedure [dbo].[DB_AUTOBACKUP]
AS
BEGIN 
	DECLARE @dbName as varchar(50) = DB_NAME();
	DECLARE @fileName as varchar(80) = CONCAT('/root/DBbackup/',@dbName,'_',FORMAT(GETDATE(),'yyyyMMdd'),'.bak');

	DBCC SHRINKFILE (2, 1); BACKUP DATABASE @dbName TO DISK = @fileName;
	DBCC SHRINKFILE (2, 1); BACKUP DATABASE @dbName TO DISK = @fileName;
END;
GO
```
---

### One Project support More DBs = DBContexts   
these can be used whatever, MOre Api for More App for example

The test version, if requested, should ideally
be deployed separately for making changes

---

### Solution for Data selection by Role - its needed in SELECT API only

```cs
if (Request.HttpContext.User.IsInRole("Admin"))
{ data = new EASYDATACenterContext().ImageGalleryLists.FromSqlRaw("SELECT * FROM ImageGalleryList WHERE 1=1 AND " + filter.Replace("+", " ")).AsNoTracking().ToList(); }
else
{
    data = new EASYDATACenterContext().ImageGalleryLists.FromSqlRaw("SELECT * FROM ImageGalleryList WHERE 1=1 AND " + filter.Replace("+", " "))
        .Include(a => a.User).Where(a => a.User.UserName == Request.HttpContext.User.Claims.First().Issuer)
        .AsNoTracking().ToList();
}
```
---

### ASPNETCORE6 & ENTITY FRAMEWORK6 - SUPER SERVER
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

* ASPNETCORE is a simple intuitive framework with a whisperer for easy development.  
* The Current Solution already contains templates and samples and can be developed with their help  
* robust system.   
* More information can be found with the linked folders.  
* The project is conceptually complex for complete laymen who learn a few steps over and over again.  
* DB Views behave the same as tables  
* Turn off foreign keys in the model To be able to work freely with the tables  

---

### Server configuration
The server loads the configuration from a file at startup and after connecting to the database
replaces it with the settings from the database and starts the server according to the parameters

```json
"DatabaseConnectionString":   -  MSSQL DB connection string. Its only in config file.
"ConfigJwtLocalKey": 	        - Your JWT Local Key you can set random key. 
"DefaultConfigServerStartupPort":	    - Default Port for HTTP/HTTPS/SOCKET. 
"ConfigWebSocketTimeoutMin": - Default WebSocket Timeout. 
"SocketBufferSizeKb":   - Default WebSocket message size.
"ServerTimeTokenValidationEnabled":  - Enable/Disable token Expiration.
"ConfigApiTokenTimeoutMin":  - Minutes count to token expiration.
"HttpsProtocol": - Enable/Disable HTTP/ HTTPS on this port. Only one is always in use. 
"ConfigCertificateDomain":    - Certificate for HTTPS is generated automaticaly i fis HTTPS is enabled.
                         This domain is included in the certificate. 
"ConfigCertificatePassword":     - Password for generated certificate.Its required.
"DatabaseInternalCachingEnabled":  - enable Microsoft internal cache for working with Data
"DatabaseInternalCacheTimeoutMin": - Time for Purging old chache data
"EnableApiDescription": true, - Enable full automatic API documentation generator with request sending for test included
"ModuleDataManagerEnabled": true,    - Enable unsafed Data manager
"ModuleHealthServiceEnabled":  - Enable Server Health Service with chedking if services running
```


* /BackendCheckApi - Api for checking Server Availability
* /Authentication - Basic authentication Standard message for receiving the Token

---

### Unique Services of sever

* /BackendCheckApi - Api for checking Server Availability  
* /Authentication - Basic authentication Standard message for receiving the Token  

* Web Services  
* /swagger - Automatic generator API model documentation and testing  
* /CoreAdmin - Data Manager for the connected database  
* /ServerHealthService - Service for setting health checks; server HW/SW  

---

### API Communication on the BACKEND server side

```en
//Disable foreign keys in the model by adding JsonIgnore, ValidateNever : Sample

[JsonIgnore]
[ValidateNever]
public virtual UserList User { get; set; } = null!;
```    

    
---

### API Template  

* The template is ready for complete communication with the table Just RENAME  
* Authorization, INSERT/UPDATE/SELECT/DELETE  

[Standard Table API Template](https://github.com/liborsvoboda/EASYSYSTEM-EASYSERVER-EN/blob/main/EASYDATACenterProject-ASPNETCORE6/Templates/TemplateListApi.cs "")



```cs
//Inserting/Deleting Range Items into the Sub Table - for example Invoice Items  

var test = new EASYBUILDERContext(); test.OfferItemLists.AddRange(record);
result = test.SaveChanges();

var test = new EASYBUILDERContext(); test.OfferItemLists.RemoveRange(data);
int result = test.SaveChanges();                

```

---

### EF6 DB procedure query with response

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

---

### EF6 Query Check Token.Role/Issuer - UserName, Include sub table Foreign Table

```cs
if (Request.HttpContext.User.IsInRole("Admin")) {
    data = new hotelsContext().AddressLists.ToList();
} else {
    data = new hotelsContext().AddressLists.Include(a => a.User)
        .Where(a => a.User.UserName == Request.HttpContext.User.Claims.First().Issuer).ToList();
}
```   
---

### Ignore more Sub Tables from include in API response  

```css
return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles,WriteIndented = true });
```

---

### Advanced Query Select for Admin user Request suppport  

```cs
if (Request.HttpContext.User.IsInRole("Admin"))
{ data = new hotelsContext().AddressLists.FromSqlRaw("SELECT * FROM AddressList WHERE 1=1 AND " + filter.Replace("+", " ")).AsNoTracking().ToList(); }
else {
    data = new hotelsContext().AddressLists.FromSqlRaw("SELECT * FROM AddressList WHERE 1=1 AND " + filter.Replace("+", " "))
        .Include(a => a.User).Where(a => a.User.UserName == Request.HttpContext.User.Claims.First().Issuer)
        .AsNoTracking().ToList();
}
```

---

### Extend Table schema with columns from another table  

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

### Join Table with new custom join condition with exist record

**And next more condition in WHERE to List<string> **  
(_joiner, _joined) => _joiner.City
```css
        [HttpGet("/GLOBALNETWebApi/Search/GetSearchDial/{language}")]
        public async Task<string> GetSearchDial(string language = "cz") {

            List<string> data;
            List<string> cityData;
            List<string> countryData;

            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {

                countryData = _dbContext.CountryLists.
                    Join(_dbContext.HotelLists.Where(a => a.Advertised && a.Approved == true), 
                    joiner => joiner.Id, joined => joined.CountryId, (_joiner, _joined) => _joiner.SystemName).ToList();
                
                cityData = _dbContext.CityLists.Join(_dbContext.HotelLists.Where(a => a.Advertised && a.Approved == true),
                    joiner => joiner.Id, joined => joined.CountryId, (_joiner, _joined) => _joiner.City).ToList();

                data = _dbContext.HotelLists.Where(a=> a.Approved == true && a.Advertised == true).Select(a => a.Name).ToList();
            }
            countryData.ForEach(item => data.Add(DBOperations.DBTranslate(item, language)));
            cityData.ForEach(item => data.Add(DBOperations.DBTranslate(item, language)));
            data = data.Distinct().ToList();
            data.Sort();
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true });
        }
```

---

### Join Table with new custom join condition with exist record to Tuple List  

```css
countryData = _dbContext.CountryLists.
                    Join(_dbContext.HotelLists.Where(a => a.Advertised && a.Approved == true),
                    joiner => joiner.Id, joined => joined.CountryId, (_joiner, _joined) => new Tuple<int, string>(_joined.Id, _joined.Name)).ToList();
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
        optionsBuilder.ConfigureLoggingCacheTime(TimeSpan.FromMinutes(Program.ServerSettings.DatabaseInternalCacheTimeoutMin));
        optionsBuilder.EnableServiceProviderCaching(Program.ServerSettings.DatabaseInternalCachingEnabled);  
        optionsBuilder.UseMySql(Program.ServerSettings.DatabaseConnectionString,
            ServerVersion.AutoDetect(Program.ServerSettings.DatabaseConnectionString))
            ;
            //.UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }))
            //.LogTo(message => Debug.WriteLine(message))
            //.LogTo(Console.WriteLine)
            ;
        }
    }
```

---

### API Condition for Role Admin only  

```cs

[Authorize(Roles = Role.Admin)]
[Authorize(Roles = "admin")]
[CustomAuthorize(Roles = "admin")]

if (Request.HttpContext.User.IsInRole("Admin"))

```
---

### API Condition Ignore For Swagger Docs

```cs

//[ApiExplorerSettings(IgnoreApi = true)]

```
---


### BACKEND server Templates and system rules COPY/PASTE/RENAME supported
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>


* The displayed template codes can also be found in the Database  
* Make the database model as honest as possible in relation to data and bindings  
* The best solution is to have the database check the correctness of the data (in 1 place)  
* The database contains a DBHELP help procedure  
* Document items are deleted with a linked key  
* Procedures for Backup/Restore are prepared in the DB  
* The system uses SLQ, EF6, Procedures, Views, Functions 
* That's all it takes to develop  


```sql
-- The procedure setting the rights for the user to the necessary operations

USE [EASYBUILDER]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DB_SETRIGHTS]
AS
BEGIN 
	BEGIN TRY CREATE USER [easybuilder] FOR LOGIN [easybuilder] END TRY BEGIN CATCH END CATCH;
	BEGIN TRY ALTER ROLE [db_datareader] ADD MEMBER [easybuilder]; END TRY BEGIN CATCH END CATCH;
	BEGIN TRY ALTER ROLE [db_datawriter] ADD MEMBER [easybuilder]; END TRY BEGIN CATCH END CATCH;
	BEGIN TRY GRANT EXECUTE TO [easybuilder]; END TRY BEGIN CATCH END CATCH;
END;
GO
```

```sql
/*
Template for creating standardized Tables (from Table -> CREATE TO)
The template is used by way of REPLACE 'TemplateList' after 'NewTableList'
edit fields correctly, set indexes and foreign keys
System ID Columns - AutoIncrement, TimeStamp - InsertTime
Keys: UserId - Binding to the UsersList Table
*/
```
```sql
USE [EASYBUILDER]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TemplateList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[Default] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TemplateList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_TemplateList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[TemplateList] ADD  CONSTRAINT [DF_TemplateList_Active]  DEFAULT ((1)) FOR [Active]
GO

ALTER TABLE [dbo].[TemplateList] ADD  CONSTRAINT [DF_TemplateList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO

ALTER TABLE [dbo].[TemplateList]  WITH CHECK ADD  CONSTRAINT [FK_TemplateList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO

ALTER TABLE [dbo].[TemplateList] CHECK CONSTRAINT [FK_TemplateList_UserList]
GO
```


```sql
/*
System procedure for Reports with advanced filtering The procedure is part of the Supplied Database
*/
```

```sql
USE [EASYBUILDER]
GO

/****** Object:  StoredProcedure [dbo].[ReportDataset]    Script Date: 11.03.2023 6:45:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ReportDataset]
@TableName varchar(50) = null,
@Sequence int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

-- Intended for use with param-ed reports.
-- To be called from various My-FyiReporting reports
--   - Various reports with their own layouts are called from VB app after setting Queue with usp_ReportQueue_Push()
--     each report then just contains : 

-- SET FMTONLY OFF;
-- EXEC usp_ReportQueue_Pop @TableName='SomeTablename', @Sequence='10'
-- 

DECLARE @ID int;
DECLARE @NAME varchar(50);
DECLARE @SQL nvarchar(MAX);
DECLARE @FILTER nvarchar(MAX);
DECLARE @SEARCH varchar(50);
DECLARE @SEARCHCOLUMNLIST nvarchar(MAX);
DECLARE @SEARCHFILTERIGNORE bit;
DECLARE @RECID varchar(50);
DECLARE @RECIDFILTERIGNORE bit;

DECLARE @SEPARATEDCOLUMNS nvarchar(MAX);


SELECT Top 1 
  @ID=[Id], 
  @NAME=[Name], 
  @SQL=[Sql], 
  @FILTER=[Filter], 
  @SEARCH=[Search], 
  @SEARCHCOLUMNLIST=[SearchColumnList],
  @SEARCHFILTERIGNORE=[SearchFilterIgnore],
  @RECID=[RecId],
  @RECIDFILTERIGNORE=[RecIdFilterIgnore]
FROM ReportQueueList WHERE [TableName]=@TableName AND [Sequence] = @Sequence; 

--PRERARE RECID
IF (@RECID = 0 OR (@RECIDFILTERIGNORE = 1 AND @FILTER <> '1=1')) BEGIN 
	SET @RECID = ''
END ELSE BEGIN
	SET @RECID = CONCAT(' AND Id=',@RECID);
END

--PRERARE SEARCH
IF (@SEARCH = '' OR (@SEARCHFILTERIGNORE = 1 AND @FILTER <> '1=1')) BEGIN
	SET @SEPARATEDCOLUMNS =  '1=1';
END ELSE BEGIN
	SELECT @SEPARATEDCOLUMNS = STRING_AGG (CONCAT(value,' LIKE ',char(39),'%',@SEARCH,'%',char(39)), ' OR ') FROM STRING_SPLIT (@SEARCHCOLUMNLIST, ',');  
END

	SET @SQL = CONCAT(@SQL,' WHERE 1=1 AND (', @FILTER,') AND (', @SEPARATEDCOLUMNS,') ',@RECID); 
	--PRINT @SQL; --FOR Debuging
	EXECUTE sp_executesql @SQL;
END
GO
```


```sql
--SQL Trigger for Table to set a single value for type 'Default'
```

```sql
USE [EASYBUILDER]
GO

/****** Object:  Trigger [dbo].[TR_UnitList]    Script Date: 11.03.2023 6:48:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE   TRIGGER [dbo].[TR_UnitList] ON [dbo].[UnitList]
FOR INSERT, UPDATE, DELETE
AS
DECLARE @Operation VARCHAR(15)
 
IF EXISTS (SELECT 0 FROM inserted)
BEGIN
	DECLARE @setDefault bit;DECLARE @RecId int;
	SET NOCOUNT ON;

    IF EXISTS (SELECT 0 FROM deleted)
    BEGIN --UPDADE
		SELECT @setDefault = ins.[Default] from inserted ins;
		SELECT @RecId = ins.Id from inserted ins;

		IF(@setDefault = 1) BEGIN
			UPDATE [dbo].UnitList SET [Default] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setDefault = ins.[Default] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setDefault = 1) BEGIN
				UPDATE [dbo].UnitList SET [Default] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setDefault = ins.[Default] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setDefault = 1) BEGIN
		UPDATE [dbo].UnitList SET [Default] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].UnitList WHERE Id <> @RecId)
		;
	END
END
GO

ALTER TABLE [dbo].[UnitList] ENABLE TRIGGER [TR_UnitList]
GO   
```
---

### API communication - 4 TYPES is enough  

<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

It is so. INSERT/UPDATE/DETETE/SELECT are the mentioned types which are enough
ensure the communication of any system.
And top it all off with a single list of APIaddress calls and communication is resolved
set up for this as a standardized automatic part of the kernel.

System kernel code dump, Where you just always add the address and don't care about anything else

---

### System APIAddresList - all calls in one place  

```cs
    /// <summary>
    /// ALL standard View AND Form API Call must end with "List" - These will automatic added for reports Definitions
    /// </summary>
    public enum ApiUrls
    {
        GlobalNETAttachmentList,
        GlobalNETAddressList,
        Authentication,
        BackendCheck,
        GlobalNETBranchList,
        GlobalNETCalendar,
        GlobalNETCreditNoteList,
        GlobalNETCreditNoteItemList,
        GlobalNETCurrencyList,
        GlobalNETDocumentAdviceList,
        GlobalNETExchangeRateList,
        GlobalNETIncomingInvoiceList,
        GlobalNETIncomingInvoiceItemList,
        GlobalNETIncomingOrderList,
        GlobalNETIncomingOrderItemList,

        GlobalNETTemplateClassList
    }
```

---

### 4 API Calls - SYSTEM Core module  

```cs
    class ApiCommunication
    {
        public static async Task<Authentification> Authentification(ApiUrls apiUrl, string userName = null, string password = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(userName + ":" + password)));
                    StringContent test = new StringContent("", Encoding.UTF8, "application/json");
                    HttpResponseMessage json = await httpClient.PostAsync(App.Setting.ApiAddress + "/" + apiUrl, test);
                    return JsonConvert.DeserializeObject<Authentification>(await json.Content.ReadAsStringAsync());
                }
                catch { return new Authentification() { Token = null, Expiration = null }; }
            }
        }

        public static async Task<T> GetApiRequest<T>(ApiUrls apiUrl, string key = null, string token = null) where T : new()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    string json = await httpClient.GetStringAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""));
                    return JsonConvert.DeserializeObject<T>(json);
                } catch { return new T(); }
            }
        }

        public static async Task<DBResultMessage> PostApiRequest(ApiUrls apiUrl, HttpContent body, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.PostAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""), body);
                    DBResultMessage result = JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                    if (result.ErrorMessage == null) { result.ErrorMessage = await json.Content.ReadAsStringAsync(); }
                    return result;
                }
                catch (Exception ex)
                { return new DBResultMessage() { RecordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, Status = "error" }; }
            }
        }

        public static async Task<DBResultMessage> PutApiRequest(ApiUrls apiUrl, HttpContent body, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.PutAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""), body);
                    DBResultMessage result = JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                    if (result.ErrorMessage == null) { result.ErrorMessage = await json.Content.ReadAsStringAsync(); }
                    return result;
                }
                catch (Exception ex)
                { return new DBResultMessage() { RecordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, Status = "error" }; }
            }
        }

        public static async Task<DBResultMessage> DeleteApiRequest(ApiUrls apiUrl, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.DeleteAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""));
                    return JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                }
                catch (Exception ex)
                { return new DBResultMessage() { RecordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, Status = "error" }; }
            }
        }

        public static async Task<bool> CheckApiConnection()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string json = await httpClient.GetStringAsync(App.Setting.ApiAddress + "/" + ApiUrls.BackendCheck);
                    return true;
                }
                catch
                { return false; }
            }
        }

    }
```

----


### MarkDown Item Template  
```cs

```

---

