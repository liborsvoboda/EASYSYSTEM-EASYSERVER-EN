--!!!!   AFTER UPLOAD DATABASE PLEASE START EASYBuilder Service or Icon from Desktop   !!!!
--!!!!                                                                                      !!!!
--!!!!                                                                                      !!!!
--!!!!               SET CORRECT CONNECTION STRING WITH NAME/PASSWORD: shopinger            !!!!
--!!!!                    IN  C:\ProgramData\EASYBuilder\config.json                   !!!!
--!!!!              (config example: Server=SQLSRV; or Server=192.168.1.35,1433;)           !!!!
--!!!!                                          AND                                         !!!!
--!!!!                 START THE EASYBuilder Service or Icon from Desktop              !!!!
--!!!!                                                                                      !!!!
--!!!!                                                                                      !!!!
--!!!!   AFTER UPLOAD DATABASE PLEASE START EASYBuilder Service or Icon from Desktop   !!!!

USE [master]
GO

--1] SET MANUALLY RIGHT CLICK/FACETS/SERVER SECURITY/XPCmdShellEnabled/TRUE
--2] SELECT AND EXECUTE SQL CODE
--3] MODIFY CONNECTION STRING IN CONFIG.JSON in folder c:\ProgramData\EASYBuilder\config.json
--E] config example: Server=SQLSRV; or Server=192.168.1.35,1433;
--4] START THE EASYBuilder Service or Icon from Desktop


-- CREATE C:\Database Folder
BEGIN TRY EXEC xp_cmdshell 'MD C:\Database'; END TRY
BEGIN CATCH SELECT ERROR_NUMBER() AS ErrorNumber ,ERROR_MESSAGE() AS ErrorMessage; END CATCH;
GO



-- UPLOAD DATABASE LICENSESRV
RESTORE DATABASE [LICENSESRV] FROM DISK = N'C:\Program Files (x86)\GroupWare-Solution.eu\EASYBuilder\MSSQL_DB\LICENSESRV.bak' 
WITH MOVE N'LICENSESRV' TO N'C:\Database\LICENSESRV.mdf',  
     MOVE N'LICENSESRV_log' TO N'C:\Database\LICENSESRV_log.ldf', FILE = 2, RECOVERY,  REPLACE,  STATS = 10;
ALTER DATABASE [LicenseSrv] SET MULTI_USER;
GO



-- CREATE USER 'LICENSESRV'
BEGIN TRY
	CREATE LOGIN [licensesrv] WITH PASSWORD=N'licensesrv', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;
END TRY 
BEGIN CATCH SELECT ERROR_NUMBER() AS ErrorNumber ,ERROR_MESSAGE() AS ErrorMessage; END CATCH;
GO

USE [LICENSESRV]
BEGIN TRY CREATE USER [licensesrv] FOR LOGIN [licensesrv] END TRY BEGIN CATCH END CATCH;
BEGIN TRY ALTER ROLE [db_datareader] ADD MEMBER [licensesrv]; END TRY BEGIN CATCH END CATCH;
BEGIN TRY ALTER ROLE [db_datawriter] ADD MEMBER [licensesrv]; END TRY BEGIN CATCH END CATCH;
BEGIN TRY GRANT EXECUTE TO [licensesrv]; END TRY BEGIN CATCH END CATCH;





