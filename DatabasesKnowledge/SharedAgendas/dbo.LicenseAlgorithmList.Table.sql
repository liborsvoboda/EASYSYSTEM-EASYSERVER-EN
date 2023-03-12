USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[LicenseAlgorithmList]    Script Date: 12.03.2023 15:37:54 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_LicenseAlgorithmList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
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
