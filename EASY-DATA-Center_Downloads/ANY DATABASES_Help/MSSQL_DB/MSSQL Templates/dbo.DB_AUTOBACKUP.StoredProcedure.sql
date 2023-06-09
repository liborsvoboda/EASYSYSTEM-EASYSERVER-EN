/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2019 (15.0.2101)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2019
    Target Database Engine Edition : Microsoft SQL Server Express Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [EASYDATACenter]
GO
/****** Object:  StoredProcedure [dbo].[DB_AUTOBACKUP]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[DB_AUTOBACKUP]
AS
BEGIN 
	DECLARE @dbName as varchar(50) = DB_NAME();
	DECLARE @fileName as varchar(80) = CONCAT('C:\Database\',@dbName,'_',FORMAT(GETDATE(),'yyyyMMdd'),'.bak');

	DBCC SHRINKFILE (2, 1); BACKUP DATABASE @dbName TO DISK = @fileName;
	DBCC SHRINKFILE (2, 1); BACKUP DATABASE @dbName TO DISK = @fileName;
END;
GO
