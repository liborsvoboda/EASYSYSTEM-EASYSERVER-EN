USE [EASYDATACenter]
GO
/****** Object:  StoredProcedure [dbo].[DBHELP]    Script Date: 02.05.2023 12:04:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




ALTER procedure [dbo].[DBHELP](@itemId int, @count int, @userId int)
AS
BEGIN 
	SET NOCOUNT ON;
	BEGIN TRAN
		BEGIN TRY

		--REPAIR Id blocked by FOREIGN Key
		--DELETE FROM [GLOBAL].[dbo].[AddressList]
		--DBCC CHECKIDENT ([AddressList], RESEED, 0)

		--INSERT first ID
		--INSERT INTO AddressList(AddressType, CompanyName, ContactName, Street, City, PostCode, Phone, Email, BankAccount, Ico, Dic, UserId, Active)
		--VALUES ('all', 'KlikneteZde.Cz', 'Libor Svoboda', 'Žlutava 173', 'Žlutava', '763 61', '00420 724986873', '', '', '', '', 1, 1)
		--INSERT INTO AddressList(AddressType, CompanyName, ContactName, Street, City, PostCode, Phone, Email, BankAccount, Ico, Dic, UserId, Active)
		--VALUES        ('all', 'GroupWare-Solution.Eu', 'Libor Svoboda', 'Žlutava 173', 'Žlutava', '763 61', '00420 724986873', '', '', '', '', 1, 1)
		
		-- COPY TABLE with DATA WITHOUT KEYS AND INDEXES
		--SELECT * INTO [GLOBAL].[dbo].[ItemList] FROM [SHOPINGER].[dbo].[ItemList]

		--CLONE TABLE
		--DBCC CLONEDATABASE (source_database_name, target_database_name)[WITH [NO_STATISTICS][,NO_QUERYSTORE]] 

		----BACKUP
		--USE[SHOPINGER]
		--DROP USER [shopinger];
		--DBCC SHRINKFILE (SHOPINGER_log, 1);
		--BACKUP DATABASE [SHOPINGER] TO DISK = N'C:\Database\SHOPINGER.bak'
		--DBCC SHRINKFILE (SHOPINGER_log, 1);
		--BACKUP DATABASE [SHOPINGER] TO DISK = N'C:\Database\SHOPINGER.bak'
		--GO

		--USE [SHOPINGER]
		--BEGIN TRY CREATE USER [shopinger] FOR LOGIN [shopinger] END TRY BEGIN CATCH END CATCH;
		--BEGIN TRY ALTER ROLE [db_datareader] ADD MEMBER [shopinger]; END TRY BEGIN CATCH END CATCH;


		----RESTORE TO NEW FILES
		--ALTER DATABASE [SHOPINGER] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
		--RESTORE DATABASE [SHOPINGER] FROM DISK = N'C:\Database\SHOPINGER.bak' 
		--WITH MOVE N'SHOPINGER' TO N'C:\Database\SHOPINGER.mdf',  
		--     MOVE N'SHOPINGER_log' TO N'C:\Database\SHOPINGER_log.ldf', FILE = 2,
		--RECOVERY,  REPLACE,  STATS = 10;
		--ALTER DATABASE [SHOPINGER] SET MULTI_USER;

		--COPY DATA FROM TABLE TO TABLE
		--INSERT INTO newTable
		--SELECT * FROM oldTable

		-- Shadow Copy original table to create new with data NEW: ProdGuidGroupList   , original :GroupList
		--SELECT * INTO [EASYDATACenter].[dbo].[ProdGuidGroupList1] FROM [VYKONY].dbo.GroupList

		COMMIT TRANSACTION
        END TRY
        BEGIN CATCH
              ROLLBACK TRANSACTION
        END CATCH
END;
