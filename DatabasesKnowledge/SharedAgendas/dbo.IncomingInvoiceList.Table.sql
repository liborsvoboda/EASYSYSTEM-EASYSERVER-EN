USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[IncomingInvoiceList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncomingInvoiceList](
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
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_IncomingInvoiceList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_IncomingInvoiceList] UNIQUE NONCLUSTERED 
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[IncomingInvoiceList] ADD  CONSTRAINT [DF_IncomingInvoiceList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[IncomingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoiceList_CurrencyList] FOREIGN KEY([TotalCurrencyId])
REFERENCES [dbo].[CurrencyList] ([Id])
GO
ALTER TABLE [dbo].[IncomingInvoiceList] CHECK CONSTRAINT [FK_IncomingInvoiceList_CurrencyList]
GO
ALTER TABLE [dbo].[IncomingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoiceList_MaturityList] FOREIGN KEY([MaturityId])
REFERENCES [dbo].[MaturityList] ([Id])
GO
ALTER TABLE [dbo].[IncomingInvoiceList] CHECK CONSTRAINT [FK_IncomingInvoiceList_MaturityList]
GO
ALTER TABLE [dbo].[IncomingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoiceList_PaymentMethodList] FOREIGN KEY([PaymentMethodId])
REFERENCES [dbo].[PaymentMethodList] ([Id])
GO
ALTER TABLE [dbo].[IncomingInvoiceList] CHECK CONSTRAINT [FK_IncomingInvoiceList_PaymentMethodList]
GO
ALTER TABLE [dbo].[IncomingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoiceList_PaymentStatusList] FOREIGN KEY([PaymentStatusId])
REFERENCES [dbo].[PaymentStatusList] ([Id])
GO
ALTER TABLE [dbo].[IncomingInvoiceList] CHECK CONSTRAINT [FK_IncomingInvoiceList_PaymentStatusList]
GO
ALTER TABLE [dbo].[IncomingInvoiceList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoiceList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[IncomingInvoiceList] CHECK CONSTRAINT [FK_IncomingInvoiceList_UserList]
GO
