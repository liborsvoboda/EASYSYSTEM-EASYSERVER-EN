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
/****** Object:  Table [dbo].[ProdGuidPersonList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdGuidPersonList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupId] [int] NOT NULL,
	[PersonalNumber] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[SurName] [varchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProdGuidPersonList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProdGuidPersonList] ON 

INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (1, 6, 98, N'Růžena', N'Boháčová', 1, CAST(N'2022-11-11T17:32:19.6570000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (2, 2, 145, N'Jaroslav', N'Pomazal', 1, CAST(N'2022-11-11T17:32:18.6470000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (3, 2, 146, N'Michal', N'Czuczor', 1, CAST(N'2022-11-11T17:32:18.6800000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (4, 2, 290, N'Josef', N'Novotný', 1, CAST(N'2022-11-11T17:32:18.7170000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (5, 2, 295, N'Bohuslav', N'Kovařík', 1, CAST(N'2022-11-11T17:32:18.7530000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (6, 2, 508, N'Eva', N'Kmetíková', 1, CAST(N'2022-11-11T17:32:18.7870000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (7, 4, 628, N'Božena', N'Kosobudová', 1, CAST(N'2022-11-12T17:01:40.1960983' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (8, 3, 1013, N'Lucie', N'Tomšíková', 1, CAST(N'2022-11-11T17:32:19.7230000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (9, 4, 1051, N'Marcel', N'Šebek', 1, CAST(N'2022-11-11T17:32:19.7570000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (10, 5, 1085, N'Norbert', N'Mičiak', 1, CAST(N'2022-11-11T17:32:19.7900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (11, 6, 1089, N'Yvona', N'Seimlová', 1, CAST(N'2022-11-11T17:32:19.8230000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (12, 6, 1094, N'Milan', N'Vongrej', 1, CAST(N'2022-11-11T17:32:19.8570000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (13, 8, 1100, N'Miroslav', N'Hanousek', 1, CAST(N'2022-11-11T17:32:19.8900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (14, 3, 1130, N'Iveta', N'Budišová', 1, CAST(N'2022-11-11T17:32:19.9230000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (15, 5, 1139, N'Josef', N'Fackenberg', 1, CAST(N'2022-11-11T17:32:19.9570000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (16, 7, 1175, N'Rastislav', N'Morávek', 1, CAST(N'2022-11-11T17:32:19.9900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (17, 6, 1247, N'Andrea', N'Peroutková', 1, CAST(N'2022-11-11T17:32:20.0230000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (18, 2, 1248, N'Alena', N'Hrdličková', 1, CAST(N'2022-11-11T17:32:18.8230000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (19, 3, 1249, N'Monika', N'Rytířová', 1, CAST(N'2022-11-11T17:32:20.0570000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (20, 6, 1282, N'Eva', N'Kurzweilová', 1, CAST(N'2022-11-11T17:32:20.0900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (21, 7, 1288, N'Hana', N'Kubálková', 1, CAST(N'2022-11-11T17:32:22.3470000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (22, 3, 1297, N'Pavla', N'Vlčková', 1, CAST(N'2022-11-11T17:32:20.1230000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (23, 3, 1358, N'Monika', N'Jechová', 1, CAST(N'2022-11-11T17:32:20.1530000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (24, 8, 1360, N'Michal', N'Klimeš', 1, CAST(N'2022-11-11T17:32:20.1900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (25, 7, 1385, N'Tereza', N'Prokopová', 1, CAST(N'2022-11-11T17:32:22.4170000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (26, 2, 1406, N'Matěj', N'Stejskal', 1, CAST(N'2022-11-11T17:32:18.8570000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (27, 5, 1432, N'Karel', N'Novotný', 1, CAST(N'2022-11-11T17:32:20.2230000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (28, 4, 1461, N'Iveta', N'Kalinová', 1, CAST(N'2022-11-11T17:32:22.0370000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (29, 7, 1463, N'Pavla', N'Jelínková', 1, CAST(N'2022-11-11T17:32:22.2800000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (30, 8, 1475, N'Renata', N'Jiráčková', 1, CAST(N'2022-11-11T17:32:20.2570000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (31, 8, 1483, N'Kateřina', N'Novotná', 1, CAST(N'2022-11-11T17:32:20.2900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (32, 7, 1524, N'Roman', N'Marek', 1, CAST(N'2022-11-11T17:32:22.3100000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (33, 5, 1531, N'Libuše', N'Nachtmannová', 1, CAST(N'2022-11-11T17:32:20.3230000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (34, 3, 1594, N'Kateřina', N'Hlaváčková', 1, CAST(N'2022-11-11T17:32:21.8730000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (35, 8, 1636, N'Václav', N'Laštovka', 1, CAST(N'2022-11-11T17:32:22.0700000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (36, 6, 1649, N'Monika', N'Šmídová', 1, CAST(N'2022-11-11T17:32:21.6130000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (37, 2, 1664, N'Martin', N'Košárek', 1, CAST(N'2022-11-11T17:32:19.5900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (38, 8, 1667, N'Tomáš', N'Čejka', 1, CAST(N'2022-11-11T17:32:21.9370000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (39, 2, 1673, N'Lucie', N'Jánská', 1, CAST(N'2022-11-11T17:32:19.5600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (40, 2, 1687, N'Jiří', N'Filo', 1, CAST(N'2022-11-11T17:32:19.2930000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (41, 5, 1691, N'Blanka', N'Krumrová', 1, CAST(N'2022-11-11T17:32:22.0030000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (42, 4, 1692, N'Hana', N'Hůlková', 1, CAST(N'2022-11-11T17:32:21.9700000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (43, 3, 1704, N'Tereza', N'Mindlová', 1, CAST(N'2022-11-11T17:32:21.7430000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (44, 2, 1718, N'Renata', N'Šimková', 1, CAST(N'2022-11-11T17:32:19.4600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (45, 7, 1719, N'Petra', N'Marková', 1, CAST(N'2022-11-11T17:32:22.3800000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (46, 3, 1724, N'Barbora', N'Jechová', 1, CAST(N'2022-11-11T17:32:21.7730000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (47, 8, 1725, N'Jana', N'Brůhová', 1, CAST(N'2022-11-11T17:32:22.1000000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (48, 8, 1734, N'Pavel', N'Cílek', 1, CAST(N'2022-11-11T17:32:21.7100000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (49, 6, 1735, N'Jaroslav', N'Mucha', 1, CAST(N'2022-11-11T17:32:21.6770000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (50, 2, 1736, N'Jana', N'Pavlíková', 1, CAST(N'2022-11-11T17:32:19.4930000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (51, 2, 1737, N'Bohdan', N'Saiko', 1, CAST(N'2022-11-11T17:32:19.3930000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (52, 3, 1739, N'Renata', N'Pokorná', 1, CAST(N'2022-11-11T17:32:21.9030000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (53, 4, 1741, N'Erika', N'Kolářová', 1, CAST(N'2022-11-11T17:32:22.2430000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (54, 2, 1742, N'Jan', N'Husák', 1, CAST(N'2022-11-11T17:32:19.3600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (55, 2, 1743, N'Leoš', N'Pěkný', 1, CAST(N'2022-11-11T17:32:19.4270000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (56, 3, 1744, N'Lenka', N'Ševčíková', 1, CAST(N'2022-11-11T17:32:22.2100000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (57, 2, 6170, N'Jaroslav', N'Tománek', 1, CAST(N'2022-11-11T17:32:18.8900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (58, 6, 6198, N'Jana', N'Nováková', 1, CAST(N'2022-11-11T17:32:20.3570000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (59, 4, 9076, N'Ladislav', N'Hajtol', 1, CAST(N'2022-11-11T17:32:20.3900000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (60, 2, 9081, N'Eva', N'Kašová', 1, CAST(N'2022-11-11T17:32:18.9270000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (61, 6, 9113, N'Petra', N'Markvartová', 1, CAST(N'2022-11-11T17:32:20.4270000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (62, 8, 9187, N'Jiří', N'Franěk', 1, CAST(N'2022-11-11T17:32:20.4600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (63, 2, 9191, N'Marie', N'Cicová', 1, CAST(N'2022-11-11T17:32:18.9600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (64, 2, 9328, N'Ladislav', N'Boháč', 1, CAST(N'2022-11-11T17:32:18.9930000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (65, 8, 9333, N'Helena', N'Laszáková', 1, CAST(N'2022-11-11T17:32:20.4930000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (66, 8, 9360, N'Jana', N'Černohorská', 1, CAST(N'2022-11-11T17:32:20.5300000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (67, 5, 9391, N'Blanka', N'Prokopová', 1, CAST(N'2022-11-11T17:32:20.5600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (68, 8, 9451, N'Dalibor', N'Glušica', 1, CAST(N'2022-11-11T17:32:20.5970000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (69, 2, 9481, N'Marek', N'Dřevo', 1, CAST(N'2022-11-11T17:32:19.0300000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (70, 2, 9485, N'Tomáš', N'Berka', 1, CAST(N'2022-11-11T17:32:19.0630000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (71, 8, 9489, N'Miroslav', N'Bočan', 1, CAST(N'2022-11-11T17:32:20.6300000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (72, 5, 9490, N'Jiřina', N'Borkovcová', 1, CAST(N'2022-11-11T17:32:20.6600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (73, 8, 9514, N'Miroslav', N'Kadlec', 1, CAST(N'2022-11-11T17:32:20.6930000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (74, 6, 9529, N'Antonín', N'Procházka', 1, CAST(N'2022-11-11T17:32:20.7270000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (75, 2, 9547, N'Zdeněk', N'Straka', 1, CAST(N'2022-11-11T17:32:19.0970000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (76, 3, 9593, N'Daniela', N'Holá', 1, CAST(N'2022-11-11T17:32:20.7600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (77, 8, 9605, N'Miloš', N'Podhora', 1, CAST(N'2022-11-11T17:32:20.7970000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (78, 3, 9607, N'Martina', N'Samcová', 1, CAST(N'2022-11-11T17:32:20.8270000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (79, 3, 9621, N'Jitka', N'Dvořáková', 1, CAST(N'2022-11-11T17:32:20.8600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (80, 8, 9628, N'Lenka', N'Líkařová', 1, CAST(N'2022-11-11T17:32:20.8930000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (81, 4, 9653, N'Eva', N'Pěknicová', 1, CAST(N'2022-11-11T17:32:20.9530000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (82, 3, 9664, N'Veronika', N'Fraitová', 1, CAST(N'2022-11-11T17:32:22.1370000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (83, 8, 9723, N'Tomáš', N'Houška', 1, CAST(N'2022-11-11T17:32:21.0000000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (84, 3, 9759, N'Dana', N'Sikorová', 1, CAST(N'2022-11-11T17:32:21.0330000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (85, 6, 9766, N'Marta', N'Peroutková', 1, CAST(N'2022-11-11T17:32:21.0670000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (86, 7, 9776, N'Lukáš', N'Saska', 1, CAST(N'2022-11-11T17:32:19.3270000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (87, 8, 9777, N'Petr', N'Jablecki', 1, CAST(N'2022-11-11T17:32:21.1000000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (88, 2, 9780, N'Josef', N'Skalník', 1, CAST(N'2022-11-11T17:32:19.1300000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (89, 2, 9812, N'Aneta', N'Krejčí', 1, CAST(N'2022-11-11T17:32:19.1600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (90, 6, 9814, N'Dana', N'Pecková', 1, CAST(N'2022-11-11T17:32:21.1330000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (91, 8, 9822, N'Romana', N'Procházková', 1, CAST(N'2022-11-11T17:32:21.1670000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (92, 8, 9844, N'Petr', N'Pejša', 1, CAST(N'2022-11-11T17:32:21.2000000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (93, 4, 9853, N'Jaroslav', N'Šimeček', 1, CAST(N'2022-11-11T17:32:21.2330000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (94, 8, 9865, N'Lukáš', N'Kadlec', 1, CAST(N'2022-11-11T17:32:21.2700000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (95, 5, 9902, N'Pavel', N'Nikrýn', 1, CAST(N'2022-11-11T17:32:21.3070000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (96, 8, 9904, N'Petr', N'Tlachač', 1, CAST(N'2022-11-11T17:32:21.3470000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (97, 4, 9926, N'Kristýna', N'Vencláková', 1, CAST(N'2022-11-11T17:32:21.3830000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (98, 8, 9928, N'Aneta', N'Kirilinová', 1, CAST(N'2022-11-11T17:32:21.6430000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (99, 5, 9929, N'Eliška', N'Vracovská', 1, CAST(N'2022-11-11T17:32:21.4170000' AS DateTime2))
GO
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (100, 5, 9940, N'Veronika', N'Hrabánková', 1, CAST(N'2022-11-11T17:32:21.4500000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (101, 8, 9955, N'Vlasta', N'Máchová', 1, CAST(N'2022-11-11T17:32:21.4830000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (102, 3, 9959, N'Milada', N'Hrušková', 1, CAST(N'2022-11-11T17:32:21.5200000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (103, 5, 9962, N'Daniela', N'Hejnicová', 1, CAST(N'2022-11-11T17:32:21.5500000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (104, 2, 800099, N'Stanislav', N'Šelepa', 1, CAST(N'2022-11-11T17:32:19.1970000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (105, 2, 800205, N'Radek', N'Křivánek', 1, CAST(N'2022-11-11T17:32:19.2270000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (106, 5, 800236, N'Milan', N'Daniel', 1, CAST(N'2022-11-11T17:32:21.5800000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (107, 2, 800253, N'Miroslava', N'Juračková', 1, CAST(N'2022-11-11T17:32:19.2600000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (108, 8, 800319, N'Pavla', N'Voborská', 1, CAST(N'2022-11-11T17:32:22.1730000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (109, 8, 800364, N'Jiří', N'Brůha', 1, CAST(N'2022-11-11T17:32:21.8400000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (110, 2, 800370, N'Pavel', N'Doležal', 1, CAST(N'2022-11-11T17:32:19.6200000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (111, 8, 800372, N'Pavel', N'Oulický', 1, CAST(N'2022-11-11T17:32:21.8070000' AS DateTime2))
INSERT [dbo].[ProdGuidPersonList] ([Id], [GroupId], [PersonalNumber], [Name], [SurName], [UserId], [Timestamp]) VALUES (112, 2, 800377, N'Lukáš', N'Petříček', 1, CAST(N'2022-11-11T17:32:19.5270000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProdGuidPersonList] OFF
/****** Object:  Index [IX_ProdGuidPersonList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[ProdGuidPersonList] ADD  CONSTRAINT [IX_ProdGuidPersonList] UNIQUE NONCLUSTERED 
(
	[PersonalNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProdGuidPersonList] ADD  CONSTRAINT [DF_ProdGuidPersonList_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[ProdGuidPersonList]  WITH CHECK ADD  CONSTRAINT [FK_ProdGuidPersonList_ProdGuidGroupList] FOREIGN KEY([GroupId])
REFERENCES [dbo].[ProdGuidGroupList] ([Id])
GO
ALTER TABLE [dbo].[ProdGuidPersonList] CHECK CONSTRAINT [FK_ProdGuidPersonList_ProdGuidGroupList]
GO
ALTER TABLE [dbo].[ProdGuidPersonList]  WITH CHECK ADD  CONSTRAINT [FK_ProdGuidPersonList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProdGuidPersonList] CHECK CONSTRAINT [FK_ProdGuidPersonList_UserList]
GO
