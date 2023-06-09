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
/****** Object:  StoredProcedure [dbo].[CheckUnlockKey]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[CheckUnlockKey](@unlockCode varchar(50),@partNumber varchar(50),@ipAddress varchar(50),@allowed bit output)
AS
BEGIN 
	SET NOCOUNT ON;
	-- ALGORITHM EXAMPLE
	-- SELECT CONCAT(CAST((YEAR(GETDATE()) * MONTH(GETDATE()) * DAY(GETDATE())) as varchar(100)),'-SOMETEXT-',CAST(YEAR(GETDATE()) as varchar(4)));


			DECLARE @countValidUnlockKeys INT = 0;DECLARE @counter INT = 0;SET @allowed = 0;

			--LOAD VALIDS AUTO SQL UNLOCKCODES FOR partNumber
			DECLARE @SQLUNLOCK TABLE (Iid int identity(1,1),[Id] int not null, [Name] Varchar(30) not null, [Algorithm] varchar(MAX) not null,[AddressId] int not null,[ItemId] int not null,[LimitActive] bit not null, [ActivationLimit] int null,[UsedCount] int not null)
				INSERT into @SQLUNLOCK SELECT l.Id,l.[Name],l.[Algorithm],l.[AddressId],l.[ItemId],l.[LimitActive],l.[ActivationLimit],l.[UsedCount] FROM [dbo].[LicenseAlgorithmList] l,[dbo].[ItemList] i WHERE l.[Active] = 1 AND l.ItemId = i.Id
				AND i.[PartNumber] = @partNumber AND i.[Active] = 1 AND ([ValidFrom] IS NULL OR [ValidFrom] < GETDATE()) AND ([ValidTo] IS NULL OR [ValidTo] > GETDATE()) 

				SELECT @countValidUnlockKeys = COUNT([Iid]) FROM @SQLUNLOCK;
				DECLARE @Id int;DECLARE @Name varchar(30);DECLARE @Algorithm nvarchar(MAX);DECLARE @AddressId int;DECLARE @ItemId int;DECLARE @LimitActive int;DECLARE @ActivationLimit int;DECLARE @UsedCount int;
				DECLARE @UNLOCKKEY as varchar(MAX);

			-- CHECKING ALL VALID UNLOCKKEY GENERATORS 
			WHILE @counter < @countValidUnlockKeys BEGIN
				SELECT @Id=[Id],@Name=[Name],@Algorithm=[Algorithm],@AddressId=[AddressId],@ItemId=[ItemId],@Name=[Name],@LimitActive=[LimitActive],@ActivationLimit=[ActivationLimit],@UsedCount=[UsedCount] FROM @SQLUNLOCK WHERE Iid=@counter+1;
				SET @Algorithm= REPLACE(@Algorithm, 'char(39)', '');
				declare @t table(result varchar(max)); insert into @t exec (@Algorithm);SELECT @UNLOCKKEY = result FROM @t;
				IF (@UNLOCKKEY = @unlockCode) BEGIN
					
					IF (@LimitActive = 1 AND @UsedCount + 1 = @ActivationLimit) BEGIN --LAST ACTIVATION
						UPDATE [dbo].[LicenseAlgorithmList] SET [UsedCount] = [UsedCount] + 1, Active = 0 WHERE [Id] = @Id;SET @allowed = 1;
					END ELSE IF (@LimitActive = 1 AND @UsedCount + 1 >= @ActivationLimit) BEGIN --WRONG USER DATA
						UPDATE [dbo].[LicenseAlgorithmList] SET [Active] = 0  WHERE [Id] = @Id;SET @allowed = 0;
					END ELSE IF (@LimitActive = 1 AND @UsedCount + 1 < @ActivationLimit) BEGIN --USED LICENSE
						UPDATE [dbo].[LicenseAlgorithmList] SET [UsedCount] = [UsedCount] + 1 WHERE [Id] = @Id;SET @allowed = 1;
					END ELSE IF (@LimitActive = 0) BEGIN --USED LICENSE
						UPDATE [dbo].[LicenseAlgorithmList] SET [UsedCount] = [UsedCount] + 1 WHERE [Id] = @Id;SET @allowed = 1;
					END

					GOTO CHECKDONE;

				END
			   SET @counter += 1;
			END;

CHECKDONE:
		-- GENERATE LICENCE OR WRITE FAILED TRYING
		IF (@allowed = 0) BEGIN
			INSERT INTO [dbo].[LicenseActivationFailList] ([IpAddress],[UnlockCode],[PartNumber])
			VALUES (@ipAddress,@unlockCode,@partNumber);
		END ELSE IF (@allowed = 1) BEGIN
			INSERT INTO [dbo].[UsedLicenseList] ([IpAddress],[UnlockCode],[AlgorithmName],[PartNumber],[License],[ActivateDate],[AddressId],[ItemId])
			VALUES (@ipAddress,@unlockCode,@Name,@partNumber,NEWID(),GETDATE(),@AddressId,@ItemId);
	END

	RETURN;
END;
GO
