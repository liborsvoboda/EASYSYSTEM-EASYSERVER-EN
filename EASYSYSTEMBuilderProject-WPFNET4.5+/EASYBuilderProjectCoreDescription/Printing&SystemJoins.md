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
  
  
