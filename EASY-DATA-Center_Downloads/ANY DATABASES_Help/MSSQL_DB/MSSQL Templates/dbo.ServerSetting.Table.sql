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
/****** Object:  Table [dbo].[ServerSetting]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServerSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Key] [nvarchar](150) NOT NULL,
	[Value] [nvarchar](150) NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_AdminConfiguration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ServerSetting] ON 

INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (2, N'ConfigServerStartupPort', N'7000', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (4, N'EmailerServiceEmailAddress', N'Libor.Svoboda@GroupWare-Solution.Eu', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (5, N'EmailerSMTPServerAddress', N'imap.groupware-solution.eu', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (6, N'EmailerSMTPPort', N'25', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (7, N'EmailerSMTPLoginUsername', N'backendsolution@groupware-solution.eu', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (8, N'EmailerSMTPLoginPassword', N'kuK7VzrU@V', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (9, N'ConfigJwtLocalKey', N'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (10, N'ConfigWebSocketTimeoutMin', N'2', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (11, N'ConfigMaxWebSocketBufferSizeKb', N'10', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (12, N'ServerTimeTokenValidationEnabled', N'False', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (13, N'ConfigApiTokenTimeoutMin', N'20', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (14, N'ConfigServerStartupOnHttps', N'False', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (15, N'ConfigCertificateDomain', N'127.0.0.1', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (16, N'ConfigCertificatePassword', N'password', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (17, N'DatabaseInternalCachingEnabled', N'True', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (18, N'DatabaseInternalCacheTimeoutMin', N'30', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (19, N'ModuleSwaggerApiDocEnabled', N'True', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (21, N'ModuleDataManagerEnabled', N'True', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (22, N'ModuleHealthServiceEnabled', N'False', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (23, N'SpecialUseDbLocalAutoupdatedDials', N'True', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (24, N'AutoDBHistoryLogList', N'True', CAST(N'2023-04-30T08:35:02.4033333' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (25, N'SpecialServerServiceName', N'EASYDATACenter', CAST(N'2023-05-02T14:47:36.3466667' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (26, N'EmailerSMTPSslIsEnabled', N'false', CAST(N'2023-05-02T14:50:18.5800000' AS DateTime2), 1)
INSERT [dbo].[ServerSetting] ([Id], [Key], [Value], [Timestamp], [Active]) VALUES (28, N'SpecialCoreCheckerEmailSenderActive', N'false', CAST(N'2023-05-02T14:52:28.5600000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[ServerSetting] OFF
ALTER TABLE [dbo].[ServerSetting] ADD  CONSTRAINT [DF_AdminConfiguration_CreateDate]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[ServerSetting] ADD  CONSTRAINT [DF_AdminConfiguration_Active]  DEFAULT ((1)) FOR [Active]
GO
