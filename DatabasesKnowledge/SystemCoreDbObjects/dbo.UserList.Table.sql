USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[UserList]    Script Date: 12.03.2023 15:43:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[UserName] [varchar](150) NOT NULL,
	[Password] [varchar](2048) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[SurName] [varchar](150) NOT NULL,
	[Description] [text] NULL,
	[Active] [bit] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
	[Token] [varchar](2048) NULL,
	[Expiration] [datetime2](7) NULL,
	[Photo] [varbinary](max) NULL,
	[MimeType] [varchar](100) NULL,
	[PhotoPath] [varchar](500) NULL,
	[SystemAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_username] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserList] ADD  CONSTRAINT [DF_UserList_active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[UserList] ADD  CONSTRAINT [DF_userList_timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[UserList] ADD  CONSTRAINT [DF_UserList_SystemAdmin]  DEFAULT ((0)) FOR [SystemAdmin]
GO
ALTER TABLE [dbo].[UserList]  WITH CHECK ADD  CONSTRAINT [FK_UserList_UserList] FOREIGN KEY([Id])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[UserList] CHECK CONSTRAINT [FK_UserList_UserList]
GO
ALTER TABLE [dbo].[UserList]  WITH CHECK ADD  CONSTRAINT [FK_UserList_UserRoleList] FOREIGN KEY([RoleId])
REFERENCES [dbo].[UserRoleList] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserList] CHECK CONSTRAINT [FK_UserList_UserRoleList]
GO
