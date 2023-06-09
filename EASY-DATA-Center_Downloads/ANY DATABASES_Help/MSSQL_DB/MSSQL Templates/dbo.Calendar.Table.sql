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
/****** Object:  Table [dbo].[Calendar]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calendar](
	[UserId] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Notes] [varchar](1024) NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Calendar] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'0001-01-01' AS Date), N'gbnhjvjghj', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-10-03' AS Date), N'', CAST(N'2022-11-09T09:18:48.4996304' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-10-04' AS Date), N'', CAST(N'2022-11-09T09:13:33.0024550' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-10-11' AS Date), N'', CAST(N'2022-11-09T09:18:51.0850795' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-07' AS Date), N'10 Schůzka EASYBuilder', CAST(N'2022-11-25T12:23:02.3690984' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-08' AS Date), N'12:30 meeting DEV
15:30 scrum
', CAST(N'2022-11-25T12:23:02.4900986' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-09' AS Date), N'10:30 Publish new Ver
', CAST(N'2022-11-25T12:23:02.7102539' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-10' AS Date), N'', CAST(N'2022-11-25T12:23:16.6740624' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-15' AS Date), N'12 Launch', CAST(N'2022-11-25T12:23:02.9112547' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-16' AS Date), N'', CAST(N'2022-11-16T23:01:21.1962644' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-22' AS Date), N'8:00 Offer EASYDATA', CAST(N'2022-11-25T12:23:03.0245574' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-23' AS Date), N'', CAST(N'2022-11-09T09:13:08.2034641' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2022-11-29' AS Date), N'', CAST(N'2022-11-25T12:22:49.1749983' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2023-04-04' AS Date), N'', CAST(N'2023-04-12T23:32:39.8906139' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2023-04-11' AS Date), N'', CAST(N'2023-04-12T23:32:39.0359777' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2023-04-12' AS Date), N'', CAST(N'2023-04-12T23:32:26.2757530' AS DateTime2))
INSERT [dbo].[Calendar] ([UserId], [Date], [Notes], [TimeStamp]) VALUES (1, CAST(N'2023-05-01' AS Date), N'', CAST(N'2023-05-01T14:15:25.5700366' AS DateTime2))
ALTER TABLE [dbo].[Calendar] ADD  CONSTRAINT [DF_Calendar_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[Calendar]  WITH CHECK ADD  CONSTRAINT [FK_Calendar_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Calendar] CHECK CONSTRAINT [FK_Calendar_UserList]
GO
