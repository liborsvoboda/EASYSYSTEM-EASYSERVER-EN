USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[PaymentMethodList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethodList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Default] [bit] NOT NULL,
	[Description] [text] NULL,
	[AutoGenerateReceipt] [bit] NOT NULL,
	[AllowGenerateReceipt] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PaymentMethodList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_PaymentMethodList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[PaymentMethodList] ADD  CONSTRAINT [DF_PaymentMethodList_AutoGenerateReceipt]  DEFAULT ((0)) FOR [AutoGenerateReceipt]
GO
ALTER TABLE [dbo].[PaymentMethodList] ADD  CONSTRAINT [DF_PaymentMethodList_AllowGenerateReceipt]  DEFAULT ((0)) FOR [AllowGenerateReceipt]
GO
ALTER TABLE [dbo].[PaymentMethodList] ADD  CONSTRAINT [DF_PaymentMethodList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[PaymentMethodList] ADD  CONSTRAINT [DF_PaymentMethodList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[PaymentMethodList]  WITH CHECK ADD  CONSTRAINT [FK_PaymentMethodList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[PaymentMethodList] CHECK CONSTRAINT [FK_PaymentMethodList_UserList]
GO
/****** Object:  Trigger [dbo].[TR_PaymentMethodList]    Script Date: 12.03.2023 15:37:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[TR_PaymentMethodList] ON [dbo].[PaymentMethodList]
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
			UPDATE [dbo].PaymentMethodList SET [Default] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setDefault = ins.[Default] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setDefault = 1) BEGIN
				UPDATE [dbo].PaymentMethodList SET [Default] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setDefault = ins.[Default] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setDefault = 1) BEGIN
		UPDATE [dbo].PaymentMethodList SET [Default] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].PaymentMethodList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[PaymentMethodList] ENABLE TRIGGER [TR_PaymentMethodList]
GO
