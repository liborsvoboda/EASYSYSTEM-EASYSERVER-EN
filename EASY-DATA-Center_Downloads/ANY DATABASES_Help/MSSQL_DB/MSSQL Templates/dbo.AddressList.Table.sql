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
/****** Object:  Table [dbo].[AddressList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AddressType] [varchar](20) NOT NULL,
	[CompanyName] [varchar](150) NOT NULL,
	[ContactName] [varchar](150) NULL,
	[Street] [varchar](150) NOT NULL,
	[City] [varchar](150) NOT NULL,
	[PostCode] [varchar](20) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Email] [varchar](150) NULL,
	[BankAccount] [varchar](150) NULL,
	[Ico] [varchar](20) NULL,
	[Dic] [varchar](20) NULL,
	[UserId] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AddressList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AddressList] ON 

INSERT [dbo].[AddressList] ([Id], [AddressType], [CompanyName], [ContactName], [Street], [City], [PostCode], [Phone], [Email], [BankAccount], [Ico], [Dic], [UserId], [Active], [TimeStamp]) VALUES (1, N'all', N'KlikneteZde.Cz', N'Libor Svoboda', N'Žlutava 173', N'Žlutava', N'76361', N'+420724986873', N'libor.svoboda@kliknetezde.cz', N'43-4378530247 / 0100', N'86973681', N'CZ8006295319', 1, 1, CAST(N'2022-12-16T21:46:25.1352671' AS DateTime2))
INSERT [dbo].[AddressList] ([Id], [AddressType], [CompanyName], [ContactName], [Street], [City], [PostCode], [Phone], [Email], [BankAccount], [Ico], [Dic], [UserId], [Active], [TimeStamp]) VALUES (2, N'all', N'GroupWare-Solution.Eu', N'Libor Svoboda', N'Žlutava 173', N'Žlutava', N'76361', N'00420724986873', N'libor.svoboda@kliknetezde.cz', N'43-4378530247 / 0100', N'86973681', N'CZ8006295319', 1, 1, CAST(N'2023-04-14T00:57:22.4310367' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AddressList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AddressList]    Script Date: 03.05.2023 11:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_AddressList] ON [dbo].[AddressList]
(
	[AddressType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AddressList] ADD  CONSTRAINT [DF_AddressList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[AddressList] ADD  CONSTRAINT [DF_AddressList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[AddressList]  WITH CHECK ADD  CONSTRAINT [FK_AddressList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[AddressList] CHECK CONSTRAINT [FK_AddressList_UserList]
GO
