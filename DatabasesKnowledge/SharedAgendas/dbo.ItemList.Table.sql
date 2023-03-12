USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[ItemList]    Script Date: 12.03.2023 15:37:54 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_ItemList] UNIQUE NONCLUSTERED 
(
	[PartNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
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
