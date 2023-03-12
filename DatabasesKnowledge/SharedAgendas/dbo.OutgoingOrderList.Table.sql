USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[OutgoingOrderList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutgoingOrderList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentNumber] [varchar](20) NOT NULL,
	[Customer] [varchar](512) NOT NULL,
	[Supplier] [varchar](512) NOT NULL,
	[Storned] [bit] NOT NULL,
	[TotalCurrencyId] [int] NOT NULL,
	[Description] [text] NULL,
	[TotalPriceWithVat] [numeric](10, 2) NOT NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OutgoingOrderList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_OutgoingOrderList] UNIQUE NONCLUSTERED 
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OutgoingOrderList_Supplier]    Script Date: 12.03.2023 15:37:54 ******/
CREATE NONCLUSTERED INDEX [IX_OutgoingOrderList_Supplier] ON [dbo].[OutgoingOrderList]
(
	[Supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OutgoingOrderList] ADD  CONSTRAINT [DF_OutgoingOrderList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[OutgoingOrderList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingOrderList_CurrencyList] FOREIGN KEY([TotalCurrencyId])
REFERENCES [dbo].[CurrencyList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingOrderList] CHECK CONSTRAINT [FK_OutgoingOrderList_CurrencyList]
GO
ALTER TABLE [dbo].[OutgoingOrderList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingOrderList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingOrderList] CHECK CONSTRAINT [FK_OutgoingOrderList_UserList]
GO
