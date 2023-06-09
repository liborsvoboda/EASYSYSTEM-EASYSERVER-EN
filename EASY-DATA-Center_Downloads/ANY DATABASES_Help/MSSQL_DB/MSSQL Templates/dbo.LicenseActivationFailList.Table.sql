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
/****** Object:  Table [dbo].[LicenseActivationFailList]    Script Date: 03.05.2023 11:24:00 ******/
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
SET IDENTITY_INSERT [dbo].[LicenseActivationFailList] ON 

INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (1, N'Unknown', N'1111', N'SHOPINGER', CAST(N'2022-12-21T09:27:27.3900000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (2, N'Unknown', N'1111', N'SHOPINGER', CAST(N'2022-12-21T09:28:04.9600000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (3, N'Unknown', N'server license code', N'LicenseShoper', CAST(N'2022-12-24T15:46:33.6200000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (4, N'Unknown', N'server license code', N'LicenseShoper', CAST(N'2022-12-24T16:16:12.4800000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (5, N'Unknown', N'server license code', N'LicenseShoper', CAST(N'2022-12-24T16:18:48.5733333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (6, N'Unknown', N'55555', N'LicenseShoper', CAST(N'2022-12-24T16:33:16.7000000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (7, N'Unknown', N'server license code', N'LicenseShoper', CAST(N'2022-12-24T17:11:07.4666667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (8, N'Unknown', N'55555', N'LicenseShoper', CAST(N'2022-12-24T17:12:05.2466667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (9, N'Unknown', N'55550', N'LicenseShoper', CAST(N'2022-12-28T11:44:12.9600000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (10, N'192.168.1.141', N'55550', N'LicenseShoperServer', CAST(N'2023-01-02T18:57:44.2866667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (11, N'192.168.1.141', N'55550', N'LicenseShoperServer', CAST(N'2023-01-02T20:06:58.8000000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (12, N'192.168.1.141', N'55505', N'LicenseShoperServer', CAST(N'2023-01-03T05:29:03.5866667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (13, N'192.168.1.141', N'55505', N'LicenseShoperServer', CAST(N'2023-01-03T05:37:41.7200000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (14, N'Unknown', N'55550', N'LicenseShoperServer', CAST(N'2023-01-03T12:07:52.9200000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (15, N'Unknown', N'2222', N'LicenseShoperServer', CAST(N'2023-01-03T12:12:15.7066667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (16, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:18:08.7000000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (17, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:18:30.5466667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (18, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:21:24.3733333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (19, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:23:07.5033333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (20, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:23:57.8733333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (21, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:25:33.5000000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (22, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:26:07.1400000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (23, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:28:29.0900000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (24, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:32:41.5300000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (25, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:33:10.7500000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (26, N'Unknown', N'555', N'LicenseShoperServer', CAST(N'2023-01-03T12:36:33.6333333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (27, N'Unknown', N'5555', N'LicenseShoperSrvProjects', CAST(N'2023-01-03T16:48:10.1466667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (28, N'Unknown', N'2023-LIC-SRV-PROJ', N'LicenseShoperSrvProjects', CAST(N'2023-01-03T16:51:55.6000000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (29, N'Unknown', N'2023-LIC-SRV-SIMPLE', N'LicenseSrvServerProjects', CAST(N'2023-01-04T10:06:22.5633333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (30, N'Unknown', N'2023-LIC-SRV-SIMPLE-PROJ', N'LicenseSrvServerProjects', CAST(N'2023-01-04T10:06:31.4233333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (31, N'192.168.1.45', N'Validate', N'EASYBuilderProjects', CAST(N'2023-01-10T12:21:10.6466667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (32, N'192.168.1.45', N'2023-EAS-CLI-PROJ', N'EASYBuilderProjects', CAST(N'2023-01-10T12:21:24.2100000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (33, N'192.168.1.45', N'2023-EAS-CLI-PROJ', N'EASYBuilderProjects', CAST(N'2023-01-10T12:21:36.9200000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (34, N'192.168.1.45', N'2023-EAS-CLI-PROJ', N'EASYBuilderProjects', CAST(N'2023-01-10T12:22:21.6800000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (35, N'192.168.1.45', N'EASYBuilderProjects', N'EASYBuilderProjects', CAST(N'2023-01-10T12:24:27.9766667' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (36, N'192.168.1.45', N'Kód je platný', N'EASYBuilderProjects', CAST(N'2023-01-10T12:24:47.1633333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (37, N'192.168.1.45', N'Server není dostupný. Zkuste to prosím později', N'EASYBuilderProjects', CAST(N'2023-01-10T12:41:31.2400000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (38, N'192.168.1.45', N'2023-EADA-PROJ', N'EASYDATACenterProjects', CAST(N'2023-01-10T15:40:56.6233333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (39, N'192.168.1.45', N'2023-LIC-SRV-SIMPLE', N'LicenseShoperServer', CAST(N'2023-01-12T13:06:02.8533333' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (40, N'192.168.1.45', N'2023-LIC-SRV-SIMPLE', N'LicenseShoperServer', CAST(N'2023-01-12T13:06:42.7600000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (41, N'192.168.1.45', N'2023-LIC-SRV-SIMPLE', N'LicenseShoperServer', CAST(N'2023-01-12T13:09:10.9800000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (42, N'192.168.1.45', N'bmbnmbnm', N'SHOPINGERServer', CAST(N'2023-01-23T14:46:05.6500000' AS DateTime2))
INSERT [dbo].[LicenseActivationFailList] ([Id], [IpAddress], [UnlockCode], [PartNumber], [TimeStamp]) VALUES (43, N'192.168.1.141', N'55505', N'LicenseShoperServer', CAST(N'2023-01-27T13:46:02.8566667' AS DateTime2))
SET IDENTITY_INSERT [dbo].[LicenseActivationFailList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LicenseActivationFailList_IpAddress]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_LicenseActivationFailList_IpAddress] ON [dbo].[LicenseActivationFailList]
(
	[IpAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LicenseActivationFailList_PartNumber]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_LicenseActivationFailList_PartNumber] ON [dbo].[LicenseActivationFailList]
(
	[PartNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LicenseActivationFailList] ADD  CONSTRAINT [DF_LicenceActivationFailList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
