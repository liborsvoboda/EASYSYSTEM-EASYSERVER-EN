USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[ReceiptList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentNumber] [varchar](20) NOT NULL,
	[InvoiceNumber] [varchar](20) NULL,
	[Supplier] [varchar](512) NOT NULL,
	[Customer] [varchar](512) NOT NULL,
	[IssueDate] [datetime2](7) NOT NULL,
	[Storned] [bit] NOT NULL,
	[TotalCurrencyId] [int] NOT NULL,
	[Description] [text] NULL,
	[TotalPriceWithVat] [numeric](10, 2) NOT NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ReceiptList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_ReceiptList] UNIQUE NONCLUSTERED 
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ReceiptList] ADD  CONSTRAINT [DF_ReceiptList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[ReceiptList]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptList_CurrencyList] FOREIGN KEY([TotalCurrencyId])
REFERENCES [dbo].[CurrencyList] ([Id])
GO
ALTER TABLE [dbo].[ReceiptList] CHECK CONSTRAINT [FK_ReceiptList_CurrencyList]
GO
ALTER TABLE [dbo].[ReceiptList]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptList_OutgoingInvoiceList] FOREIGN KEY([InvoiceNumber])
REFERENCES [dbo].[OutgoingInvoiceList] ([DocumentNumber])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ReceiptList] CHECK CONSTRAINT [FK_ReceiptList_OutgoingInvoiceList]
GO
ALTER TABLE [dbo].[ReceiptList]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[ReceiptList] CHECK CONSTRAINT [FK_ReceiptList_UserList]
GO
