USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[ReportQueueList]    Script Date: 12.03.2023 15:43:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportQueueList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Sequence] [int] NOT NULL,
	[Sql] [nvarchar](max) NOT NULL,
	[TableName] [varchar](150) NOT NULL,
	[Filter] [nvarchar](max) NULL,
	[Search] [varchar](50) NULL,
	[SearchColumnList] [nvarchar](max) NULL,
	[SearchFilterIgnore] [bit] NOT NULL,
	[RecId] [int] NULL,
	[RecIdFilterIgnore] [bit] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ReportQueue] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_ReportQueue] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ReportQueueList]    Script Date: 12.03.2023 15:43:40 ******/
CREATE NONCLUSTERED INDEX [IX_ReportQueueList] ON [dbo].[ReportQueueList]
(
	[TableName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ReportQueueList_1]    Script Date: 12.03.2023 15:43:40 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ReportQueueList_1] ON [dbo].[ReportQueueList]
(
	[TableName] ASC,
	[Sequence] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ReportQueueList] ADD  CONSTRAINT [DF_ReportQueue_SearchFilterIgnore]  DEFAULT ((0)) FOR [SearchFilterIgnore]
GO
ALTER TABLE [dbo].[ReportQueueList] ADD  CONSTRAINT [DF_ReportQueue_RecIdFilterIgnore]  DEFAULT ((0)) FOR [RecIdFilterIgnore]
GO
ALTER TABLE [dbo].[ReportQueueList] ADD  CONSTRAINT [DF_ReportQueueList_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
