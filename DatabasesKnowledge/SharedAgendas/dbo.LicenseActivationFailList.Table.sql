USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[LicenseActivationFailList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LicenseActivationFailList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IpAddress] [varchar](50) NOT NULL,
	[UnlockCode] [varchar](50) NULL,
	[PartNumber] [varchar](50) NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LicenseActivationFailList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LicenseActivationFailList_IpAddress]    Script Date: 12.03.2023 15:37:54 ******/
CREATE NONCLUSTERED INDEX [IX_LicenseActivationFailList_IpAddress] ON [dbo].[LicenseActivationFailList]
(
	[IpAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LicenseActivationFailList_PartNumber]    Script Date: 12.03.2023 15:37:54 ******/
CREATE NONCLUSTERED INDEX [IX_LicenseActivationFailList_PartNumber] ON [dbo].[LicenseActivationFailList]
(
	[PartNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LicenseActivationFailList] ADD  CONSTRAINT [DF_LicenceActivationFailList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
