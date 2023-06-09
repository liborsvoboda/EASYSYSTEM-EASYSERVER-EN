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
/****** Object:  Table [dbo].[ExchangeRateList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExchangeRateList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyId] [int] NOT NULL,
	[Value] [decimal](10, 2) NOT NULL,
	[ValidFrom] [date] NULL,
	[ValidTo] [date] NULL,
	[Description] [text] NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CourseList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ExchangeRateList] ON 

INSERT [dbo].[ExchangeRateList] ([Id], [CurrencyId], [Value], [ValidFrom], [ValidTo], [Description], [UserId], [Active], [TimeStamp]) VALUES (1, 2, CAST(25.50 AS Decimal(10, 2)), CAST(N'2022-01-01' AS Date), NULL, N'', 1, 1, CAST(N'2022-12-09T15:34:52.5797496' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ExchangeRateList] OFF
ALTER TABLE [dbo].[ExchangeRateList] ADD  CONSTRAINT [DF_CourseList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[ExchangeRateList] ADD  CONSTRAINT [DF_CourseList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[ExchangeRateList]  WITH CHECK ADD  CONSTRAINT [FK_CourseList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[ExchangeRateList] CHECK CONSTRAINT [FK_CourseList_UserList]
GO
ALTER TABLE [dbo].[ExchangeRateList]  WITH CHECK ADD  CONSTRAINT [FK_ExchangeRateList_CurrencyList] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[CurrencyList] ([Id])
GO
ALTER TABLE [dbo].[ExchangeRateList] CHECK CONSTRAINT [FK_ExchangeRateList_CurrencyList]
GO
