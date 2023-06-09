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
/****** Object:  Table [dbo].[IgnoredExceptionList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IgnoredExceptionList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ErrorNumber] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[Active] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_IgnoredExceptionList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[IgnoredExceptionList] ON 

INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (1, N'-2146232798', N'Unhandled Disposing', 1, 1, CAST(N'2023-04-13T14:41:22.8506481' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (3, N'-2146232800', N'HttpClient Lost Connection', 1, 1, CAST(N'2023-04-13T14:43:19.8352014' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (4, N'-2146233029', N'Task Canceled', 1, 1, CAST(N'2023-04-13T14:44:06.3160307' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (5, N'-2147221040', N'ClipBoard Clean Bug', 1, 1, CAST(N'2023-04-13T14:45:02.0042671' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (6, N'-2147024894', N'Asembly File missing', 1, 1, CAST(N'2023-04-13T14:46:24.3709447' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (7, N'-2147221404', N'System.Runtime.InteropServices.ComTypes data format', 1, 1, CAST(N'2023-04-13T14:47:29.5398755' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (8, N'-2146233079', N'Invalid Operation (List remove in cycle)', 1, 1, CAST(N'2023-04-13T14:48:36.5475356' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (9, N'-2146233088', N'Url not found 404', 1, 1, CAST(N'2023-04-14T00:32:53.5501779' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (10, N'-2147467261', N'System.NullReferenceException
Search in Empty List', 1, 1, CAST(N'2023-04-13T14:51:38.4357139' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (11, N'-2146233040', N'DebugThrowDisconnect', 1, 1, CAST(N'2023-04-13T19:44:27.1430688' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (12, N'-2146233033', N'Diferent Variable Type Exeption', 1, 1, CAST(N'2023-04-13T23:15:29.9810702' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (13, N'-2146233080', N'Out Of Index
Example vhen List removing', 1, 1, CAST(N'2023-04-14T01:10:03.2184739' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (14, N'-2147467262', N'Cannot Retype Int to String', 1, 1, CAST(N'2023-04-13T23:17:20.5962157' AS DateTime2))
INSERT [dbo].[IgnoredExceptionList] ([Id], [ErrorNumber], [Description], [Active], [UserId], [TimeStamp]) VALUES (15, N'-2147467263', N'Operation Or method not Implemented', 1, 1, CAST(N'2023-04-15T00:46:21.0655949' AS DateTime2))
SET IDENTITY_INSERT [dbo].[IgnoredExceptionList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_IgnoredExceptionList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[IgnoredExceptionList] ADD  CONSTRAINT [IX_IgnoredExceptionList] UNIQUE NONCLUSTERED 
(
	[ErrorNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[IgnoredExceptionList] ADD  CONSTRAINT [DF_IgnoredExceptionList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[IgnoredExceptionList] ADD  CONSTRAINT [DF_IgnoredExceptionList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[IgnoredExceptionList]  WITH CHECK ADD  CONSTRAINT [FK_IgnoredExceptionList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[IgnoredExceptionList] CHECK CONSTRAINT [FK_IgnoredExceptionList_UserList]
GO
