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
/****** Object:  Table [dbo].[UsedLicenseList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsedLicenseList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlgorithmName] [varchar](30) NOT NULL,
	[PartNumber] [varchar](50) NOT NULL,
	[UnlockCode] [varchar](50) NOT NULL,
	[AddressId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[License] [varchar](50) NOT NULL,
	[ActivateDate] [datetime2](7) NOT NULL,
	[IpAddress] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UsedLicenseList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UsedLicenseList] ADD  CONSTRAINT [DF_UsedLicenceList_ActivateDate]  DEFAULT (getdate()) FOR [ActivateDate]
GO
ALTER TABLE [dbo].[UsedLicenseList]  WITH CHECK ADD  CONSTRAINT [FK_UsedLicenseList_AddressList] FOREIGN KEY([AddressId])
REFERENCES [dbo].[AddressList] ([Id])
GO
ALTER TABLE [dbo].[UsedLicenseList] CHECK CONSTRAINT [FK_UsedLicenseList_AddressList]
GO
ALTER TABLE [dbo].[UsedLicenseList]  WITH CHECK ADD  CONSTRAINT [FK_UsedLicenseList_ItemList] FOREIGN KEY([ItemId])
REFERENCES [dbo].[ItemList] ([Id])
GO
ALTER TABLE [dbo].[UsedLicenseList] CHECK CONSTRAINT [FK_UsedLicenseList_ItemList]
GO
