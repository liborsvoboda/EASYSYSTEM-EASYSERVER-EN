USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[AddressList]    Script Date: 12.03.2023 15:37:54 ******/
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
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AddressList]    Script Date: 12.03.2023 15:37:54 ******/
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
