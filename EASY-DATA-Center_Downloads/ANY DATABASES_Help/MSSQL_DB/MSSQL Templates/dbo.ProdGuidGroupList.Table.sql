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
/****** Object:  Table [dbo].[ProdGuidGroupList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdGuidGroupList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[UserId] [int] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProdGuidGroupList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProdGuidGroupList] ON 

INSERT [dbo].[ProdGuidGroupList] ([Id], [Name], [UserId], [Timestamp]) VALUES (2, N'MIÍCHÁNÍ', 1, CAST(N'2022-11-10T18:55:56.3530000' AS DateTime2))
INSERT [dbo].[ProdGuidGroupList] ([Id], [Name], [UserId], [Timestamp]) VALUES (3, N'STŘÍHÁNÍ', 1, CAST(N'2022-11-10T18:55:56.4330000' AS DateTime2))
INSERT [dbo].[ProdGuidGroupList] ([Id], [Name], [UserId], [Timestamp]) VALUES (4, N'OHRAŇOVÁNÍ', 1, CAST(N'2022-11-10T18:55:56.4670000' AS DateTime2))
INSERT [dbo].[ProdGuidGroupList] ([Id], [Name], [UserId], [Timestamp]) VALUES (5, N'LAKOVÁNÍ', 1, CAST(N'2022-11-10T18:55:56.4970000' AS DateTime2))
INSERT [dbo].[ProdGuidGroupList] ([Id], [Name], [UserId], [Timestamp]) VALUES (6, N'REKLAMACE', 1, CAST(N'2022-11-10T18:55:56.5270000' AS DateTime2))
INSERT [dbo].[ProdGuidGroupList] ([Id], [Name], [UserId], [Timestamp]) VALUES (7, N'KONTROLA', 1, CAST(N'2022-11-10T18:55:56.5600000' AS DateTime2))
INSERT [dbo].[ProdGuidGroupList] ([Id], [Name], [UserId], [Timestamp]) VALUES (8, N'THP', 1, CAST(N'2022-11-10T18:55:56.5900000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProdGuidGroupList] OFF
ALTER TABLE [dbo].[ProdGuidGroupList] ADD  CONSTRAINT [DF_Skupiny_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[ProdGuidGroupList]  WITH CHECK ADD  CONSTRAINT [FK_ProdGuidGroupList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProdGuidGroupList] CHECK CONSTRAINT [FK_ProdGuidGroupList_UserList]
GO
