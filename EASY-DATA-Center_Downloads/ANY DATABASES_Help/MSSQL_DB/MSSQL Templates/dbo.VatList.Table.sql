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
/****** Object:  Table [dbo].[VatList]    Script Date: 03.05.2023 11:24:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Value] [numeric](10, 2) NOT NULL,
	[Default] [bit] NOT NULL,
	[Description] [text] NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_VatList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VatList] ON 

INSERT [dbo].[VatList] ([Id], [Name], [Value], [Default], [Description], [UserId], [Active], [TimeStamp]) VALUES (3, N'DPH 21%', CAST(0.21 AS Numeric(10, 2)), 1, N'', 1, 1, CAST(N'2022-12-15T23:29:48.1509783' AS DateTime2))
INSERT [dbo].[VatList] ([Id], [Name], [Value], [Default], [Description], [UserId], [Active], [TimeStamp]) VALUES (4, N'DPH 15%', CAST(0.15 AS Numeric(10, 2)), 0, N'', 1, 1, CAST(N'2022-12-08T16:41:59.7360609' AS DateTime2))
INSERT [dbo].[VatList] ([Id], [Name], [Value], [Default], [Description], [UserId], [Active], [TimeStamp]) VALUES (6, N'DPH 0%', CAST(0.00 AS Numeric(10, 2)), 0, N'Cena bez DPH pro neplátce DPH', 1, 1, CAST(N'2022-12-08T10:06:14.9827343' AS DateTime2))
SET IDENTITY_INSERT [dbo].[VatList] OFF
/****** Object:  Index [IX_VatList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[VatList] ADD  CONSTRAINT [IX_VatList] UNIQUE NONCLUSTERED 
(
	[Value] ASC,
	[Active] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[VatList] ADD  CONSTRAINT [DF_VatList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[VatList] ADD  CONSTRAINT [DF_VatList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[VatList]  WITH CHECK ADD  CONSTRAINT [FK_VatList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[VatList] CHECK CONSTRAINT [FK_VatList_UserList]
GO
/****** Object:  Trigger [dbo].[TR_VatList]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[TR_VatList] ON [dbo].[VatList]
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
			UPDATE [dbo].VatList SET [Default] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setDefault = ins.[Default] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setDefault = 1) BEGIN
				UPDATE [dbo].VatList SET [Default] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setDefault = ins.[Default] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setDefault = 1) BEGIN
		UPDATE [dbo].VatList SET [Default] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].VatList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[VatList] ENABLE TRIGGER [TR_VatList]
GO
