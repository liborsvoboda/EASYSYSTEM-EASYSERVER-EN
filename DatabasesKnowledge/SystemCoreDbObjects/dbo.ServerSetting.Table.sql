USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[ServerSetting]    Script Date: 12.03.2023 15:43:40 ******/
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
ALTER TABLE [dbo].[ServerSetting] ADD  CONSTRAINT [DF_AdminConfiguration_CreateDate]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[ServerSetting] ADD  CONSTRAINT [DF_AdminConfiguration_Active]  DEFAULT ((1)) FOR [Active]
GO
