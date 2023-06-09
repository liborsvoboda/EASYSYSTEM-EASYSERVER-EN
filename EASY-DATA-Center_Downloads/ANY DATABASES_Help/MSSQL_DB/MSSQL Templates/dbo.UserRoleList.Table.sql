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
/****** Object:  Table [dbo].[UserRoleList]    Script Date: 03.05.2023 11:24:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoleList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SystemName] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[UserId] [int] NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserRoleList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserRoleList] ON 

INSERT [dbo].[UserRoleList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (1, N'user', N'User role', NULL, CAST(N'2022-12-16T17:52:31.2048991' AS DateTime2))
INSERT [dbo].[UserRoleList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (2, N'admin', N'Administrators', NULL, CAST(N'2022-10-22T06:42:13.1365196' AS DateTime2))
INSERT [dbo].[UserRoleList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (3, N'manager', N'Manager role', NULL, CAST(N'2022-12-16T17:52:07.2618718' AS DateTime2))
SET IDENTITY_INSERT [dbo].[UserRoleList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoleList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[UserRoleList] ADD  CONSTRAINT [IX_UserRoleList] UNIQUE NONCLUSTERED 
(
	[SystemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserRoleList] ADD  CONSTRAINT [DF_UserRoleList_timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
