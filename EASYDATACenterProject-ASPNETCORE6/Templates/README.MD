## BACKEND server Templates and system rules COPY/PASTE/RENAME supported
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>


> The displayed template codes can also be found in the Database  
> Make the database model as honest as possible in relation to data and bindings  
> The best solution is to have the database check the correctness of the data (in 1 place)  
> The database contains a DBHELP help procedure  
> Document items are deleted with a linked key  
> Procedures for Backup/Restore are prepared in the DB  
> The system uses SLQ, EF6, Procedures, Views, Functions 
> That's all it takes to develop  


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