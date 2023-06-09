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
/****** Object:  Table [dbo].[CurrencyList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](5) NOT NULL,
	[ExchangeRate] [numeric](10, 2) NOT NULL,
	[Fixed] [bit] NOT NULL,
	[Description] [text] NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[Default] [bit] NOT NULL,
 CONSTRAINT [PK_CurrencyList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CurrencyList] ON 

INSERT [dbo].[CurrencyList] ([Id], [Name], [ExchangeRate], [Fixed], [Description], [UserId], [Active], [TimeStamp], [Default]) VALUES (1, N'CZK', CAST(1.00 AS Numeric(10, 2)), 1, N'Česká koruna', 1, 1, CAST(N'2022-12-16T17:35:42.3309790' AS DateTime2), 1)
INSERT [dbo].[CurrencyList] ([Id], [Name], [ExchangeRate], [Fixed], [Description], [UserId], [Active], [TimeStamp], [Default]) VALUES (2, N'EUR', CAST(25.00 AS Numeric(10, 2)), 0, N'Euro', 1, 1, CAST(N'2022-12-16T15:03:06.1871158' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[CurrencyList] OFF
ALTER TABLE [dbo].[CurrencyList] ADD  CONSTRAINT [DF_CurrencyList_ExchangeRate]  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[CurrencyList] ADD  CONSTRAINT [DF_CurrencyList_Fixed]  DEFAULT ((1)) FOR [Fixed]
GO
ALTER TABLE [dbo].[CurrencyList] ADD  CONSTRAINT [DF_CurrencyList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[CurrencyList] ADD  CONSTRAINT [DF_CurrencyList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[CurrencyList] ADD  CONSTRAINT [DF_CurrencyList_Default]  DEFAULT ((0)) FOR [Default]
GO
ALTER TABLE [dbo].[CurrencyList]  WITH CHECK ADD  CONSTRAINT [FK_CurrencyList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[CurrencyList] CHECK CONSTRAINT [FK_CurrencyList_UserList]
GO
/****** Object:  Trigger [dbo].[TR_CurrencyList]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[TR_CurrencyList] ON [dbo].[CurrencyList]
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
			UPDATE [dbo].CurrencyList SET [Default] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setDefault = ins.[Default] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setDefault = 1) BEGIN
				UPDATE [dbo].CurrencyList SET [Default] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setDefault = ins.[Default] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setDefault = 1) BEGIN
		UPDATE [dbo].CurrencyList SET [Default] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].CurrencyList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[CurrencyList] ENABLE TRIGGER [TR_CurrencyList]
GO
