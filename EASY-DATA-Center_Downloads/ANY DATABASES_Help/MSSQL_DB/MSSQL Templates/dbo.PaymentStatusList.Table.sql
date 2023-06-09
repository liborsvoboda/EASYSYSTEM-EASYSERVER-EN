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
/****** Object:  Table [dbo].[PaymentStatusList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentStatusList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Default] [bit] NOT NULL,
	[Description] [text] NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[Receipt] [bit] NOT NULL,
	[CreditNote] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PaymentStatusList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PaymentStatusList] ON 

INSERT [dbo].[PaymentStatusList] ([Id], [Name], [Default], [Description], [UserId], [Active], [Receipt], [CreditNote], [TimeStamp]) VALUES (1, N'Vyfakturováno', 1, N'', 1, 1, 0, 0, CAST(N'2023-03-22T10:38:14.9190390' AS DateTime2))
INSERT [dbo].[PaymentStatusList] ([Id], [Name], [Default], [Description], [UserId], [Active], [Receipt], [CreditNote], [TimeStamp]) VALUES (2, N'Čeká na úhradu', 0, N'', 1, 1, 0, 0, CAST(N'2022-12-16T02:54:23.6921105' AS DateTime2))
INSERT [dbo].[PaymentStatusList] ([Id], [Name], [Default], [Description], [UserId], [Active], [Receipt], [CreditNote], [TimeStamp]) VALUES (3, N'Uhrazeno', 0, N'', 1, 1, 1, 0, CAST(N'2023-03-22T10:37:58.9518643' AS DateTime2))
INSERT [dbo].[PaymentStatusList] ([Id], [Name], [Default], [Description], [UserId], [Active], [Receipt], [CreditNote], [TimeStamp]) VALUES (4, N'Dobropisováno', 0, N'', 1, 1, 0, 1, CAST(N'2022-12-17T13:04:22.6584837' AS DateTime2))
SET IDENTITY_INSERT [dbo].[PaymentStatusList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PaymentStatusList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[PaymentStatusList] ADD  CONSTRAINT [IX_PaymentStatusList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PaymentStatusList] ADD  CONSTRAINT [DF_PaymentStatusList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[PaymentStatusList] ADD  CONSTRAINT [DF_PaymentStatusList_Receipt]  DEFAULT ((0)) FOR [Receipt]
GO
ALTER TABLE [dbo].[PaymentStatusList] ADD  CONSTRAINT [DF_PaymentStatusList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[PaymentStatusList]  WITH CHECK ADD  CONSTRAINT [FK_PaymentStatusList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[PaymentStatusList] CHECK CONSTRAINT [FK_PaymentStatusList_UserList]
GO
/****** Object:  Trigger [dbo].[TR_PaymentStatusList]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[TR_PaymentStatusList] ON [dbo].[PaymentStatusList]
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
			UPDATE [dbo].PaymentStatusList SET [Default] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setDefault = ins.[Default] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setDefault = 1) BEGIN
				UPDATE [dbo].PaymentStatusList SET [Default] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setDefault = ins.[Default] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setDefault = 1) BEGIN
		UPDATE [dbo].PaymentStatusList SET [Default] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].PaymentStatusList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[PaymentStatusList] ENABLE TRIGGER [TR_PaymentStatusList]
GO
/****** Object:  Trigger [dbo].[TR_PaymentStatusListCreditNote]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[TR_PaymentStatusListCreditNote] ON [dbo].[PaymentStatusList]
FOR INSERT, UPDATE, DELETE
AS
DECLARE @Operation VARCHAR(15)
 
IF EXISTS (SELECT 0 FROM inserted)
BEGIN
	DECLARE @setCreditNote bit;DECLARE @RecId int;
	SET NOCOUNT ON;

    IF EXISTS (SELECT 0 FROM deleted)
    BEGIN --UPDADE
		SELECT @setCreditNote = ins.[CreditNote] from inserted ins;
		SELECT @RecId = ins.Id from inserted ins;

		IF(@setCreditNote = 1) BEGIN
			UPDATE [dbo].PaymentStatusList SET [CreditNote] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setCreditNote = ins.[CreditNote] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setCreditNote = 1) BEGIN
				UPDATE [dbo].PaymentStatusList SET [CreditNote] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setCreditNote = ins.[CreditNote] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setCreditNote = 1) BEGIN
		UPDATE [dbo].PaymentStatusList SET [CreditNote] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].PaymentStatusList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[PaymentStatusList] ENABLE TRIGGER [TR_PaymentStatusListCreditNote]
GO
/****** Object:  Trigger [dbo].[TR_PaymentStatusListReceipt]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   TRIGGER [dbo].[TR_PaymentStatusListReceipt] ON [dbo].[PaymentStatusList]
FOR INSERT, UPDATE, DELETE
AS
DECLARE @Operation VARCHAR(15)
 
IF EXISTS (SELECT 0 FROM inserted)
BEGIN
	DECLARE @setReceipt bit;DECLARE @RecId int;
	SET NOCOUNT ON;

    IF EXISTS (SELECT 0 FROM deleted)
    BEGIN --UPDADE
		SELECT @setReceipt = ins.[Receipt] from inserted ins;
		SELECT @RecId = ins.Id from inserted ins;

		IF(@setReceipt = 1) BEGIN
			UPDATE [dbo].PaymentStatusList SET [Receipt] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setReceipt = ins.[Receipt] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setReceipt = 1) BEGIN
				UPDATE [dbo].PaymentStatusList SET [Receipt] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setReceipt = ins.[Receipt] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setReceipt = 1) BEGIN
		UPDATE [dbo].PaymentStatusList SET [Receipt] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].PaymentStatusList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[PaymentStatusList] ENABLE TRIGGER [TR_PaymentStatusListReceipt]
GO
