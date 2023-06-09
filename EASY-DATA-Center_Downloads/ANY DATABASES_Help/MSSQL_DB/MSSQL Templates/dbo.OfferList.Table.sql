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
/****** Object:  Table [dbo].[OfferList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OfferList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentNumber] [varchar](20) NOT NULL,
	[Supplier] [varchar](512) NOT NULL,
	[Customer] [varchar](512) NOT NULL,
	[OfferValidity] [int] NOT NULL,
	[Storned] [bit] NOT NULL,
	[TotalCurrencyId] [int] NOT NULL,
	[Description] [text] NULL,
	[TotalPriceWithVat] [numeric](10, 2) NOT NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OfferList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OfferList] ON 

INSERT [dbo].[OfferList] ([Id], [DocumentNumber], [Supplier], [Customer], [OfferValidity], [Storned], [TotalCurrencyId], [Description], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (16, N'GNAB2023000001', N'GroupWare-Solution.Eu
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
Email: libor.svoboda@kliknetezde.cz', 30, 0, 1, N'Šablona popisku', CAST(150000.00 AS Numeric(10, 2)), 1, CAST(N'2023-05-01T19:02:52.3155238' AS DateTime2))
SET IDENTITY_INSERT [dbo].[OfferList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OfferList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[OfferList] ADD  CONSTRAINT [IX_OfferList] UNIQUE NONCLUSTERED 
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OfferList_Customer]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_OfferList_Customer] ON [dbo].[OfferList]
(
	[Customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OfferList] ADD  CONSTRAINT [DF_OfferList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[OfferList]  WITH CHECK ADD  CONSTRAINT [FK_OfferList_CurrencyList1] FOREIGN KEY([TotalCurrencyId])
REFERENCES [dbo].[CurrencyList] ([Id])
GO
ALTER TABLE [dbo].[OfferList] CHECK CONSTRAINT [FK_OfferList_CurrencyList1]
GO
ALTER TABLE [dbo].[OfferList]  WITH CHECK ADD  CONSTRAINT [FK_OfferList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[OfferList] CHECK CONSTRAINT [FK_OfferList_UserList]
GO
