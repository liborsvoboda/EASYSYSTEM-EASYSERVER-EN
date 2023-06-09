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
/****** Object:  Table [dbo].[ParameterList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParameterList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[SystemName] [varchar](50) NOT NULL,
	[Value] [varchar](50) NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[Description] [text] NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ParameterList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ParameterList] ON 

INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (10, 1, N'DocumentVatPriceFormat', N'N0', N'string', N'Example N0  -  without decimal numbers, N2 -  with 2 decimal numbers 0.00

https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings', CAST(N'2022-12-15T19:09:13.4175895' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (11, 1, N'ItemVatPriceFormat', N'N2', N'string', N'Example N0  -  without decimal numbers, N2 -  with 2 decimal numbers 0.00

https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings', CAST(N'2022-12-15T19:09:19.5968360' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (12, 1, N'DocumentRowHeight', N'50', N'int', N'25- standard line,50 - show address, 150 - show full adddress', CAST(N'2023-04-14T09:18:29.2160793' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (13, NULL, N'DocumentVatPriceFormat', N'N0', N'string', N'Example N0  -  without decimal numbers, N2 -  with 2 decimal numbers 0.00', CAST(N'2023-02-14T07:31:42.6400000' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (15, NULL, N'ItemVatPriceFormat', N'N2', N'string', N'Example N0  -  without decimal numbers, N2 -  with 2 decimal numbers 0.00', CAST(N'2023-02-14T07:31:55.9200000' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (17, NULL, N'DocumentRowHeight', N'50', N'int', N'25- standard line,50 - show address, 150 - show full adddress', CAST(N'2023-02-08T11:06:07.7800000' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (18, NULL, N'ReportSqlRowHeight', N'25', N'int', N'25- standard line,50 - show address', CAST(N'2023-02-17T00:19:31.2533333' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (19, 1, N'ReportSqlRowHeight', N'50', N'int', N'25- standard line,50 - show address', CAST(N'2023-04-14T09:20:11.0989025' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (20, NULL, N'DataViewsShowDateFormat', N'dd.MM.yyyy', N'dateFormat', N'dd - days
MM - Month
yyyy- yea
dd/MM/yyyy hh:mm:ss, dd.MM.yyyy hh:mm:ss', CAST(N'2023-04-14T14:15:46.4833333' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (26, NULL, N'ReportSupportForListOnly', N'true', N'bit', NULL, CAST(N'2023-04-14T21:07:51.8266667' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (27, 1, N'ReportSupportForListOnly', N'true', N'bit', NULL, CAST(N'2023-04-14T21:08:12.6600000' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (28, NULL, N'DeactivateIgnoredException', N'false', N'bit', N'This deacivate All Ignored exceptions for onetime full monitoring system Fails', CAST(N'2023-04-29T10:42:23.6566667' AS DateTime2))
INSERT [dbo].[ParameterList] ([Id], [UserId], [SystemName], [Value], [Type], [Description], [TimeStamp]) VALUES (29, 1, N'DeactivateIgnoredException', N'true', N'bit', N'This deacivate All Ignored exceptions for onetime full monitoring system Fails', CAST(N'2023-04-29T21:37:41.6353253' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ParameterList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ParameterList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[ParameterList] ADD  CONSTRAINT [IX_ParameterList] UNIQUE NONCLUSTERED 
(
	[SystemName] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ParameterList] ADD  CONSTRAINT [DF_ParameterList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[ParameterList]  WITH CHECK ADD  CONSTRAINT [FK_ParameterList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[ParameterList] CHECK CONSTRAINT [FK_ParameterList_UserList]
GO
