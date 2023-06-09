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
/****** Object:  Table [dbo].[ItemList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PartNumber] [varchar](50) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Description] [text] NULL,
	[Unit] [varchar](10) NOT NULL,
	[Price] [numeric](10, 2) NOT NULL,
	[VatId] [int] NOT NULL,
	[CurrencyId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ItemList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ItemList] ON 

INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (10, N'LicenseShoperServer', N'LicenseShoper Server', N'', N'Lic', CAST(5000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-01-02T16:51:58.3812539' AS DateTime2))
INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (11, N'LicenseShoperSrvProjects', N'LicenseShoper Server with Projects', N'', N'Ks', CAST(15000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-01-03T16:50:27.9191472' AS DateTime2))
INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (12, N'LicenseServer', N'License Server', N'', N'Lic', CAST(5000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-05-01T18:04:20.8776504' AS DateTime2))
INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (13, N'LicenseServerProjects', N'License Server with Projects', N'', N'Ks', CAST(13000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-01-04T10:08:15.6503254' AS DateTime2))
INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (15, N'PRUVODKYSrvProjects', N'PRUVODKYServer Projects', N'', N'Ks', CAST(12000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-01-10T11:46:39.8312368' AS DateTime2))
INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (18, N'SHOPINGERServer', N'Shopinger Server', N'', N'Ks', CAST(5000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-01-04T15:21:41.6479268' AS DateTime2))
INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (19, N'SHOPINGERSrvProjects', N'Shopinger Server Projects', N'', N'Ks', CAST(15000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-01-04T15:22:08.3764057' AS DateTime2))
INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (20, N'EASYBuilderProjects', N'Easy Builder Project', N'', N'Ks', CAST(5000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-01-10T12:23:07.7435482' AS DateTime2))
INSERT [dbo].[ItemList] ([Id], [PartNumber], [Name], [Description], [Unit], [Price], [VatId], [CurrencyId], [UserId], [Active], [TimeStamp]) VALUES (21, N'EASYDATACenterProject', N'EASYDATACenter Project', N'', N'Ks', CAST(5000.00 AS Numeric(10, 2)), 6, 1, 1, 1, CAST(N'2023-01-10T11:45:57.0293321' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ItemList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ItemList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[ItemList] ADD  CONSTRAINT [IX_ItemList] UNIQUE NONCLUSTERED 
(
	[PartNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ItemList] ADD  CONSTRAINT [DF_ItemList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[ItemList] ADD  CONSTRAINT [DF_ItemList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[ItemList]  WITH CHECK ADD  CONSTRAINT [FK_ItemList_CurrencyList] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[CurrencyList] ([Id])
GO
ALTER TABLE [dbo].[ItemList] CHECK CONSTRAINT [FK_ItemList_CurrencyList]
GO
ALTER TABLE [dbo].[ItemList]  WITH CHECK ADD  CONSTRAINT [FK_ItemList_UnitList] FOREIGN KEY([Unit])
REFERENCES [dbo].[UnitList] ([Name])
GO
ALTER TABLE [dbo].[ItemList] CHECK CONSTRAINT [FK_ItemList_UnitList]
GO
ALTER TABLE [dbo].[ItemList]  WITH CHECK ADD  CONSTRAINT [FK_ItemList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[ItemList] CHECK CONSTRAINT [FK_ItemList_UserList]
GO
ALTER TABLE [dbo].[ItemList]  WITH CHECK ADD  CONSTRAINT [FK_ItemList_VatList] FOREIGN KEY([VatId])
REFERENCES [dbo].[VatList] ([Id])
GO
ALTER TABLE [dbo].[ItemList] CHECK CONSTRAINT [FK_ItemList_VatList]
GO
