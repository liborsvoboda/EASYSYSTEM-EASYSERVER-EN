USE [GLOBALNET]
GO
/****** Object:  StoredProcedure [dbo].[DB_BACKUP]    Script Date: 12.03.2023 15:43:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[DB_BACKUP]
AS
BEGIN 
	DROP USER [globalnet];
	DBCC SHRINKFILE (GLOBALNET_log, 1); BACKUP DATABASE [GLOBALNET] TO DISK = N'C:\Database\GLOBALNET.bak'
	DBCC SHRINKFILE (GLOBALNET_log, 1); BACKUP DATABASE [GLOBALNET] TO DISK = N'C:\Database\GLOBALNET.bak'
END;
GO
