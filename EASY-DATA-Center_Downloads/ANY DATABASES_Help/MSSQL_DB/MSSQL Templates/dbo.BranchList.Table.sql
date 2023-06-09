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
/****** Object:  Table [dbo].[BranchList]    Script Date: 03.05.2023 11:24:00 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BranchList] ON 

INSERT [dbo].[BranchList] ([Id], [CompanyName], [ContactName], [Street], [City], [PostCode], [Phone], [Email], [BankAccount], [Ico], [Dic], [UserId], [Active], [TimeStamp]) VALUES (1, N'KlikneteZde.Cz', N'Libor Svoboda', N'Žlutava 173', N'Žlutava', N'76361', N'+420724986873', N'libor.svoboda@kliknetezde.cz', N'43-4378530247 / 0100', N'86973681', N'CZ8006295319', 1, 0, CAST(N'2023-04-14T00:57:37.4530432' AS DateTime2))
INSERT [dbo].[BranchList] ([Id], [CompanyName], [ContactName], [Street], [City], [PostCode], [Phone], [Email], [BankAccount], [Ico], [Dic], [UserId], [Active], [TimeStamp]) VALUES (2, N'GroupWare-Solution.Eu', N'Libor Svoboda', N'Žlutava 173', N'Žlutava', N'76361', N'+420724986873', N'libor.svoboda@kliknetezde.cz', N'43-4378530247 / 0100', N'86973681', N'CZ8006295319', 1, 1, CAST(N'2023-04-14T00:57:40.6067777' AS DateTime2))
SET IDENTITY_INSERT [dbo].[BranchList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_BranchList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[BranchList] ADD  CONSTRAINT [IX_BranchList] UNIQUE NONCLUSTERED 
(
	[CompanyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
/****** Object:  Trigger [dbo].[TR_BranchList]    Script Date: 03.05.2023 11:24:04 ******/
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
