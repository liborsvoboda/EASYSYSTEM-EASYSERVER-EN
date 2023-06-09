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
/****** Object:  Table [dbo].[ServerTablesLocUsedList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServerTablesLocUsedList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[UserId] [int] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ServerTablesLocUsedList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ServerTablesLocUsedList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[ServerTablesLocUsedList] ADD  CONSTRAINT [IX_ServerTablesLocUsedList] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ServerTablesLocUsedList] ADD  CONSTRAINT [DF_ServerTablesLocUsedList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[ServerTablesLocUsedList]  WITH CHECK ADD  CONSTRAINT [FK_ServerTablesLocUsedList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[ServerTablesLocUsedList] CHECK CONSTRAINT [FK_ServerTablesLocUsedList_UserList]
GO
