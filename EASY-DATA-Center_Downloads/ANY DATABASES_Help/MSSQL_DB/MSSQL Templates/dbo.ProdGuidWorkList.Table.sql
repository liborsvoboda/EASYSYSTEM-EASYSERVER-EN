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
/****** Object:  Table [dbo].[ProdGuidWorkList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdGuidWorkList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[PersonalNumber] [int] NOT NULL,
	[WorkPlace] [int] NOT NULL,
	[OperationNumber] [int] NOT NULL,
	[WorkTime] [time](7) NOT NULL,
	[Pcs] [int] NOT NULL,
	[Amount] [numeric](10, 2) NOT NULL,
	[WorkPower] [numeric](10, 2) NOT NULL,
	[UserId] [int] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProdGuidWorkList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProdGuidWorkList] ON 

INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (1, CAST(N'2022-12-14T00:00:00.0000000' AS DateTime2), 508, 126, 32, CAST(N'01:00:00' AS Time), 455, CAST(391.30 AS Numeric(10, 2)), CAST(334.56 AS Numeric(10, 2)), 1, CAST(N'2023-01-19T10:29:10.0758998' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (2, CAST(N'2022-12-14T00:00:00.0000000' AS DateTime2), 508, 500, 4, CAST(N'01:00:00' AS Time), 150, CAST(699.75 AS Numeric(10, 2)), CAST(375.00 AS Numeric(10, 2)), 1, CAST(N'2023-01-18T18:56:54.5675786' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (3, CAST(N'2023-01-18T00:00:00.0000000' AS DateTime2), 1734, 126, 32, CAST(N'01:00:00' AS Time), 10, CAST(8.60 AS Numeric(10, 2)), CAST(7.35 AS Numeric(10, 2)), 1, CAST(N'2023-01-18T15:33:02.1301466' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (4, CAST(N'2023-02-05T00:00:00.0000000' AS DateTime2), 508, 500, 3, CAST(N'23:50:00' AS Time), 1500, CAST(5526.00 AS Numeric(10, 2)), CAST(123.41 AS Numeric(10, 2)), 1, CAST(N'2023-02-05T17:43:47.4925616' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (5, CAST(N'2023-02-05T00:00:00.0000000' AS DateTime2), 508, 500, 2, CAST(N'22:50:00' AS Time), 600, CAST(4665.00 AS Numeric(10, 2)), CAST(109.49 AS Numeric(10, 2)), 1, CAST(N'2023-02-05T17:44:10.4897886' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (6, CAST(N'2023-02-06T00:00:00.0000000' AS DateTime2), 508, 126, 30, CAST(N'01:00:00' AS Time), 1, CAST(0.88 AS Numeric(10, 2)), CAST(0.71 AS Numeric(10, 2)), 1, CAST(N'2023-02-06T06:29:02.3680904' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (7, CAST(N'2023-02-06T00:00:00.0000000' AS DateTime2), 508, 500, 3, CAST(N'02:00:00' AS Time), 20, CAST(73.68 AS Numeric(10, 2)), CAST(19.61 AS Numeric(10, 2)), 1, CAST(N'2023-02-06T06:31:06.8559021' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (8, CAST(N'2023-03-08T00:00:00.0000000' AS DateTime2), 1130, 500, 4, CAST(N'01:00:00' AS Time), 10, CAST(46.65 AS Numeric(10, 2)), CAST(25.00 AS Numeric(10, 2)), 1, CAST(N'2023-03-08T06:23:41.4591804' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (9, CAST(N'2023-03-08T00:00:00.0000000' AS DateTime2), 1130, 500, 9, CAST(N'02:30:00' AS Time), 550, CAST(418.00 AS Numeric(10, 2)), CAST(146.67 AS Numeric(10, 2)), 1, CAST(N'2023-03-08T06:24:13.0393321' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (10, CAST(N'2023-03-08T00:00:00.0000000' AS DateTime2), 1130, 500, 9, CAST(N'02:30:00' AS Time), 550, CAST(418.00 AS Numeric(10, 2)), CAST(146.67 AS Numeric(10, 2)), 1, CAST(N'2023-03-08T06:24:06.3031569' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (11, CAST(N'2023-03-08T00:00:00.0000000' AS DateTime2), 1687, 500, 10, CAST(N'03:55:00' AS Time), 184, CAST(811.44 AS Numeric(10, 2)), CAST(162.00 AS Numeric(10, 2)), 1, CAST(N'2023-03-08T06:38:06.6102994' AS DateTime2))
INSERT [dbo].[ProdGuidWorkList] ([Id], [Date], [PersonalNumber], [WorkPlace], [OperationNumber], [WorkTime], [Pcs], [Amount], [WorkPower], [UserId], [Timestamp]) VALUES (12, CAST(N'2023-04-30T00:00:00.0000000' AS DateTime2), 1667, 126, 32, CAST(N'01:00:00' AS Time), 10, CAST(8.60 AS Numeric(10, 2)), CAST(7.35 AS Numeric(10, 2)), 1, CAST(N'2023-04-30T01:05:57.5582892' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProdGuidWorkList] OFF
ALTER TABLE [dbo].[ProdGuidWorkList] ADD  CONSTRAINT [DF_Prace_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[ProdGuidWorkList]  WITH CHECK ADD  CONSTRAINT [FK_ProdGuidWorkList_ProdGuidPersonList] FOREIGN KEY([PersonalNumber])
REFERENCES [dbo].[ProdGuidPersonList] ([PersonalNumber])
GO
ALTER TABLE [dbo].[ProdGuidWorkList] CHECK CONSTRAINT [FK_ProdGuidWorkList_ProdGuidPersonList]
GO
ALTER TABLE [dbo].[ProdGuidWorkList]  WITH CHECK ADD  CONSTRAINT [FK_ProdGuidWorkList_ProdGuidWorkList] FOREIGN KEY([Id])
REFERENCES [dbo].[ProdGuidWorkList] ([Id])
GO
ALTER TABLE [dbo].[ProdGuidWorkList] CHECK CONSTRAINT [FK_ProdGuidWorkList_ProdGuidWorkList]
GO
ALTER TABLE [dbo].[ProdGuidWorkList]  WITH CHECK ADD  CONSTRAINT [FK_ProdGuidWorkList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProdGuidWorkList] CHECK CONSTRAINT [FK_ProdGuidWorkList_UserList]
GO
