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
/****** Object:  Table [dbo].[UnitList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NOT NULL,
	[Description] [text] NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
	[Default] [bit] NOT NULL,
 CONSTRAINT [PK_UnitList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UnitList] ON 

INSERT [dbo].[UnitList] ([Id], [Name], [Description], [UserId], [Active], [TimeStamp], [Default]) VALUES (3, N'Ks', N'Kusy', 1, 1, CAST(N'2022-12-06T11:12:32.0000000' AS DateTime2), 1)
INSERT [dbo].[UnitList] ([Id], [Name], [Description], [UserId], [Active], [TimeStamp], [Default]) VALUES (5, N'Hod', N'Hodiny', 1, 1, CAST(N'2022-12-16T15:26:58.7223650' AS DateTime2), 0)
INSERT [dbo].[UnitList] ([Id], [Name], [Description], [UserId], [Active], [TimeStamp], [Default]) VALUES (6, N'Lic', N'Licence', 1, 1, CAST(N'2022-12-16T15:53:29.2985315' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[UnitList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UnitList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[UnitList] ADD  CONSTRAINT [IX_UnitList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UnitList] ADD  CONSTRAINT [DF_UnitList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[UnitList] ADD  CONSTRAINT [DF_UnitList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[UnitList] ADD  CONSTRAINT [DF_UnitList_Default]  DEFAULT ((0)) FOR [Default]
GO
ALTER TABLE [dbo].[UnitList]  WITH CHECK ADD  CONSTRAINT [FK_UnitList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[UnitList] CHECK CONSTRAINT [FK_UnitList_UserList]
GO
/****** Object:  Trigger [dbo].[TR_UnitList]    Script Date: 03.05.2023 11:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   TRIGGER [dbo].[TR_UnitList] ON [dbo].[UnitList]
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
			UPDATE [dbo].UnitList SET [Default] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setDefault = ins.[Default] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setDefault = 1) BEGIN
				UPDATE [dbo].UnitList SET [Default] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setDefault = ins.[Default] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setDefault = 1) BEGIN
		UPDATE [dbo].UnitList SET [Default] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].UnitList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[UnitList] ENABLE TRIGGER [TR_UnitList]
GO
