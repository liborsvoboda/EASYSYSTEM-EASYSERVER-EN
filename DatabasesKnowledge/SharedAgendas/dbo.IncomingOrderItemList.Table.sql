USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[IncomingOrderItemList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncomingOrderItemList](
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
 CONSTRAINT [PK_IncomingOrderItemList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_IncomingOrderItemList]    Script Date: 12.03.2023 15:37:54 ******/
CREATE NONCLUSTERED INDEX [IX_IncomingOrderItemList] ON [dbo].[IncomingOrderItemList]
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[IncomingOrderItemList] ADD  CONSTRAINT [DF_IncomingOrderItemList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[IncomingOrderItemList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingOrderItemList_IncomingOrderList] FOREIGN KEY([DocumentNumber])
REFERENCES [dbo].[IncomingOrderList] ([DocumentNumber])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IncomingOrderItemList] CHECK CONSTRAINT [FK_IncomingOrderItemList_IncomingOrderList]
GO
ALTER TABLE [dbo].[IncomingOrderItemList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingOrderItemList_UnitList] FOREIGN KEY([Unit])
REFERENCES [dbo].[UnitList] ([Name])
GO
ALTER TABLE [dbo].[IncomingOrderItemList] CHECK CONSTRAINT [FK_IncomingOrderItemList_UnitList]
GO
ALTER TABLE [dbo].[IncomingOrderItemList]  WITH CHECK ADD  CONSTRAINT [FK_IncomingOrderItemList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[IncomingOrderItemList] CHECK CONSTRAINT [FK_IncomingOrderItemList_UserList]
GO
