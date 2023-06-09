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
/****** Object:  Table [dbo].[ReportQueueList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportQueueList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Sequence] [int] NOT NULL,
	[Sql] [nvarchar](max) NOT NULL,
	[TableName] [varchar](150) NOT NULL,
	[Filter] [nvarchar](max) NULL,
	[Search] [varchar](50) NULL,
	[SearchColumnList] [nvarchar](max) NULL,
	[SearchFilterIgnore] [bit] NOT NULL,
	[RecId] [int] NULL,
	[RecIdFilterIgnore] [bit] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ReportQueue] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ReportQueueList] ON 

INSERT [dbo].[ReportQueueList] ([Id], [Name], [Sequence], [Sql], [TableName], [Filter], [Search], [SearchColumnList], [SearchFilterIgnore], [RecId], [RecIdFilterIgnore], [Timestamp]) VALUES (1, N'LoginHistoryFilter', 10, N'SELECT * FROM LoginHistoryList', N'LoginHistoryList', N'UserName LIKE ''sys%'' AND Id < ''20''', N'', N'UserName,Description,Id', 0, 0, 0, CAST(N'2023-04-15T20:21:39.0409314' AS DateTime2))
INSERT [dbo].[ReportQueueList] ([Id], [Name], [Sequence], [Sql], [TableName], [Filter], [Search], [SearchColumnList], [SearchFilterIgnore], [RecId], [RecIdFilterIgnore], [Timestamp]) VALUES (3, N'Hromadny tisk Faktur', 10, N'SELECT 
oil.Id,oil.DocumentNumber,oil.Supplier,oil.Customer,oil.OrderNumber,oil.[Description],oil.[TotalPriceWithVat],
FORMAT(oil.[IssueDate],''dd.MM.yyyy'') as IssueDate,
FORMAT(oil.[TaxDate],''dd.MM.yyyy'') as TaxDate,
FORMAT(oil.[MaturityDate],''dd.MM.yyyy'') as MaturityDate,
ISNULL((SELECT pm.[name] FROM [dbo].[PaymentMethodList] pm WHERE pm.Id = oil.PaymentMethodId), NULL) as PaymentMethod,
ROUND(ISNULL((SELECT SUM(oiil.TotalPrice) FROM OutgoingInvoiceItemList oiil WHERE oiil.DocumentNumber = oil.DocumentNumber),0),2) as TotalWithoutDPH,
ROUND(ISNULL((SELECT SUM(oiil.TotalPriceWithVat - oiil.TotalPrice) FROM OutgoingInvoiceItemList oiil WHERE oiil.DocumentNumber = oil.DocumentNumber),0),2) as DPH,
ROUND((oil.[TotalPriceWithVat] - ISNULL((SELECT SUM(oiil.TotalPriceWithVat) FROM OutgoingInvoiceItemList oiil WHERE oiil.DocumentNumber = oil.DocumentNumber ),0)),2) as Rounded
FROM OutgoingInvoiceList oil', N'OutgoingInvoiceList', N'1=1', N'', N'Id,DocumentNumber,Customer', 1, 0, 1, CAST(N'2023-04-15T20:20:41.2619627' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ReportQueueList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ReportQueue]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[ReportQueueList] ADD  CONSTRAINT [IX_ReportQueue] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ReportQueueList]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_ReportQueueList] ON [dbo].[ReportQueueList]
(
	[TableName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ReportQueueList_1]    Script Date: 03.05.2023 11:24:04 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ReportQueueList_1] ON [dbo].[ReportQueueList]
(
	[TableName] ASC,
	[Sequence] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ReportQueueList] ADD  CONSTRAINT [DF_ReportQueue_SearchFilterIgnore]  DEFAULT ((0)) FOR [SearchFilterIgnore]
GO
ALTER TABLE [dbo].[ReportQueueList] ADD  CONSTRAINT [DF_ReportQueue_RecIdFilterIgnore]  DEFAULT ((0)) FOR [RecIdFilterIgnore]
GO
ALTER TABLE [dbo].[ReportQueueList] ADD  CONSTRAINT [DF_ReportQueueList_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
