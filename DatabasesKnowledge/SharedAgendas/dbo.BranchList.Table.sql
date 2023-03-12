USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[BranchList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BranchList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](150) NOT NULL,
	[ContactName] [varchar](150) NULL,
	[Street] [varchar](150) NOT NULL,
	[City] [varchar](150) NOT NULL,
	[PostCode] [varchar](20) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Email] [varchar](150) NULL,
	[BankAccount] [varchar](150) NULL,
	[Ico] [varchar](20) NULL,
	[Dic] [varchar](20) NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_BranchList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_BranchList] UNIQUE NONCLUSTERED 
(
	[CompanyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BranchList] ADD  CONSTRAINT [DF_BranchList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[BranchList] ADD  CONSTRAINT [DF_BranchList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[BranchList]  WITH CHECK ADD  CONSTRAINT [FK_BranchList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[BranchList] CHECK CONSTRAINT [FK_BranchList_UserList]
GO
/****** Object:  Trigger [dbo].[TR_BranchList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   TRIGGER [dbo].[TR_BranchList] ON [dbo].[BranchList]
FOR INSERT, UPDATE, DELETE
AS
DECLARE @Operation VARCHAR(15)
 
IF EXISTS (SELECT 0 FROM inserted)
BEGIN
	DECLARE @setActive bit;DECLARE @RecId int;
	SET NOCOUNT ON;

    IF EXISTS (SELECT 0 FROM deleted)
    BEGIN --UPDADE
		SELECT @setActive = ins.[Active] from inserted ins;
		SELECT @RecId = ins.Id from inserted ins;

		IF(@setActive = 1) BEGIN
			UPDATE [dbo].BranchList SET [Active] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setActive = ins.[Active] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setActive = 1) BEGIN
				UPDATE [dbo].BranchList SET [Active] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setActive = ins.[Active] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setActive = 1) BEGIN
		UPDATE [dbo].BranchList SET [Active] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].BranchList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[BranchList] ENABLE TRIGGER [TR_BranchList]
GO
