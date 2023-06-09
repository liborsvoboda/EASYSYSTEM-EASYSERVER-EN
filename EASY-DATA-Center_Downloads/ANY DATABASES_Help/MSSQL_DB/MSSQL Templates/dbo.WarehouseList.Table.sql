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
/****** Object:  Table [dbo].[WarehouseList]    Script Date: 03.05.2023 11:24:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WarehouseList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[UserId] [int] NOT NULL,
	[AllowNegativeStatus] [bit] NOT NULL,
	[Default] [bit] NOT NULL,
	[LockedByStockTaking] [bit] NOT NULL,
	[LastStockTaking] [datetime2](7) NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_WarehouseList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[WarehouseList] ON 

INSERT [dbo].[WarehouseList] ([Id], [Name], [Description], [UserId], [AllowNegativeStatus], [Default], [LockedByStockTaking], [LastStockTaking], [Active], [TimeStamp]) VALUES (1, N'Hlavní sklad', N'Main warehouse', 1, 0, 1, 0, CAST(N'2022-12-18T10:15:15.0000000' AS DateTime2), 1, CAST(N'2022-12-18T08:36:26.1702859' AS DateTime2))
INSERT [dbo].[WarehouseList] ([Id], [Name], [Description], [UserId], [AllowNegativeStatus], [Default], [LockedByStockTaking], [LastStockTaking], [Active], [TimeStamp]) VALUES (2, N'Reklamační sklad', N'', 1, 0, 0, 0, CAST(N'2022-12-18T00:00:00.0000000' AS DateTime2), 1, CAST(N'2022-12-18T08:36:22.1639261' AS DateTime2))
SET IDENTITY_INSERT [dbo].[WarehouseList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_WarehouseList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[WarehouseList] ADD  CONSTRAINT [IX_WarehouseList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WarehouseList] ADD  CONSTRAINT [DF_WarehouseList_IsLocked]  DEFAULT ((0)) FOR [LockedByStockTaking]
GO
ALTER TABLE [dbo].[WarehouseList] ADD  CONSTRAINT [DF_WarehouseList_LastStockTaking]  DEFAULT (getdate()) FOR [LastStockTaking]
GO
ALTER TABLE [dbo].[WarehouseList] ADD  CONSTRAINT [DF_WarehouseList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[WarehouseList] ADD  CONSTRAINT [DF_WarehouseList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[WarehouseList]  WITH CHECK ADD  CONSTRAINT [FK_WarehouseList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[WarehouseList] CHECK CONSTRAINT [FK_WarehouseList_UserList]
GO
/****** Object:  Trigger [dbo].[TR_WarehouseList]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[TR_WarehouseList] ON [dbo].[WarehouseList]
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
			UPDATE [dbo].WarehouseList SET [Default] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setDefault = ins.[Default] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setDefault = 1) BEGIN
				UPDATE [dbo].WarehouseList SET [Default] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setDefault = ins.[Default] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setDefault = 1) BEGIN
		UPDATE [dbo].WarehouseList SET [Default] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].WarehouseList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[WarehouseList] ENABLE TRIGGER [TR_WarehouseList]
GO
