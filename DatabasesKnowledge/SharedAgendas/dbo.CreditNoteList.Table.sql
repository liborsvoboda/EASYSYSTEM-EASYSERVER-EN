USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[CreditNoteList]    Script Date: 12.03.2023 15:37:54 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_CreditNoteList] UNIQUE NONCLUSTERED 
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
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
