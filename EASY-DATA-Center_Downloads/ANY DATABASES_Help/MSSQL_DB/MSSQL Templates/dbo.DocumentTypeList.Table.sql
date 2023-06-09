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
/****** Object:  Table [dbo].[DocumentTypeList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentTypeList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SystemName] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[UserId] [int] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_DocumentTypeList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DocumentTypeList] ON 

INSERT [dbo].[DocumentTypeList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (1, N'offer', N'', 1, CAST(N'2023-03-29T04:12:16.5447505' AS DateTime2))
INSERT [dbo].[DocumentTypeList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (2, N'outgoingOrder', N'', 1, CAST(N'2023-03-29T04:12:38.2875626' AS DateTime2))
INSERT [dbo].[DocumentTypeList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (3, N'incomingOrder', N'', 1, CAST(N'2023-03-29T04:12:51.4882827' AS DateTime2))
INSERT [dbo].[DocumentTypeList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (4, N'outgoingInvoice', N'', 1, CAST(N'2023-03-29T04:13:00.4963608' AS DateTime2))
INSERT [dbo].[DocumentTypeList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (5, N'incomingInvoice', N'', 1, CAST(N'2023-03-29T04:13:10.4958668' AS DateTime2))
INSERT [dbo].[DocumentTypeList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (6, N'creditNote', N'', 1, CAST(N'2023-03-29T04:13:18.5527241' AS DateTime2))
INSERT [dbo].[DocumentTypeList] ([Id], [SystemName], [Description], [UserId], [Timestamp]) VALUES (7, N'receipt', N'', 1, CAST(N'2023-03-29T04:13:25.9363287' AS DateTime2))
SET IDENTITY_INSERT [dbo].[DocumentTypeList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DocumentTypeList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[DocumentTypeList] ADD  CONSTRAINT [IX_DocumentTypeList] UNIQUE NONCLUSTERED 
(
	[SystemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DocumentTypeList] ADD  CONSTRAINT [DF_DocumentTypeList_SystemName]  DEFAULT ('MustProgramming') FOR [SystemName]
GO
ALTER TABLE [dbo].[DocumentTypeList] ADD  CONSTRAINT [DF_DocumentTypeList_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[DocumentTypeList]  WITH CHECK ADD  CONSTRAINT [FK_DocumentTypeList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[DocumentTypeList] CHECK CONSTRAINT [FK_DocumentTypeList_UserList]
GO
