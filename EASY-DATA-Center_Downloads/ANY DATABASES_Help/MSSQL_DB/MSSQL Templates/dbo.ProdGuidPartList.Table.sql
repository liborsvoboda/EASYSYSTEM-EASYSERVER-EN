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
/****** Object:  Table [dbo].[ProdGuidPartList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdGuidPartList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WorkPlace] [int] NOT NULL,
	[Number] [varchar](50) NOT NULL,
	[Name] [varchar](100) NULL,
	[UserId] [int] NOT NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProdGuidPartList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProdGuidPartList] ON 

INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (1, 126, N'7H0 801 253 C', N'Schweller', 1, CAST(N'2022-11-13T07:15:29.0630000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (2, 127, N'7H0 801 254 E', N'Schweller', 1, CAST(N'2022-11-13T07:15:29.1000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (3, 131, N'7J7 809 341 / 2', N'Schliessteil Schweller Hinten', 1, CAST(N'2022-11-13T07:15:29.1300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (4, 131, N'7J7 809 341 / 3', N'Schliessteil Schweller Hinten', 1, CAST(N'2022-11-13T07:15:29.1670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (5, 131, N'7J7 809 341 / 4', N'Schliessteil Schweller Hinten', 1, CAST(N'2022-11-13T07:15:29.1970000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (6, 131, N'7J7 809 341 / 5', N'Schliessteil Schweller Hinten', 1, CAST(N'2022-11-13T07:15:29.2230000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (7, 131, N'7J7 809 341 / 6', N'Schliessteil Schweller Hinten', 1, CAST(N'2022-11-13T07:15:29.2530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (8, 131, N'7J7 809 341 / 7', N'Schliessteil Schweller Hinten', 1, CAST(N'2022-11-13T07:15:29.2800000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (9, 131, N'7J7 809 341 / 8', N'Schliessteil Schweller Hinten', 1, CAST(N'2022-11-13T07:15:29.3100000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (10, 131, N'7J7 809 341 / 9', N'Schliessteil Schweller Hinten', 1, CAST(N'2022-11-13T07:15:29.3430000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (11, 148, N'2K0 827 143 / 4', N'Verstarkung Schloss', 1, CAST(N'2022-11-13T07:15:29.3700000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (12, 174, N'7J1 / 7J3 801 175', N'Abdeckteil Tank', 1, CAST(N'2022-11-13T07:15:29.4000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (13, 174, N'7J1 / 7J3 801 176', N'Abdeckteil Tank', 1, CAST(N'2022-11-13T07:15:29.4300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (14, 183, N'7H3 817 411 / 2', N'Stutzteil Dachrahmen', 1, CAST(N'2022-11-13T07:15:29.4600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (15, 183, N'7H3 817 411 / 3', N'Stutzteil Dachrahmen', 1, CAST(N'2022-11-13T07:15:29.4900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (16, 183, N'7H3 817 411 / 4', N'Stutzteil Dachrahmen', 1, CAST(N'2022-11-13T07:15:29.5170000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (17, 183, N'7H3 817 411 / 5', N'Stutzteil Dachrahmen', 1, CAST(N'2022-11-13T07:15:29.5500000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (18, 183, N'7H3 817 411 / 6', N'Stutzteil Dachrahmen', 1, CAST(N'2022-11-13T07:15:29.5770000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (19, 190, N'7H0 802 821 / 2', N'Saulenfuss', 1, CAST(N'2022-11-13T07:15:29.6070000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (20, 190, N'7H0 802 821 / 3', N'Saulenfuss', 1, CAST(N'2022-11-13T07:15:29.6370000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (21, 190, N'7H0 802 821 / 4', N'Saulenfuss', 1, CAST(N'2022-11-13T07:15:29.6630000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (22, 190, N'7H0 802 821 / 5', N'Saulenfuss', 1, CAST(N'2022-11-13T07:15:29.6900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (23, 190, N'7H0 802 821 / 6', N'Saulenfuss', 1, CAST(N'2022-11-13T07:15:29.7200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (24, 190, N'7H0 802 821 / 7', N'Saulenfuss', 1, CAST(N'2022-11-13T07:15:29.8870000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (25, 190, N'7H0 802 821 / 8', N'Saulenfuss', 1, CAST(N'2022-11-13T07:15:29.9170000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (26, 190, N'7H0 802 821 / 9', N'Saulenfuss', 1, CAST(N'2022-11-13T07:15:29.9430000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (27, 209, N'7H3 817 824 A', N'Eckverstarkung Saule C', 1, CAST(N'2022-11-13T07:15:29.9770000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (28, 263, N'101', N'Vícepráce', 1, CAST(N'2022-11-13T07:15:30.0070000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (29, 263, N'úklid + vícepráce', N'úklid', 1, CAST(N'2022-11-13T07:15:30.0370000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (30, 265, N'zácvik + opravy + seřizování', N'zácvik', 1, CAST(N'2022-11-13T07:15:30.0670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (31, 267, N'100 % kontrola', N'100 % kontrola', 1, CAST(N'2022-11-13T07:15:30.0930000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (32, 274, N'1S3 831 615 / 6', N'', 1, CAST(N'2022-11-13T07:15:30.1270000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (33, 276, N'S058 10 757 B', N'Tragerblech F34', 1, CAST(N'2022-11-13T07:15:30.1570000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (34, 286, N'AS4 833 621 / 2', N'', 1, CAST(N'2022-11-13T07:15:30.1900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (35, 300, N'991.355.509.01 / 10', N'Z Halter', 1, CAST(N'2022-11-13T07:15:30.2200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (36, 301, N'1S0 810 121 / 2', N'', 1, CAST(N'2022-11-13T07:15:30.2500000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (37, 306, N'1S6 817 161 A', N'', 1, CAST(N'2022-11-13T07:15:30.2800000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (38, 308, N'5G6 813 323', N'', 1, CAST(N'2022-11-13T07:15:30.3100000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (39, 310, N'2H7 809 621 / 2 B', N'', 1, CAST(N'2022-11-13T07:15:35.2670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (40, 311, N'2H7 809 623 / 4 B', N'', 1, CAST(N'2022-11-13T07:15:35.3000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (41, 312, N'2H7 810 521 / 2 B', N'', 1, CAST(N'2022-11-13T07:15:35.3300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (42, 313, N'5G9 813 323', N'', 1, CAST(N'2022-11-13T07:15:35.3630000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (43, 320, N'12E 906 109', N'ZSB Halter Ladegerat', 1, CAST(N'2022-11-13T07:15:35.3970000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (44, 324, N'4T0 802 443 / 3', N'', 1, CAST(N'2022-11-13T07:15:35.4230000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (45, 329, N'12E 971 846 A', N'Halter Ladedose Combo 2', 1, CAST(N'2022-11-13T07:15:35.4530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (46, 331, N'12E 971 496 D', N'Aufnahme Trager TNS', 1, CAST(N'2022-11-13T07:15:35.4870000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (47, 332, N'12E 906 131 J', N'ZSB Halter MSG', 1, CAST(N'2022-11-13T07:15:35.5170000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (48, 333, N'12E 906 131 - 1', N'', 1, CAST(N'2022-11-13T07:15:35.5470000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (49, 335, N'12E 906 131  J - UNL', N'ZSB Halter MSG', 1, CAST(N'2022-11-13T07:15:35.5730000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (50, 337, N'9P1.817.465', N'Quertrager Dach.', 1, CAST(N'2022-11-13T07:15:35.6070000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (51, 339, N'9P1.810.883 / 4 / 9P1.809.791 / 2', N'', 1, CAST(N'2022-11-13T07:15:35.6370000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (52, 339, N'9P1.810.883 / 4 / 9P1.809.791 / 3', N'', 1, CAST(N'2022-11-13T07:15:35.6670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (53, 340, N'991.502.745 / 6', N'', 1, CAST(N'2022-11-13T07:15:35.6970000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (54, 341, N'9P1.817.551', N'', 1, CAST(N'2022-11-13T07:15:35.7270000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (55, 342, N'991.502.811 / 2', N'Dichtungsflansch', 1, CAST(N'2022-11-13T07:15:35.7600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (56, 344, N'5G0 906 468 A', N'Halter Impulsgeber', 1, CAST(N'2022-11-13T07:15:35.7900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (57, 349, N'95B 802 291 A', N'SGR Verst. Hisi Mitte', 1, CAST(N'2022-11-13T07:15:35.8230000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (58, 350, N'95B 803 135 A - li', N'', 1, CAST(N'2022-11-13T07:15:35.8530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (59, 351, N'95B 803 136 A - re', N'', 1, CAST(N'2022-11-13T07:15:35.8870000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (60, 352, N'95B 803 357 - li', N'SGR Aufnahme Domstrebe', 1, CAST(N'2022-11-13T07:15:35.9130000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (61, 353, N'95B 803 358 - re', N'SGR Aufnahme Domstrebe', 1, CAST(N'2022-11-13T07:15:35.9430000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (62, 354, N'95B 805 029 - li', N'SGR Schliesteil Verbindung', 1, CAST(N'2022-11-13T07:15:35.9730000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (63, 355, N'95B 805 030 - re', N'SGR Schliesteil Verbindung', 1, CAST(N'2022-11-13T07:15:36.0070000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (64, 356, N'95B 805 197 - li', N'', 1, CAST(N'2022-11-13T07:15:36.0370000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (65, 357, N'95B 805 198 - re', N'', 1, CAST(N'2022-11-13T07:15:36.0670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (66, 359, N'95B 805 203 - HF', N'SGR Verbindungsteil', 1, CAST(N'2022-11-13T07:15:36.0970000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (67, 360, N'95B 805 303 - li', N'SGR Verbindungsteil', 1, CAST(N'2022-11-13T07:15:36.1270000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (68, 361, N'95B 805 204 - HF', N'', 1, CAST(N'2022-11-13T07:15:36.1570000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (69, 362, N'95B 805 304 - re', N'SGR Verbindungsteil', 1, CAST(N'2022-11-13T07:15:36.1870000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (70, 363, N'95B 805 323 A', N'', 1, CAST(N'2022-11-13T07:15:36.2200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (71, 364, N'95B 805 324 A', N'', 1, CAST(N'2022-11-13T07:15:36.2500000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (72, 365, N'95B 805 331 - li', N'', 1, CAST(N'2022-11-13T07:15:36.2770000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (73, 366, N'95B 805 332 - re', N'', 1, CAST(N'2022-11-13T07:15:36.3070000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (74, 367, N'95B 805 479 F', N'', 1, CAST(N'2022-11-13T07:15:36.3370000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (75, 368, N'95B 805 479 G', N'', 1, CAST(N'2022-11-13T07:15:36.3670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (76, 369, N'95B 806 635 C', N'', 1, CAST(N'2022-11-13T07:15:36.3930000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (77, 370, N'95B 806 636 C', N'', 1, CAST(N'2022-11-13T07:15:36.4300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (78, 371, N'95B 807 333 - li', N'Schlossstutze ECE', 1, CAST(N'2022-11-13T07:15:36.4600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (79, 372, N'95B 807 334 - re', N'Schlossstutze ECE', 1, CAST(N'2022-11-13T07:15:36.4900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (80, 373, N'95B 807 333 A - li', N'Schlossstutze NAFTA', 1, CAST(N'2022-11-13T07:15:36.5200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (81, 374, N'95B 807 334 A - re', N'Schlossstutze NAFTA', 1, CAST(N'2022-11-13T07:15:36.5500000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (82, 375, N'95B 809 137 - li', N'SGR Knotenteil Saule D', 1, CAST(N'2022-11-13T07:15:36.5770000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (83, 376, N'95B 809 138 - re', N'SGR Knotenteil Saule D', 1, CAST(N'2022-11-13T07:15:36.6070000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (84, 377, N'95B 809 293 A - li', N'', 1, CAST(N'2022-11-13T07:15:36.6400000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (85, 378, N'95B 809 294 A - re', N'', 1, CAST(N'2022-11-13T07:15:36.6700000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (86, 379, N'95B 809 223 - HF', N'', 1, CAST(N'2022-11-13T07:15:36.7000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (87, 380, N'95B 809 443 - li', N'SGR Saule B innen', 1, CAST(N'2022-11-13T07:15:36.7270000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (88, 381, N'95B 809 224 - HF', N'', 1, CAST(N'2022-11-13T07:15:36.7570000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (89, 382, N'95B 809 444 - re', N'SGR Saule B innen', 1, CAST(N'2022-11-13T07:15:36.7870000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (90, 383, N'95B 809 573 A- li', N'SGR Bef. Kotflugel', 1, CAST(N'2022-11-13T07:15:36.8170000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (91, 384, N'95B 809 574 B - re', N'SGR Bef. Kotflugel', 1, CAST(N'2022-11-13T07:15:36.8530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (92, 385, N'95B 810 209 A - li', N'SGR Scharnierverst. Saule', 1, CAST(N'2022-11-13T07:15:36.8800000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (93, 386, N'95B 810 210 A - re', N'SGR Scharnierverst. Saule', 1, CAST(N'2022-11-13T07:15:36.9100000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (94, 387, N'95B 823 401 - li', N'', 1, CAST(N'2022-11-13T07:15:36.9400000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (95, 388, N'95B 823 402 - re', N'', 1, CAST(N'2022-11-13T07:15:36.9700000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (96, 395, N'8S7 813 123 / 4', N'Schliesteil Boden Seitlich', 1, CAST(N'2022-11-13T07:15:37.0000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (97, 395, N'8S7 813 123 / 5', N'Schliesteil Boden Seitlich', 1, CAST(N'2022-11-13T07:15:37.0300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (98, 395, N'8S7 813 123 / 6', N'Schliesteil Boden Seitlich', 1, CAST(N'2022-11-13T07:15:37.0600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (99, 395, N'8S7 813 123 / 7', N'Schliesteil Boden Seitlich', 1, CAST(N'2022-11-13T07:15:37.0900000' AS DateTime2))
GO
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (100, 399, N'8S0 821 431 / 2 A', N'Halter Kotflugel li + re', 1, CAST(N'2022-11-13T07:15:37.1200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (101, 400, N'8S0 821 263 / 4', N'Strebe Halter', 1, CAST(N'2022-11-13T07:15:37.1530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (102, 401, N'8S0 821 131 / 2', N'G Strebe KTF', 1, CAST(N'2022-11-13T07:15:37.1870000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (103, 407, N'9P1.817.889', N'Verst. Quertrager', 1, CAST(N'2022-11-13T07:15:37.2170000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (104, 409, N'9P1.810.493', N'Z Schliesteil', 1, CAST(N'2022-11-13T07:15:37.2530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (105, 410, N'9P1.810.491', N'', 1, CAST(N'2022-11-13T07:15:37.2830000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (106, 411, N'95B 821 109 / 110 B', N'', 1, CAST(N'2022-11-13T07:15:37.3130000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (107, 412, N'95B 821 103 C / 104 B', N'', 1, CAST(N'2022-11-13T07:15:37.3430000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (108, 413, N'95B 805 479 G / F', N'', 1, CAST(N'2022-11-13T07:15:37.3700000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (109, 414, N'8S8 809 325 / 6 A', N'', 1, CAST(N'2022-11-13T07:15:37.4000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (110, 415, N'8S8 809 695 / 6 A', N'Verst. Konsole Gurt. li/re', 1, CAST(N'2022-11-13T07:15:37.4300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (111, 416, N'8S8 509 507 / 8', N'Konsole Gurtautomat', 1, CAST(N'2022-11-13T07:15:37.4600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (112, 417, N'8W1 / 2 805 323', N'', 1, CAST(N'2022-11-13T07:15:37.4930000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (113, 418, N'4S0 802 443 / 4 B', N'', 1, CAST(N'2022-11-13T07:15:37.5200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (114, 419, N'4S0 805 063 B / 064 C', N'', 1, CAST(N'2022-11-13T07:15:37.5500000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (115, 420, N'4S0 821 085 / 6 - 111 / 2', N'', 1, CAST(N'2022-11-13T07:15:37.5800000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (116, 421, N'4S8 802 123 / 4', N'', 1, CAST(N'2022-11-13T07:15:37.6100000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (117, 422, N'4S8 803 448 B', N'', 1, CAST(N'2022-11-13T07:15:37.6400000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (118, 423, N'4S0 803 119 / 120 B', N'Verstärkung Fanghaken', 1, CAST(N'2022-11-13T07:15:37.6700000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (119, 424, N'3Q0 803 961', N'', 1, CAST(N'2022-11-13T07:15:37.7000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (120, 431, N'2K5 810 333 / 4', N'', 1, CAST(N'2022-11-13T07:15:37.7300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (121, 432, N'2K5 821 135', N'', 1, CAST(N'2022-11-13T07:15:37.7630000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (122, 433, N'2K5 821 136', N'', 1, CAST(N'2022-11-13T07:15:37.7900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (123, 434, N'5TA 823 413', N'', 1, CAST(N'2022-11-13T07:15:37.8200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (124, 435, N'5TA 809 761 / 2', N'', 1, CAST(N'2022-11-13T07:15:37.8470000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (125, 436, N'5TA 809 443 / 4', N'SGR Saule B innen', 1, CAST(N'2022-11-13T07:15:37.8800000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (126, 437, N'5TA 817 770', N'Fuhrungschiene', 1, CAST(N'2022-11-13T07:15:37.9200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (127, 438, N'5TA 817 680', N'', 1, CAST(N'2022-11-13T07:15:37.9530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (128, 442, N'6R0 802 955', N'', 1, CAST(N'2022-11-13T07:15:37.9870000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (129, 444, N'4S8 201 260 A', N'', 1, CAST(N'2022-11-13T07:15:38.0170000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (130, 446, N'1 264 477', N'', 1, CAST(N'2022-11-13T07:15:38.0500000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (131, 447, N'1 264 476', N'', 1, CAST(N'2022-11-13T07:15:38.0830000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (132, 449, N'8W0 / 8W6 821 433 / 4 / B', N'', 1, CAST(N'2022-11-13T07:15:38.1130000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (133, 450, N'4M0 820 196 F', N'', 1, CAST(N'2022-11-13T07:15:38.1430000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (134, 451, N'4M0 820 196 G', N'', 1, CAST(N'2022-11-13T07:15:38.1730000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (135, 455, N'8W0 809 075 / 6 A', N'', 1, CAST(N'2022-11-13T07:15:38.2030000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (136, 456, N'95B 817 122 A / B / C', N'', 1, CAST(N'2022-11-13T07:15:38.2300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (137, 457, N'95B 817 123 A', N'', 1, CAST(N'2022-11-13T07:15:38.2600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (138, 458, N'95B 817 899 / 900', N'', 1, CAST(N'2022-11-13T07:15:38.2900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (139, 460, N'2N0 802 313 / 4', N'', 1, CAST(N'2022-11-13T07:15:38.3200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (140, 461, N'2N0 803 697', N'SGR Verst. Sitzbefestigung', 1, CAST(N'2022-11-13T07:15:38.3500000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (141, 462, N'2N0 803 689 A', N'', 1, CAST(N'2022-11-13T07:15:38.3800000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (142, 463, N'2N2 721 882', N'', 1, CAST(N'2022-11-13T07:15:38.4100000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (143, 464, N'2N2 721 693', N'SGR Halter Gaspedalmodul', 1, CAST(N'2022-11-13T07:15:38.4400000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (144, 465, N'7C0 807 953 / 4 A', N'ZSB Verbindungsteil', 1, CAST(N'2022-11-13T07:15:38.4700000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (145, 468, N'4K1 / 2 805 323', N'', 1, CAST(N'2022-11-13T07:15:38.4970000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (146, 469, N'4K0 802 683', N'', 1, CAST(N'2022-11-13T07:15:38.5270000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (147, 471, N'95B 265 093', N'Z Verstärkung', 1, CAST(N'2022-11-13T07:15:38.5670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (148, 472, N'81A 809 075 B  / 076 B', N'', 1, CAST(N'2022-11-13T07:15:38.6000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (149, 474, N'7C0 843 293 / 4', N'', 1, CAST(N'2022-11-13T07:15:38.6330000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (150, 475, N'7C0 843 291 / 2', N'ZSB Verstarkung', 1, CAST(N'2022-11-13T07:15:38.6670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (151, 476, N'7C0 843 285 / 6', N'ZSB Verstarkung', 1, CAST(N'2022-11-13T07:15:38.7000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (152, 477, N'7C0 843 521 / 2', N'', 1, CAST(N'2022-11-13T07:15:38.7300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (153, 478, N'2N0 802 783 C', N'', 1, CAST(N'2022-11-13T07:15:38.7700000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (154, 479, N'2N0 802 783 B', N'SGR Traverse Reserverad', 1, CAST(N'2022-11-13T07:15:38.8000000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (155, 480, N'2N0 802 783 E', N'SGR Traverse Reserverad', 1, CAST(N'2022-11-13T07:15:38.8300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (156, 481, N'2NA 801 939', N'', 1, CAST(N'2022-11-13T07:15:38.8600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (157, 482, N'2NA 801 939 A', N'', 1, CAST(N'2022-11-13T07:15:38.8870000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (158, 483, N'7C0 843 321 / 2', N'', 1, CAST(N'2022-11-13T07:15:38.9170000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (159, 484, N'7C0 821 149 /150', N'', 1, CAST(N'2022-11-13T07:15:38.9430000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (160, 485, N'7C3 843 295 / 6', N'', 1, CAST(N'2022-11-13T07:15:38.9770000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (161, 486, N'7C3 843 219 / 220', N'', 1, CAST(N'2022-11-13T07:15:39.0030000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (162, 487, N'7C0 810 199 / 200 A', N'', 1, CAST(N'2022-11-13T07:15:39.0300000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (163, 488, N'7C0 810 121 / 2 E', N'', 1, CAST(N'2022-11-13T07:15:39.0600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (164, 489, N'2N0 804 145 / 6 B', N'', 1, CAST(N'2022-11-13T07:15:39.0900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (165, 490, N'7C0 843 577', N'Verstärkung Anschlagpuffer', 1, CAST(N'2022-11-13T07:15:39.1200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (166, 491, N'7C0 843 223', N'', 1, CAST(N'2022-11-13T07:15:39.1470000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (167, 492, N'7C0 843 578', N'Verstärkung Anschlagpuffer', 1, CAST(N'2022-11-13T07:15:39.1770000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (168, 493, N'7C0 843 224', N'', 1, CAST(N'2022-11-13T07:15:39.2070000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (169, 494, N'7C0 810 297 / 8 A', N'SGR Halter Dachquerträger', 1, CAST(N'2022-11-13T07:15:39.2400000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (170, 495, N'7C0 863 253 / 4 B', N'Halter Dachquerträger', 1, CAST(N'2022-11-13T07:15:39.2670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (171, 496, N'7C0 810 351 / 2', N'', 1, CAST(N'2022-11-13T07:15:39.2970000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (172, 497, N'7C0 827 467', N'', 1, CAST(N'2022-11-13T07:15:39.3270000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (173, 498, N'7C0 880 571 / 2', N'', 1, CAST(N'2022-11-13T07:15:39.3530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (174, 499, N'7C3 843 291 / 2', N'', 1, CAST(N'2022-11-13T07:15:39.3830000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (175, 500, N'1 205 842', N'Mechanik T5', 1, CAST(N'2022-11-13T07:15:39.4170000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (176, 502, N'3C2 721 187C', N'ZSB-Halter Gaspedal +100% kontrola', 1, CAST(N'2022-11-13T07:15:39.4470000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (177, 508, N'4S0 803 448B', N'G Befestigungsbock Sitz', 1, CAST(N'2022-11-13T07:15:39.4770000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (178, 509, N'4M0 880 695/696', N'Deformationselement', 1, CAST(N'2022-11-13T07:15:39.5030000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (179, 510, N'8W0 880 667/668', N'Defo element', 1, CAST(N'2022-11-13T07:15:39.5330000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (180, 512, N'1 210 177', N'Mechanik Kisi VW 428', 1, CAST(N'2022-11-13T07:15:39.5630000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (181, 513, N'7C0 843 242', N'ZSB Verrstärkung', 1, CAST(N'2022-11-13T07:15:39.5930000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (182, 514, N'7C0 843 241', N'ZSB Verrstärkung', 1, CAST(N'2022-11-13T07:15:39.6270000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (183, 515, N'7C0 810 121D', N'SGR Schliessteil', 1, CAST(N'2022-11-13T07:15:39.6530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (184, 516, N'7C0 810 122D', N'SGR Schliessteil', 1, CAST(N'2022-11-13T07:15:39.6830000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (185, 517, N'9P1 810 455', N'Z Schliesblech', 1, CAST(N'2022-11-13T07:15:39.7130000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (186, 519, N'7C0807953/954', N'Verbindungsteil Hilfshramen', 1, CAST(N'2022-11-13T07:15:39.7470000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (187, 520, N' 5NN867891B', N'ZSB Halter li', 1, CAST(N'2022-11-13T07:15:39.7730000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (188, 521, N'5NN867892A', N'ZSB Halter re', 1, CAST(N'2022-11-13T07:15:39.8030000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (189, 522, N'1340000', N'Kisi Mechanik BR213', 1, CAST(N'2022-11-13T07:15:39.8370000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (190, 523, N'4M0 820 196G', N'ZSB 4er Ventilblock Platte unte', 1, CAST(N'2022-11-13T07:15:39.8670000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (191, 524, N'4M0 820 196F', N'ZSB Halter 4er VB Platte oben', 1, CAST(N'2022-11-13T07:15:39.8970000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (192, 525, N'4M1820196E', N'ZSB Halter Chiller LL', 1, CAST(N'2022-11-13T07:15:39.9270000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (193, 527, N' 4M2820196D', N'Z Halter Chiller RL', 1, CAST(N'2022-11-13T07:15:39.9570000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (194, 534, N'1 313 940', N'ZSB Kisi Mechanik    VW 378', 1, CAST(N'2022-11-13T07:15:39.9900000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (195, 534, N'1313940', N'ZSB Kisi Mechanik    VW 378', 1, CAST(N'2022-11-13T07:15:40.0200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (196, 538, N'8W9 864 199 / 200', N'', 1, CAST(N'2022-11-13T07:16:37.8600000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (197, 539, N'2K0 827 143 / 4', N'Verstarkung Schloss', 1, CAST(N'2022-11-13T07:16:37.9200000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (198, 539, N'7H0 801 254 E', N'', 1, CAST(N'2022-11-13T07:16:37.9530000' AS DateTime2))
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (199, 540, N'975 809 877 / 8 B', N'', 1, CAST(N'2022-11-13T07:16:37.9870000' AS DateTime2))
GO
INSERT [dbo].[ProdGuidPartList] ([Id], [WorkPlace], [Number], [Name], [UserId], [Timestamp]) VALUES (200, 541, N'975 813 351 / 2 A', N'', 1, CAST(N'2022-11-13T07:16:38.0170000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProdGuidPartList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ProdGuidPartList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[ProdGuidPartList] ADD  CONSTRAINT [IX_ProdGuidPartList] UNIQUE NONCLUSTERED 
(
	[WorkPlace] ASC,
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProdGuidPartList] ADD  CONSTRAINT [DF_PartList_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[ProdGuidPartList]  WITH CHECK ADD  CONSTRAINT [FK_ProdGuidPartList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProdGuidPartList] CHECK CONSTRAINT [FK_ProdGuidPartList_UserList]
GO
