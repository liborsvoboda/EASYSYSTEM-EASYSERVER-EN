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
/****** Object:  Table [dbo].[OutgoingInvoiceList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutgoingInvoiceList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentNumber] [varchar](20) NOT NULL,
	[Supplier] [varchar](512) NOT NULL,
	[Customer] [varchar](512) NOT NULL,
	[IssueDate] [datetime2](7) NOT NULL,
	[TaxDate] [datetime2](7) NOT NULL,
	[MaturityDate] [datetime2](7) NOT NULL,
	[PaymentMethodId] [int] NOT NULL,
	[MaturityId] [int] NOT NULL,
	[OrderNumber] [varchar](50) NULL,
	[Storned] [bit] NOT NULL,
	[PaymentStatusId] [int] NOT NULL,
	[TotalCurrencyId] [int] NOT NULL,
	[Description] [text] NULL,
	[TotalPriceWithVat] [numeric](10, 2) NOT NULL,
	[ReceiptId] [int] NULL,
	[CreditNoteId] [int] NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OutgoingInvoiceList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OutgoingInvoiceList] ON 

INSERT [dbo].[OutgoingInvoiceList] ([Id], [DocumentNumber], [Supplier], [Customer], [IssueDate], [TaxDate], [MaturityDate], [PaymentMethodId], [MaturityId], [OrderNumber], [Storned], [PaymentStatusId], [TotalCurrencyId], [Description], [TotalPriceWithVat], [ReceiptId], [CreditNoteId], [UserId], [TimeStamp]) VALUES (12, N'GFAKV2023000001', N'GroupWare-Solution.Eu
Libor Svoboda
Žlutava 173
76361 Žlutava

Účet: 43-4378530247 / 0100
IČO: 86973681; DIČ: CZ8006295319
Telefon: +420724986873
Email: libor.svoboda@kliknetezde.cz', N'GroupWare-Solution.Eu
Libor Svoboda
Žlutava 173
76361 Žlutava

Účet: 43-4378530247 / 0100
IČO: 86973681; DIČ: CZ8006295319
Telefon: 00420724986873
Email: libor.svoboda@kliknetezde.cz', CAST(N'2023-03-10T00:00:00.0000000' AS DateTime2), CAST(N'2023-03-10T00:00:00.0000000' AS DateTime2), CAST(N'2023-04-09T00:00:00.0000000' AS DateTime2), 4, 1, N'', 0, 3, 1, N'', CAST(5000.00 AS Numeric(10, 2)), NULL, 10, 1, CAST(N'2023-05-01T15:03:01.8507034' AS DateTime2))
INSERT [dbo].[OutgoingInvoiceList] ([Id], [DocumentNumber], [Supplier], [Customer], [IssueDate], [TaxDate], [MaturityDate], [PaymentMethodId], [MaturityId], [OrderNumber], [Storned], [PaymentStatusId], [TotalCurrencyId], [Description], [TotalPriceWithVat], [ReceiptId], [CreditNoteId], [UserId], [TimeStamp]) VALUES (13, N'GFAKV2023000002', N'GroupWare-Solution.Eu
Libor Svoboda
Žlutava 173
76361 Žlutava

Účet: 43-4378530247 / 0100
IČO: 86973681; DIČ: CZ8006295319
Telefon: +420724986873
Email: libor.svoboda@kliknetezde.cz', N'KlikneteZde.Cz
Libor Svoboda
Žlutava 173
76361 Žlutava

Účet: 43-4378530247 / 0100
IČO: 86973681; DIČ: CZ8006295319
Telefon: +420724986873
Email: libor.svoboda@kliknetezde.cz', CAST(N'2023-03-02T00:00:00.0000000' AS DateTime2), CAST(N'2023-03-02T00:00:00.0000000' AS DateTime2), CAST(N'2023-04-01T00:00:00.0000000' AS DateTime2), 4, 1, N'', 0, 3, 1, N'', CAST(41300.00 AS Numeric(10, 2)), 11, 10, 1, CAST(N'2023-05-01T14:31:28.0825221' AS DateTime2))
INSERT [dbo].[OutgoingInvoiceList] ([Id], [DocumentNumber], [Supplier], [Customer], [IssueDate], [TaxDate], [MaturityDate], [PaymentMethodId], [MaturityId], [OrderNumber], [Storned], [PaymentStatusId], [TotalCurrencyId], [Description], [TotalPriceWithVat], [ReceiptId], [CreditNoteId], [UserId], [TimeStamp]) VALUES (14, N'GFAKV2023000003', N'GroupWare-Solution.Eu
Libor Svoboda
Žlutava 173
76361 Žlutava

Účet: 43-4378530247 / 0100
IČO: 86973681; DIČ: CZ8006295319
Telefon: +420724986873
Email: libor.svoboda@kliknetezde.cz', N'GroupWare-Solution.Eu
Libor Svoboda
Žlutava 173
76361 Žlutava

Účet: 43-4378530247 / 0100
IČO: 86973681; DIČ: CZ8006295319
Telefon: 00420724986873
Email: libor.svoboda@kliknetezde.cz', CAST(N'2023-04-01T00:00:00.0000000' AS DateTime2), CAST(N'2023-04-01T00:00:00.0000000' AS DateTime2), CAST(N'2023-05-01T00:00:00.0000000' AS DateTime2), 4, 1, N'', 0, 4, 1, N'Šablona popisku', CAST(250500.00 AS Numeric(10, 2)), 12, 11, 1, CAST(N'2023-05-02T19:49:12.6192422' AS DateTime2))
SET IDENTITY_INSERT [dbo].[OutgoingInvoiceList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OutgoingInvoiceList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[OutgoingInvoiceList] ADD  CONSTRAINT [IX_OutgoingInvoiceList] UNIQUE NONCLUSTERED 
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OutgoingInvoiceList_Customer]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_OutgoingInvoiceList_Customer] ON [dbo].[OutgoingInvoiceList]
(
	[Customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OutgoingInvoiceList] ADD  CONSTRAINT [DF_OutgoingInvoiceList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[OutgoingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceList_CreditNoteList] FOREIGN KEY([CreditNoteId])
REFERENCES [dbo].[CreditNoteList] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[OutgoingInvoiceList] CHECK CONSTRAINT [FK_OutgoingInvoiceList_CreditNoteList]
GO
ALTER TABLE [dbo].[OutgoingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceList_CurrencyList] FOREIGN KEY([TotalCurrencyId])
REFERENCES [dbo].[CurrencyList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingInvoiceList] CHECK CONSTRAINT [FK_OutgoingInvoiceList_CurrencyList]
GO
ALTER TABLE [dbo].[OutgoingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceList_MaturityList] FOREIGN KEY([MaturityId])
REFERENCES [dbo].[MaturityList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingInvoiceList] CHECK CONSTRAINT [FK_OutgoingInvoiceList_MaturityList]
GO
ALTER TABLE [dbo].[OutgoingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceList_PaymentMethodList] FOREIGN KEY([PaymentMethodId])
REFERENCES [dbo].[PaymentMethodList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingInvoiceList] CHECK CONSTRAINT [FK_OutgoingInvoiceList_PaymentMethodList]
GO
ALTER TABLE [dbo].[OutgoingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceList_PaymentStatusList] FOREIGN KEY([PaymentStatusId])
REFERENCES [dbo].[PaymentStatusList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingInvoiceList] CHECK CONSTRAINT [FK_OutgoingInvoiceList_PaymentStatusList]
GO
ALTER TABLE [dbo].[OutgoingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceList_ReceiptList] FOREIGN KEY([ReceiptId])
REFERENCES [dbo].[ReceiptList] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[OutgoingInvoiceList] CHECK CONSTRAINT [FK_OutgoingInvoiceList_ReceiptList]
GO
ALTER TABLE [dbo].[OutgoingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingInvoiceList] CHECK CONSTRAINT [FK_OutgoingInvoiceList_UserList]
GO
