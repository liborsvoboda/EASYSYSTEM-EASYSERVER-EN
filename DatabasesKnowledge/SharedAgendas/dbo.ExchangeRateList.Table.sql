USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[ExchangeRateList]    Script Date: 12.03.2023 15:37:54 ******/
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
