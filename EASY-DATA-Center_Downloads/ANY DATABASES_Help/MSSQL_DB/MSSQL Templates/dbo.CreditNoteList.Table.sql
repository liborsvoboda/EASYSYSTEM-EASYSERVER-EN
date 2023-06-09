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
/****** Object:  Table [dbo].[CreditNoteList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditNoteList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentNumber] [varchar](20) NOT NULL,
	[Supplier] [varchar](512) NOT NULL,
	[Customer] [varchar](512) NOT NULL,
	[IssueDate] [datetime2](7) NOT NULL,
	[InvoiceNumber] [varchar](20) NULL,
	[Storned] [bit] NOT NULL,
	[TotalCurrencyId] [int] NOT NULL,
	[Description] [text] NULL,
	[TotalPriceWithVat] [numeric](10, 2) NOT NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CreditNoteList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CreditNoteList] ON 

INSERT [dbo].[CreditNoteList] ([Id], [DocumentNumber], [Supplier], [Customer], [IssueDate], [InvoiceNumber], [Storned], [TotalCurrencyId], [Description], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (10, N'GDB2023000001', N'GroupWare-Solution.Eu
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
Email: libor.svoboda@kliknetezde.cz', CAST(N'2023-03-22T00:00:00.0000000' AS DateTime2), N'GFAKV2023000001', 0, 1, N'', CAST(5000.00 AS Numeric(10, 2)), 1, CAST(N'2023-03-22T11:15:35.9412230' AS DateTime2))
INSERT [dbo].[CreditNoteList] ([Id], [DocumentNumber], [Supplier], [Customer], [IssueDate], [InvoiceNumber], [Storned], [TotalCurrencyId], [Description], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (11, N'GDB2023000002', N'GroupWare-Solution.Eu
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
Email: libor.svoboda@kliknetezde.cz', CAST(N'2023-04-29T00:00:00.0000000' AS DateTime2), N'GFAKV2023000003', 0, 1, N'Šablona popisku', CAST(250500.00 AS Numeric(10, 2)), 1, CAST(N'2023-04-29T21:37:56.3340198' AS DateTime2))
SET IDENTITY_INSERT [dbo].[CreditNoteList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CreditNoteList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[CreditNoteList] ADD  CONSTRAINT [IX_CreditNoteList] UNIQUE NONCLUSTERED 
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CreditNoteList] ADD  CONSTRAINT [DF_CreditNoteList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[CreditNoteList]  WITH CHECK ADD  CONSTRAINT [FK_CreditNoteList_CurrencyList] FOREIGN KEY([TotalCurrencyId])
REFERENCES [dbo].[CurrencyList] ([Id])
GO
ALTER TABLE [dbo].[CreditNoteList] CHECK CONSTRAINT [FK_CreditNoteList_CurrencyList]
GO
ALTER TABLE [dbo].[CreditNoteList]  WITH CHECK ADD  CONSTRAINT [FK_CreditNoteList_OutgoingInvoiceList] FOREIGN KEY([InvoiceNumber])
REFERENCES [dbo].[OutgoingInvoiceList] ([DocumentNumber])
GO
ALTER TABLE [dbo].[CreditNoteList] CHECK CONSTRAINT [FK_CreditNoteList_OutgoingInvoiceList]
GO
ALTER TABLE [dbo].[CreditNoteList]  WITH CHECK ADD  CONSTRAINT [FK_CreditNoteList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[CreditNoteList] CHECK CONSTRAINT [FK_CreditNoteList_UserList]
GO
