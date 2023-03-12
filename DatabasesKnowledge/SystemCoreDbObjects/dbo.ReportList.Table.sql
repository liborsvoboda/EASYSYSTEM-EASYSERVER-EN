USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[ReportList]    Script Date: 12.03.2023 15:43:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PageName] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[JoinedId] [bit] NOT NULL,
	[Description] [text] NULL,
	[ReportPath] [varchar](500) NULL,
	[MimeType] [varchar](100) NOT NULL,
	[File] [varbinary](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
	[Default] [bit] NOT NULL,
 CONSTRAINT [PK_ReportList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ReportList] ADD  CONSTRAINT [DF_ReportList_JoinedId]  DEFAULT ((0)) FOR [JoinedId]
GO
ALTER TABLE [dbo].[ReportList] ADD  CONSTRAINT [DF_ReportList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[ReportList] ADD  CONSTRAINT [DF_ReportList_TimeStamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[ReportList] ADD  CONSTRAINT [DF_ReportList_Default]  DEFAULT ((0)) FOR [Default]
GO
ALTER TABLE [dbo].[ReportList]  WITH CHECK ADD  CONSTRAINT [FK_ReportList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[ReportList] CHECK CONSTRAINT [FK_ReportList_UserList]
GO
/****** Object:  Trigger [dbo].[TR_ReportList]    Script Date: 12.03.2023 15:43:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[TR_ReportList] ON [dbo].[ReportList]
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
			UPDATE [dbo].ReportList SET [Default] = 0 WHERE Id <> @RecId; 		
		END
	END ELSE
		BEGIN -- INSERT
			SELECT @setDefault = ins.[Default] from inserted ins;
			SELECT @RecId = ins.Id from inserted ins;

			IF(@setDefault = 1) BEGIN
				UPDATE [dbo].ReportList SET [Default] = 0 WHERE Id <> @RecId; 		
			END
		
		END
END ELSE 
BEGIN --DELETE
	SELECT @setDefault = ins.[Default] from deleted ins;
	SELECT @RecId = ins.Id from deleted ins;

	IF(@setDefault = 1) BEGIN
		UPDATE [dbo].ReportList SET [Default] = 1  
		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].ReportList WHERE Id <> @RecId)
		;
	END
END
GO
ALTER TABLE [dbo].[ReportList] ENABLE TRIGGER [TR_ReportList]
GO
