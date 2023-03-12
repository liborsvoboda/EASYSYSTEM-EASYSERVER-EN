USE [EASYBUILDER]
GO

/****** Object:  Table [dbo].[TemplateList]    Script Date: 11.03.2023 6:13:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TemplateList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[Default] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TemplateList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_TemplateList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[TemplateList] ADD  CONSTRAINT [DF_TemplateList_Active]  DEFAULT ((1)) FOR [Active]
GO

ALTER TABLE [dbo].[TemplateList] ADD  CONSTRAINT [DF_TemplateList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO

ALTER TABLE [dbo].[TemplateList]  WITH CHECK ADD  CONSTRAINT [FK_TemplateList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO

ALTER TABLE [dbo].[TemplateList] CHECK CONSTRAINT [FK_TemplateList_UserList]
GO


