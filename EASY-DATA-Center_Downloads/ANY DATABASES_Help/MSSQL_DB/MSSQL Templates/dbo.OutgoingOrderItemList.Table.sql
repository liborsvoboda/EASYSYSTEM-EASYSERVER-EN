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
/****** Object:  Table [dbo].[OutgoingOrderItemList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutgoingOrderItemList](
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
 CONSTRAINT [PK_OutgoingOrderItemList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OutgoingOrderItemList]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_OutgoingOrderItemList] ON [dbo].[OutgoingOrderItemList]
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OutgoingOrderItemList] ADD  CONSTRAINT [DF_OutgoingOrderItemList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[OutgoingOrderItemList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingOrderItemList_OutgoingOrderList] FOREIGN KEY([DocumentNumber])
REFERENCES [dbo].[OutgoingOrderList] ([DocumentNumber])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OutgoingOrderItemList] CHECK CONSTRAINT [FK_OutgoingOrderItemList_OutgoingOrderList]
GO
ALTER TABLE [dbo].[OutgoingOrderItemList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingOrderItemList_UnitList] FOREIGN KEY([Unit])
REFERENCES [dbo].[UnitList] ([Name])
GO
ALTER TABLE [dbo].[OutgoingOrderItemList] CHECK CONSTRAINT [FK_OutgoingOrderItemList_UnitList]
GO
ALTER TABLE [dbo].[OutgoingOrderItemList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingOrderItemList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingOrderItemList] CHECK CONSTRAINT [FK_OutgoingOrderItemList_UserList]
GO
