USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[IncomingInvoiceItemList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncomingInvoiceItemList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentNumber] [varchar](20) NOT NULL,
	[PartNumber] [varchar](50) NULL,
	[Name] [varchar](150) NOT NULL,
	[Unit] [varchar](10) NOT NULL,
	[PcsPrice] [numeric](10, 2) NOT NULL,
	[Count] [numeric](10, 2) NOT NULL,
	[TotalPrice] [numeric](10, 2) NOT NULL,
	[Vat] [numeric](10, 2) NOT NULL,
	[TotalPriceWithVat] [numeric](10, 2) NOT NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_IncomingInvoiceItemList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_IncomingInvoiceItemList]    Script Date: 12.03.2023 15:37:54 ******/
CREATE NONCLUSTERED INDEX [IX_IncomingInvoiceItemList] ON [dbo].[IncomingInvoiceItemList]
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[IncomingInvoiceItemList] ADD  CONSTRAINT [DF_IncomingInvoiceItemList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[IncomingInvoiceItemList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoiceItemList_IncomingInvoiceList] FOREIGN KEY([DocumentNumber])
REFERENCES [dbo].[IncomingInvoiceList] ([DocumentNumber])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IncomingInvoiceItemList] CHECK CONSTRAINT [FK_IncomingInvoiceItemList_IncomingInvoiceList]
GO
ALTER TABLE [dbo].[IncomingInvoiceItemList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoiceItemList_UnitList] FOREIGN KEY([Unit])
REFERENCES [dbo].[UnitList] ([Name])
GO
ALTER TABLE [dbo].[IncomingInvoiceItemList] CHECK CONSTRAINT [FK_IncomingInvoiceItemList_UnitList]
GO
ALTER TABLE [dbo].[IncomingInvoiceItemList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoiceItemList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[IncomingInvoiceItemList] CHECK CONSTRAINT [FK_IncomingInvoiceItemList_UserList]
GO
