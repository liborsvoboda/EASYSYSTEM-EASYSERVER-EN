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
/****** Object:  Table [dbo].[MottoList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MottoList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SystemName] [varchar](50) NOT NULL,
	[UserId] [int] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_MottoList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MottoList] ON 

INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (1, N'Dynamic Touch System', 1, CAST(N'2022-11-19T11:18:55.5033333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (2, N'Modern Way for your Businnes', 1, CAST(N'2022-11-19T11:18:55.6266667' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (3, N'Future Touch System', 1, CAST(N'2022-11-19T11:18:55.7366667' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (4, N'Each day New Agenda', 1, CAST(N'2022-11-19T11:18:55.8466667' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (5, N'Perfectly customized System', 1, CAST(N'2022-11-19T11:18:55.9866667' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (6, N'Designed for Each User', 1, CAST(N'2022-11-19T11:18:56.0800000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (7, N'Fast Deployment', 1, CAST(N'2022-11-19T11:18:56.1733333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (8, N'Machines Are Supported', 1, CAST(N'2022-11-19T11:18:56.2833333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (9, N'Each Click is Optimized', 1, CAST(N'2022-11-19T11:18:56.3600000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (10, N'Limited by Idea Only', 1, CAST(N'2022-11-19T11:18:56.4700000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (11, N'Take a Step Every Day', 1, CAST(N'2022-11-19T11:18:56.5633333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (12, N'Developing by Own IT Team', 1, CAST(N'2022-11-19T11:18:57.0900000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (13, N'Never Waiting for Feature', 1, CAST(N'2022-11-19T11:18:57.4400000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (14, N'Supported by Open World Commnity', 1, CAST(N'2022-11-19T11:18:57.8133333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (15, N'High Performance', 1, CAST(N'2022-11-19T11:18:58.3800000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (16, N'Intuitable System', 1, CAST(N'2022-11-19T11:18:58.6733333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (17, N'Hundreds of Tools are on Github', 1, CAST(N'2022-11-19T11:18:58.8133333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (18, N'No Limited Using', 1, CAST(N'2022-11-19T11:18:58.9100000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (19, N'Visible Step Every Day', 1, CAST(N'2022-11-19T11:18:58.9866667' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (20, N'Simple Copy/Paste Development', 1, CAST(N'2022-11-19T11:18:59.0800000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (21, N'Modern TouchPanels', 1, CAST(N'2022-11-19T11:18:59.1900000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (22, N'High Operability', 1, CAST(N'2022-11-19T11:18:59.4700000' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (23, N'Without Limitations', 1, CAST(N'2022-11-19T11:18:59.5633333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (24, N'All Features Are Possible', 1, CAST(N'2022-11-19T11:18:59.6433333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (25, N'Limit is Only Human Idea', 1, CAST(N'2022-11-19T11:18:59.7366667' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (26, N'Cheap Solution for EveryTime', 1, CAST(N'2022-11-19T11:18:59.8133333' AS DateTime2))
INSERT [dbo].[MottoList] ([Id], [SystemName], [UserId], [Timestamp]) VALUES (27, N'MultiMedia Supported', 1, CAST(N'2022-11-19T11:18:59.9100000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[MottoList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_MottoList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[MottoList] ADD  CONSTRAINT [IX_MottoList] UNIQUE NONCLUSTERED 
(
	[SystemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MottoList] ADD  CONSTRAINT [DF_MottoList_UserId]  DEFAULT ((1)) FOR [UserId]
GO
ALTER TABLE [dbo].[MottoList] ADD  CONSTRAINT [DF_MottoList_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[MottoList]  WITH CHECK ADD  CONSTRAINT [FK_MottoList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[MottoList] CHECK CONSTRAINT [FK_MottoList_UserList]
GO
