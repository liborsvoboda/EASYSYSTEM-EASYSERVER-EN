USE [GLOBALNET]
GO
/****** Object:  Table [dbo].[ParameterList]    Script Date: 12.03.2023 15:43:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParameterList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[Parameter] [varchar](50) NOT NULL,
	[Value] [varchar](50) NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[Description] [text] NULL,
	[Active] [bit] NOT NULL,
	[TimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ParameterList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_ParameterList] UNIQUE NONCLUSTERED 
(
	[Parameter] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ParameterList] ADD  CONSTRAINT [DF_ParameterList_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[ParameterList] ADD  CONSTRAINT [DF_ParameterList_TimeStamp]  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[ParameterList]  WITH CHECK ADD  CONSTRAINT [FK_ParameterList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[ParameterList] CHECK CONSTRAINT [FK_ParameterList_UserList]
GO
