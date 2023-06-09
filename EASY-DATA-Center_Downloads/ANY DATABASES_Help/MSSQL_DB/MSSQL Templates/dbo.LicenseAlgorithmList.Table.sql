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
/****** Object:  Table [dbo].[LicenseAlgorithmList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LicenseAlgorithmList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AddressId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Name] [varchar](30) NOT NULL,
	[ValidFrom] [date] NULL,
	[ValidTo] [date] NULL,
	[Algorithm] [varchar](2000) NOT NULL,
	[Description] [text] NULL,
	[LimitActive] [bit] NOT NULL,
	[ActivationLimit] [int] NULL,
	[UsedCount] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LicenseAlgorithmList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LicenseAlgorithmList] ON 

INSERT [dbo].[LicenseAlgorithmList] ([Id], [AddressId], [ItemId], [Name], [ValidFrom], [ValidTo], [Algorithm], [Description], [LimitActive], [ActivationLimit], [UsedCount], [Active], [UserId], [TimeStamp]) VALUES (19, 2, 18, N'2023-SPG-SRV', NULL, NULL, N'SELECT ''2023-SPG-SRV''', N'', 0, NULL, 4, 1, 1, CAST(N'2023-01-04T15:23:26.6242039' AS DateTime2))
INSERT [dbo].[LicenseAlgorithmList] ([Id], [AddressId], [ItemId], [Name], [ValidFrom], [ValidTo], [Algorithm], [Description], [LimitActive], [ActivationLimit], [UsedCount], [Active], [UserId], [TimeStamp]) VALUES (20, 2, 19, N'2023-SPG-SRV-PROJ', NULL, NULL, N'SELECT ''2023-SPG-SRV-PROJ''', N'', 0, NULL, 2, 1, 1, CAST(N'2023-01-04T15:23:48.2811951' AS DateTime2))
INSERT [dbo].[LicenseAlgorithmList] ([Id], [AddressId], [ItemId], [Name], [ValidFrom], [ValidTo], [Algorithm], [Description], [LimitActive], [ActivationLimit], [UsedCount], [Active], [UserId], [TimeStamp]) VALUES (22, 2, 20, N'2023-EAS-CLI-PROJ', NULL, NULL, N'SELECT ''2023-EAS-CLI-PROJ''', N'', 0, NULL, 9, 1, 1, CAST(N'2023-01-10T12:23:44.6080746' AS DateTime2))
INSERT [dbo].[LicenseAlgorithmList] ([Id], [AddressId], [ItemId], [Name], [ValidFrom], [ValidTo], [Algorithm], [Description], [LimitActive], [ActivationLimit], [UsedCount], [Active], [UserId], [TimeStamp]) VALUES (23, 2, 21, N'2023-EADA-PROJ', NULL, NULL, N'SELECT ''2023-EADA-PROJ''', N'', 0, NULL, 6, 1, 1, CAST(N'2023-01-10T13:01:36.2575279' AS DateTime2))
SET IDENTITY_INSERT [dbo].[LicenseAlgorithmList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LicenseAlgorithmList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[LicenseAlgorithmList] ADD  CONSTRAINT [IX_LicenseAlgorithmList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LicenseAlgorithmList] ADD  CONSTRAINT [DF_LicenseAlgorithmList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[LicenseAlgorithmList]  WITH CHECK ADD  CONSTRAINT [FK_LicenseAlgorithmList_AddressList] FOREIGN KEY([AddressId])
REFERENCES [dbo].[AddressList] ([Id])
GO
ALTER TABLE [dbo].[LicenseAlgorithmList] CHECK CONSTRAINT [FK_LicenseAlgorithmList_AddressList]
GO
ALTER TABLE [dbo].[LicenseAlgorithmList]  WITH CHECK ADD  CONSTRAINT [FK_LicenseAlgorithmList_ItemList] FOREIGN KEY([ItemId])
REFERENCES [dbo].[ItemList] ([Id])
GO
ALTER TABLE [dbo].[LicenseAlgorithmList] CHECK CONSTRAINT [FK_LicenseAlgorithmList_ItemList]
GO
ALTER TABLE [dbo].[LicenseAlgorithmList]  WITH CHECK ADD  CONSTRAINT [FK_LicenseAlgorithmList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[LicenseAlgorithmList] CHECK CONSTRAINT [FK_LicenseAlgorithmList_UserList]
GO
