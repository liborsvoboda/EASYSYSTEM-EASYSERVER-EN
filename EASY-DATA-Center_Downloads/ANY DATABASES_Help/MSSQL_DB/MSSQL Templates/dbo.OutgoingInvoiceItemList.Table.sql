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
/****** Object:  Table [dbo].[OutgoingInvoiceItemList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutgoingInvoiceItemList](
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
 CONSTRAINT [PK_OutgoingInvoiceItemList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OutgoingInvoiceItemList] ON 

INSERT [dbo].[OutgoingInvoiceItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (118, N'GFAKV2023000002', N'LicenseShoperServer', N'LicenseShoper Server', N'Lic', CAST(5000.00 AS Numeric(10, 2)), CAST(1.00 AS Numeric(10, 2)), CAST(5000.00 AS Numeric(10, 2)), CAST(0.00 AS Numeric(10, 2)), CAST(5000.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[OutgoingInvoiceItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (119, N'GFAKV2023000002', N'LicenseShoperSrvProjects', N'LicenseShoper Server with Projects', N'Ks', CAST(15000.00 AS Numeric(10, 2)), CAST(2.00 AS Numeric(10, 2)), CAST(30000.00 AS Numeric(10, 2)), CAST(0.21 AS Numeric(10, 2)), CAST(36300.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[OutgoingInvoiceItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (122, N'GFAKV2023000001', N'LicenseShoperServer', N'LicenseShoper Server', N'Lic', CAST(5000.00 AS Numeric(10, 2)), CAST(1.00 AS Numeric(10, 2)), CAST(5000.00 AS Numeric(10, 2)), CAST(0.00 AS Numeric(10, 2)), CAST(5000.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[OutgoingInvoiceItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (125, N'GFAKV2023000003', N'LicenseShoperSrvProjects', N'LicenseShoper Server with Projects', N'Ks', CAST(15000.00 AS Numeric(10, 2)), CAST(10.00 AS Numeric(10, 2)), CAST(150000.00 AS Numeric(10, 2)), CAST(0.21 AS Numeric(10, 2)), CAST(181500.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[OutgoingInvoiceItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (126, N'GFAKV2023000003', N'PRUVODKYSrvProjects', N'PRUVODKYServer Projects', N'Ks', CAST(12000.00 AS Numeric(10, 2)), CAST(5.00 AS Numeric(10, 2)), CAST(60000.00 AS Numeric(10, 2)), CAST(0.15 AS Numeric(10, 2)), CAST(69000.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[OutgoingInvoiceItemList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OutgoingInvoiceItemList]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_OutgoingInvoiceItemList] ON [dbo].[OutgoingInvoiceItemList]
(
	[DocumentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OutgoingInvoiceItemList] ADD  CONSTRAINT [DF_OutgoingInvoiceItemList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[OutgoingInvoiceItemList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceItemList_OutgoingInvoiceList] FOREIGN KEY([DocumentNumber])
REFERENCES [dbo].[OutgoingInvoiceList] ([DocumentNumber])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OutgoingInvoiceItemList] CHECK CONSTRAINT [FK_OutgoingInvoiceItemList_OutgoingInvoiceList]
GO
ALTER TABLE [dbo].[OutgoingInvoiceItemList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceItemList_UnitList] FOREIGN KEY([Unit])
REFERENCES [dbo].[UnitList] ([Name])
GO
ALTER TABLE [dbo].[OutgoingInvoiceItemList] CHECK CONSTRAINT [FK_OutgoingInvoiceItemList_UnitList]
GO
ALTER TABLE [dbo].[OutgoingInvoiceItemList]  WITH CHECK ADD  CONSTRAINT [FK_OutgoingInvoiceItemList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[OutgoingInvoiceItemList] CHECK CONSTRAINT [FK_OutgoingInvoiceItemList_UserList]
GO
