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
/****** Object:  Table [dbo].[ReceiptItemList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptItemList](
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
 CONSTRAINT [PK_ReceiptItemList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ReceiptItemList] ON 

INSERT [dbo].[ReceiptItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (7, N'GFIN2023000004', N'LicenseShoperServer', N'LicenseShoper Server', N'Lic', CAST(5000.00 AS Numeric(10, 2)), CAST(1.00 AS Numeric(10, 2)), CAST(5000.00 AS Numeric(10, 2)), CAST(0.00 AS Numeric(10, 2)), CAST(5000.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[ReceiptItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (8, N'GFIN2023000004', N'LicenseShoperSrvProjects', N'LicenseShoper Server with Projects', N'Ks', CAST(15000.00 AS Numeric(10, 2)), CAST(2.00 AS Numeric(10, 2)), CAST(30000.00 AS Numeric(10, 2)), CAST(0.21 AS Numeric(10, 2)), CAST(36300.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[ReceiptItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (9, N'GFIN2023000005', N'LicenseShoperSrvProjects', N'LicenseShoper Server with Projects', N'Ks', CAST(15000.00 AS Numeric(10, 2)), CAST(10.00 AS Numeric(10, 2)), CAST(150000.00 AS Numeric(10, 2)), CAST(0.21 AS Numeric(10, 2)), CAST(181500.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[ReceiptItemList] ([Id], [DocumentNumber], [PartNumber], [Name], [Unit], [PcsPrice], [Count], [TotalPrice], [Vat], [TotalPriceWithVat], [UserId], [TimeStamp]) VALUES (10, N'GFIN2023000005', N'PRUVODKYSrvProjects', N'PRUVODKYServer Projects', N'Ks', CAST(12000.00 AS Numeric(10, 2)), CAST(5.00 AS Numeric(10, 2)), CAST(60000.00 AS Numeric(10, 2)), CAST(0.15 AS Numeric(10, 2)), CAST(69000.00 AS Numeric(10, 2)), 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ReceiptItemList] OFF
ALTER TABLE [dbo].[ReceiptItemList] ADD  CONSTRAINT [DF_ReceiptItemList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[ReceiptItemList]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptItemList_ReceiptList] FOREIGN KEY([DocumentNumber])
REFERENCES [dbo].[ReceiptList] ([DocumentNumber])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ReceiptItemList] CHECK CONSTRAINT [FK_ReceiptItemList_ReceiptList]
GO
ALTER TABLE [dbo].[ReceiptItemList]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptItemList_UnitList] FOREIGN KEY([Unit])
REFERENCES [dbo].[UnitList] ([Name])
GO
ALTER TABLE [dbo].[ReceiptItemList] CHECK CONSTRAINT [FK_ReceiptItemList_UnitList]
GO
ALTER TABLE [dbo].[ReceiptItemList]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptItemList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[ReceiptItemList] CHECK CONSTRAINT [FK_ReceiptItemList_UserList]
GO
