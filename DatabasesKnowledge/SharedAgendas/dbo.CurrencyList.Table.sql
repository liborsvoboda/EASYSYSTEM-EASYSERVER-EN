USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[CurrencyList]    Script Date: 12.03.2023 15:37:54 ******/
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
/****** Object:  Trigger [dbo].[TR_CurrencyList]    Script Date: 12.03.2023 15:37:55 ******/
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
