USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[UserRoleList]    Script Date: 12.03.2023 15:43:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoleList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Description] [text] NULL,
	[Active] [bit] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserRoleList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserRoleList] ADD  CONSTRAINT [DF_UserRoleList_active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[UserRoleList] ADD  CONSTRAINT [DF_UserRoleList_timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
