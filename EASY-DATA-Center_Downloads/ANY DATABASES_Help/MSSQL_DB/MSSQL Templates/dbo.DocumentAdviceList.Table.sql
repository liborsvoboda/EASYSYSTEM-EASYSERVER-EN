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
/****** Object:  Table [dbo].[DocumentAdviceList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentAdviceList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BranchId] [int] NOT NULL,
	[DocumentType] [varchar](50) NOT NULL,
	[Prefix] [varchar](10) NOT NULL,
	[Number] [varchar](10) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_DocumentAdvice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DocumentAdviceList] ON 

INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (1, 2, N'offer', N'GNAB2022', N'000015', CAST(N'2022-01-01' AS Date), CAST(N'2022-12-31' AS Date), 1, 1, CAST(N'2022-12-16T22:55:57.0503171' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (2, 2, N'outgoingOrder', N'GOBJV2022', N'000006', CAST(N'2022-01-01' AS Date), CAST(N'2022-12-31' AS Date), 1, 1, CAST(N'2022-12-16T22:54:16.8337590' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (3, 2, N'offer', N'GNAB2023', N'000001', CAST(N'2023-01-01' AS Date), CAST(N'2023-12-31' AS Date), 1, 1, CAST(N'2022-12-16T22:42:18.4042329' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (4, 2, N'outgoingOrder', N'GOBJV2023', N'000000', CAST(N'2023-01-01' AS Date), CAST(N'2023-12-31' AS Date), 1, 1, CAST(N'2022-12-16T22:42:27.6634979' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (5, 2, N'incomingOrder', N'GOBJP2022', N'000010', CAST(N'2022-01-01' AS Date), CAST(N'2022-12-31' AS Date), 1, 1, CAST(N'2022-12-16T22:57:37.2125419' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (6, 2, N'incomingOrder', N'GOBJP2023', N'000000', CAST(N'2023-01-01' AS Date), CAST(N'2023-12-31' AS Date), 1, 1, CAST(N'2022-12-16T22:42:49.6140226' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (7, 2, N'outgoingInvoice', N'GFAKV2022', N'000011', CAST(N'2022-01-01' AS Date), CAST(N'2022-12-31' AS Date), 1, 1, CAST(N'2022-12-16T22:50:44.0599207' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (8, 2, N'outgoingInvoice', N'GFAKV2023', N'000003', CAST(N'2023-01-01' AS Date), CAST(N'2023-12-31' AS Date), 1, 1, CAST(N'2022-12-16T22:42:57.9776350' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (15, 2, N'incomingInvoice', N'GFAKP2022', N'000002', CAST(N'2022-01-01' AS Date), CAST(N'2022-12-31' AS Date), 1, 1, CAST(N'2022-12-17T09:11:58.0154369' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (16, 2, N'incomingInvoice', N'GFAKP2023', N'000000', CAST(N'2023-01-01' AS Date), CAST(N'2023-12-31' AS Date), 1, 1, CAST(N'2022-12-17T09:12:17.0814844' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (17, 2, N'creditNote', N'GDB2022', N'000012', CAST(N'2022-01-01' AS Date), CAST(N'2022-12-31' AS Date), 1, 1, CAST(N'2022-12-18T00:56:13.9862569' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (18, 2, N'creditNote', N'GDB2023', N'000002', CAST(N'2023-01-01' AS Date), CAST(N'2023-12-31' AS Date), 1, 1, CAST(N'2022-12-18T00:56:19.8358561' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (19, 2, N'receipt', N'GFIN2022', N'000007', CAST(N'2022-01-01' AS Date), CAST(N'2022-12-31' AS Date), 1, 1, CAST(N'2022-12-18T00:56:26.2012514' AS DateTime2))
INSERT [dbo].[DocumentAdviceList] ([Id], [BranchId], [DocumentType], [Prefix], [Number], [StartDate], [EndDate], [UserId], [Active], [TimeStamp]) VALUES (20, 2, N'receipt', N'GFIN2023', N'000005', CAST(N'2023-01-01' AS Date), CAST(N'2023-12-31' AS Date), 1, 1, CAST(N'2022-12-18T00:56:33.4528638' AS DateTime2))
SET IDENTITY_INSERT [dbo].[DocumentAdviceList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DocumentAdviceList]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_DocumentAdviceList] ON [dbo].[DocumentAdviceList]
(
	[BranchId] ASC,
	[DocumentType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DocumentAdviceList] ADD  CONSTRAINT [DF_DocumentAdvice_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[DocumentAdviceList] ADD  CONSTRAINT [DF_DocumentAdvice_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[DocumentAdviceList]  WITH CHECK ADD  CONSTRAINT [FK_DocumentAdvice_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[DocumentAdviceList] CHECK CONSTRAINT [FK_DocumentAdvice_UserList]
GO
ALTER TABLE [dbo].[DocumentAdviceList]  WITH CHECK ADD  CONSTRAINT [FK_DocumentAdviceList_BranchList] FOREIGN KEY([BranchId])
REFERENCES [dbo].[BranchList] ([Id])
GO
ALTER TABLE [dbo].[DocumentAdviceList] CHECK CONSTRAINT [FK_DocumentAdviceList_BranchList]
GO
ALTER TABLE [dbo].[DocumentAdviceList]  WITH CHECK ADD  CONSTRAINT [FK_DocumentAdviceList_DocumentTypeList] FOREIGN KEY([DocumentType])
REFERENCES [dbo].[DocumentTypeList] ([SystemName])
GO
ALTER TABLE [dbo].[DocumentAdviceList] CHECK CONSTRAINT [FK_DocumentAdviceList_DocumentTypeList]
GO
