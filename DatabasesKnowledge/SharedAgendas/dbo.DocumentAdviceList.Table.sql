USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[DocumentAdviceList]    Script Date: 12.03.2023 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentAdviceList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BranchId] [int] NOT NULL,
	[DocumentType] [varchar](50) NOT NULL,
	[Prefix] [varchar](10) NOT NULL,
	[Number] [varchar](10) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_DocumentAdvice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_DocumentAdviceList]    Script Date: 12.03.2023 15:37:54 ******/
CREATE NONCLUSTERED INDEX [IX_DocumentAdviceList] ON [dbo].[DocumentAdviceList]
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DocumentAdviceList] ADD  CONSTRAINT [DF_DocumentAdvice_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[DocumentAdviceList] ADD  CONSTRAINT [DF_DocumentAdvice_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[DocumentAdviceList]  WITH CHECK ADD  CONSTRAINT [FK_DocumentAdvice_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[DocumentAdviceList] CHECK CONSTRAINT [FK_DocumentAdvice_UserList]
GO
ALTER TABLE [dbo].[DocumentAdviceList]  WITH CHECK ADD  CONSTRAINT [FK_DocumentAdviceList_BranchList] FOREIGN KEY([BranchId])
REFERENCES [dbo].[BranchList] ([Id])
GO
ALTER TABLE [dbo].[DocumentAdviceList] CHECK CONSTRAINT [FK_DocumentAdviceList_BranchList]
GO
