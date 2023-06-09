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
/****** Object:  Table [dbo].[AccessRoleList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessRoleList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [varchar](50) NOT NULL,
	[AccessRole] [varchar](1024) NOT NULL,
	[UserId] [int] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AccessRuleList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AccessRoleList] ON 

INSERT [dbo].[AccessRoleList] ([Id], [TableName], [AccessRole], [UserId], [Timestamp]) VALUES (1, N'OfferList', N'manager,admin,user,', 1, CAST(N'2023-05-02T02:08:52.9604710' AS DateTime2))
INSERT [dbo].[AccessRoleList] ([Id], [TableName], [AccessRole], [UserId], [Timestamp]) VALUES (3, N'NotesList', N'manager,', 1, CAST(N'2023-05-02T02:53:42.5525195' AS DateTime2))
INSERT [dbo].[AccessRoleList] ([Id], [TableName], [AccessRole], [UserId], [Timestamp]) VALUES (4, N'OutgoingInvoiceList', N'admin,manager,', 1, CAST(N'2023-05-02T02:54:42.1518519' AS DateTime2))
INSERT [dbo].[AccessRoleList] ([Id], [TableName], [AccessRole], [UserId], [Timestamp]) VALUES (5, N'ReceiptItemList', N'manager,', 1, CAST(N'2023-05-02T02:57:32.4849794' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AccessRoleList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AccessRuleList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[AccessRoleList] ADD  CONSTRAINT [IX_AccessRuleList] UNIQUE NONCLUSTERED 
(
	[TableName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AccessRoleList] ADD  CONSTRAINT [DF_AccessRuleList_AccessRole]  DEFAULT ('Admin,') FOR [AccessRole]
GO
ALTER TABLE [dbo].[AccessRoleList] ADD  CONSTRAINT [DF_AccessRuleList_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[AccessRoleList]  WITH CHECK ADD  CONSTRAINT [FK_AccessRuleList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[AccessRoleList] CHECK CONSTRAINT [FK_AccessRuleList_UserList]
GO
