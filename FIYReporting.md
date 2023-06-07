### FYI Reporting  - FreeWare Full Report Designer and Viewer
for Printing All document Types with Images, Barcodes, EAN, QR, Graphs, SubReport, etc.

## IMPORTANT INFO FOR REPORT DEVELOP
* Reports are for developping setted Default Parameters.  
* If the report is called from the system - All parameters are replaced by system sended params
* Each Report can has more Datasets  (subreports not need for Header/Items Views)
* More Examples are Defined
* Full Developing of new reports are supported
* Included commandline Tool, Report Viewer, Report Designer

### JOINING WITH EASYSYSTEMBuilder - Calling Reports
    Directly - System sending these parameters directly to opening Report
        connectionString [Connect] - For Report connection to Database
        table name [TableName] - primary tablename from datalist
        record ID [Id] - Selected record Id
        Simple Search Parameter [Search] - For simple search in Datalist Fields
        
    Over DB  - System save all filter informations to table 'ReportQueueList' and 
               to all record with has selected Datalist Table. 
               After Saving to DB is Called open Report. Its for Reports with using DB  
               procedure 'ReportDataset' for Full DB defined Data Selections
               Direct parameters not need for this using

### EASYSYSTEMBuilder SYSTEM Conditions for Reports 
* Connection String is Defined in setting for All reports in Application (Client) 
* All APIUrls with 'List' word on end are automaticaly added for insert Report for this Table             
* All System reports are Saved in Database - table 'ReportList'  
* For Print is downloaded and open with direct params everyTime

* 'ReportQueueList' Definitions is second method for Print report,  
which the definition is full in DB (can be defined multi Datasets)
* Report can combine both method for Load Datasets (Over stored procedure or direct selection with params)
* Print Report Action you can set for Record Selection Only
* Unlimited Print Reports you Define for Primary Table - DataList
* System has these joins: Datalist, Rec ID, simple Search, Advanced Search
* Each join [param] can be separated for run alone or combined with others
* Full SQL and SQLexec are supported

### Print example from CMD with parameters

"RdlReader.exe" "C:\WorkListPrint.rdl" -p "&Search=%%&Id=0"

Report has dataset and you can insert field over right mouse/ insert / object /

Expressions
PageBreak ={PersonalNumber} - new page by  each personalNumber

functions in C# not MSSQL

using ="Filter:" + Replace({?Search}, "%", "")  - Search is param, replace %%

for run report mut be set Default values for parameters
=Fields!OperationNumber.Value + " " + {Note}
=Sum({Amount})
---

### Print SQL Examples
```sql
SET FMTONLY OFF;

SELECT
w.[Id],FORMAT([Date],'MM.yyyy') as Month,
FORMAT([Date],'dd.MM.yyyy') as Date,
CONCAT(FORMAT([Date],'MMyy'),w.[PersonalNumber]) as ListBreak,
w.[PersonalNumber],o.[PartNumber],w.[WorkPlace],w.[OperationNumber],
[WorkTime],[Pcs],[Amount],[WorkPower] ,[Name],[SurName],o.[Note]
FROM [WorkList] w,[PersonList] p,[OperationList] o 
WHERE w.PersonalNumber = p.PersonalNumber AND w.WorkPlace = o.WorkPlace 

AND o.OperationNumber = w.OperationNumber AND
(@Id = 0 AND ((LEN(@Search) > 2 AND w.Id LIKE @Search) OR LEN(@Search) = 2))
OR w.Id = @Id 

ORDER BY w.[Date] ASC, w.PersonalNumber, w.[OperationNumber]
```

```sql
--Select with simple search and Id selection
SELECT Id, UserName, TerminalName, Description, Timestamp 
FROM LoginHistoryList 
WHERE 1=1 AND (
( @Search <> '%%' AND id LIKE @Search )
OR ( @Search = '%%' AND @Id = 0  )
OR ( @Search = '%%' AND @Id <> 0 AND Id = @Id )
)
```

```sql
--Selection with direct params
SELECT Id, UserName, TerminalName, Description, Timestamp 
FROM LoginHistoryList 
WHERE 1=1 AND (
( @Search <> '%%' AND id LIKE @Search )
OR ( @Search = '%%' AND @Id = 0  )
OR ( @Search = '%%' AND @Id <> 0 AND Id = @Id )
)
```

```sql
--Select with advanced Filter

SET FMTONLY OFF;
DECLARE @whereClause NVARCHAR(MAX) = @Filter ;
DECLARE @sql NVARCHAR(MAX) = 'SELECT Id, UserName, TerminalName, Description, Timestamp FROM LoginHistoryList  WHERE @whereClause';

SELECT @sql = REPLACE(@sql, '@whereClause', @whereClause);

EXEC sp_executesql @sql;
```


```sql
--Selection with ReportQueueList definitions
SET FMTONLY OFF;
EXEC ReportDataset @TableName='tableName', @Sequence='SeqNr' 
```

```sql
--Selection with Formating and Dials Fields
SET FMTONLY OFF;

SELECT
w.[Id],FORMAT([Date],'MM.yyyy') as Month,
FORMAT([Date],'dd.MM.yyyy') as Date,
CONCAT(FORMAT([Date],'MMyy'),w.[PersonalNumber]) as ListBreak,
w.[PersonalNumber],o.[PartNumber],w.[WorkPlace],w.[OperationNumber],
[WorkTime],[Pcs],[Amount],[WorkPower] ,[Name],[SurName],o.[Note]
FROM [WorkList] w,[PersonList] p,[OperationList] o 
WHERE w.PersonalNumber = p.PersonalNumber AND w.WorkPlace = o.WorkPlace 

AND o.OperationNumber = w.OperationNumber AND
(@Id = 0 AND ((LEN(@Search) > 2 AND w.Id LIKE @Search) OR LEN(@Search) = 2))
OR w.Id = @Id 

ORDER BY w.[Date] ASC, w.PersonalNumber, w.[OperationNumber]
```
----

## SYSTEM PRINTING

- On Print Request 
  1) Updated all filters in table 'ReportQueueList' on records for selected table
  2) download from DB and open report with sended these params for Direct SQL support
  Params  
	- Search = Searched Value
	- Id = Record Id from table
	- Filter= Setted Filter command in sql syntax after WHERE clause
	- TableName - selected table Name
	- Connect - connection string from client settings
   3) Run report. Done

- Report Types:
	- Alone Report file with ful own SQL command and use params for selection. Examples You can see in edited reports, Instalation folder and Help
	- Sql defined in ReportQueueList Table, in report is only command: SET FMTONLY OFF;EXEC ReportDataset @TableName='tablename', @Sequence='10'

- Parameters are sending Every Time, For Debuging you can use MSSQL SQL Profiller
- In database is Saved Stored Procedure: ReportDataset for folded filter, ReportQueueList table is managing

- All report are shared for selected database
- Each print is report again downloaded from database for new run
- Each report can be exported in Reports menu
- All reports are saved in instalation folder as Examples
- All reports has same parameters

  Dynamic Filtering:
- For managed SQL command can be 'Search' and 'Id' params ignored = Each Filter working independently
    Setted Priority:
	    1] Combined Filter
		2] Id
		3] Searched Value (searched columns are rardcoded in 'Filter' method on each Datalist) in Report must be hardcoded again

- in stored Procedure: 'ReportDataset'
    if Both Searfh and Id Ignored - Filter is aply alone
	else all cobndition are joined with 'OR' clause for Each Filter setting: 'Id' and 'Search'

	Its Prepared for future MultiRows Selection

- More Info Via Help File FYI Reporting Documentations on Github

- In one Report you can setted more DATALists = DB SELECTS (Invoice Example - Header/Item)
  and you can set any field over Report Parameter for using in all Report Positions
  
---


### MarkDown Item Template  
```cs

```

---