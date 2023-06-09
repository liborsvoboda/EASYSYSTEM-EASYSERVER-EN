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
/****** Object:  Table [dbo].[LanguageList]    Script Date: 03.05.2023 11:24:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SystemName] [varchar](50) NOT NULL,
	[DescriptionCz] [varchar](250) NOT NULL,
	[DescriptionEn] [varchar](250) NOT NULL,
	[UserId] [int] NULL,
	[Timestamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LanguageList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LanguageList] ON 

INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (1, N'manager', N'manažer', N'Manager', 1, CAST(N'2023-03-29T02:10:35.8538411' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (2, N'offer', N'Nabídka', N'Offer', 1, CAST(N'2023-03-29T04:17:47.7092259' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (3, N'outgoingOrder', N'outgoingOrder', N'outgoingOrder', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (4, N'incomingOrder', N'incomingOrder', N'incomingOrder', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (5, N'outgoingInvoice', N'outgoingInvoice', N'outgoingInvoice', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (6, N'incomingInvoice', N'incomingInvoice', N'incomingInvoice', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (7, N'creditNote', N'creditNote', N'creditNote', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (8, N'receipt', N'receipt', N'receipt', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (9, N'ServerRunning', N'Server je v Provozu', N'Server is Running', 1, CAST(N'2023-04-17T00:15:05.9110258' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (11, N'Dynamic Touch System', N'Dynamický Dotykový Systém', N'Dynamic Touch System', 1, CAST(N'2023-04-12T22:59:13.5053222' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (12, N'Each day New Agenda', N'Každý Den nová Agenda', N'Each day New Agenda', 1, CAST(N'2023-04-12T22:59:34.2895493' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (13, N'Perfectly customized System', N'Neomezeně Modifikovatelný Systém', N'Perfectly customized System', 1, CAST(N'2023-04-12T23:00:22.1905520' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (14, N'Future Touch System', N'Dotykový Systém Budoucnosti', N'Future Touch System', 1, CAST(N'2023-04-12T23:00:43.3224403' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (15, N'Modern Way for your Businnes', N'Moderní Cesta Vašeho Businnesu', N'Modern Way for your Businnes', 1, CAST(N'2023-04-12T23:01:15.8319727' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (16, N'Fast Deployment', N'Rychlá Nasazení Změn', N'Fast Deployment', 1, CAST(N'2023-04-12T23:01:37.7128429' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (17, N'High Performance', N'Vysoký Výkon', N'High Performance', 1, CAST(N'2023-04-12T23:01:49.0647368' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (18, N'Supported by Open World Commnity', N'Podporováno OpenSource Komunitou', N'Supported by Open World Commnity', 1, CAST(N'2023-04-12T23:02:14.9842052' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (19, N'Each Click is Optimized', N'Každý Klik je Optimalizován', N'Each Click is Optimized', 1, CAST(N'2023-04-12T23:02:40.3763427' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (20, N'Never Waiting for Feature', N'Nikdy Nečekáte na Novinky', N'Never Waiting for Feature', 1, CAST(N'2023-04-12T23:03:04.1821871' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (21, N'Developing by Own IT Team', N'Vývoj Vlastním IT Týmem', N'Developing by Own IT Team', 1, CAST(N'2023-04-12T23:03:27.0704932' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (22, N'Limited by Idea Only', N'Limitováno pouze Nápady', N'Limited by Idea Only', 1, CAST(N'2023-04-12T23:04:03.6865579' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (23, N'Take a Step Every Day', N'Udělejte Krok Každý Den', N'Take a Step Every Day', 1, CAST(N'2023-04-12T23:04:23.2080161' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (24, N'High Operability', N'Vysoká Operatibilita', N'High Operability', 1, CAST(N'2023-04-12T23:04:39.5273654' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (25, N'Without Limitations', N'Bez Limitů', N'Without Limitations', 1, CAST(N'2023-04-12T23:04:53.5429902' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (26, N'Designed for Each User', N'Design pro Každého Uživatele', N'Designed for Each User', 1, CAST(N'2023-04-12T23:05:15.8634359' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (27, N'All Features Are Possible', N'Všechny Novinky jsou Možné', N'All Features Are Possible', 1, CAST(N'2023-04-12T23:05:37.7425391' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (28, N'Limit is Only Human Idea', N'Limitem je pouze Vize Člověka', N'Limit is Only Human Idea', 1, CAST(N'2023-04-12T23:06:00.3505142' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (29, N'Cheap Solution for EveryTime', N'Vždy Levné Řešení', N'Cheap Solution for EveryTime', 1, CAST(N'2023-04-12T23:06:28.8005769' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (30, N'MultiMedia Supported', N'Podpora MultiMédií', N'MultiMedia Supported', 1, CAST(N'2023-04-12T23:06:43.8553061' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (31, N'Machines Are Supported', N'Podpora Strojů', N'Machines Are Supported', 1, CAST(N'2023-04-12T23:06:59.1281579' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (32, N'Intuitable System', N'Intuitivní Systém', N'Intuitable System', 1, CAST(N'2023-04-12T23:07:12.1448978' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (33, N'Hundreds of Tools are on Github', N'Stovky nástrojů na GitHub', N'Hundreds of Tools are on Github', 1, CAST(N'2023-04-12T23:07:33.2568702' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (34, N'No Limited Using', N'Neomezené Použití', N'No Limited Using', 1, CAST(N'2023-04-12T23:07:47.8237206' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (35, N'Visible Step Every Day', N'Viditelný Krok Každý Den', N'Visible Step Every Day', 1, CAST(N'2023-04-12T23:08:04.4877561' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (36, N'Simple Copy/Paste Development', N'Jednoduchý Vývoj Kopírováním Šablon', N'Simple Copy/Paste Development', 1, CAST(N'2023-04-12T23:08:51.1520201' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (37, N'Modern TouchPanels', N'Moderní Dotykové Panely', N'Modern TouchPanels', 1, CAST(N'2023-04-12T23:09:05.1911076' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (44, N'NotesList', N'Seznam Poznámek', N'Notes list', 1, CAST(N'2023-04-12T23:30:40.3134707' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (45, N'user', N'Uživatel', N'User', 1, CAST(N'2023-04-12T23:30:49.7436163' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (46, N'admin', N'Administrátor', N'Administrator', 1, CAST(N'2023-04-12T23:31:02.7354660' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (47, N'Missing User Parameter', N'Chybějící Paramert uživatele', N'Missing User Parameter', 1, CAST(N'2023-04-13T23:58:42.1797844' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (48, N'Will used System Default', N'Bude použit Systémový Default', N'Will used System Default', 1, CAST(N'2023-04-13T23:59:12.2606157' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (49, N'UsernameOrPasswordIncorrect', N'Neplatné uživatelské Jméno nebo Heslo', N'Username or password is incorrect', 1, CAST(N'2023-04-14T08:58:58.6678170' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (50, N'DocumentVatPriceFormat', N'Formát Ceny s DPH', N'Vat Price Format', 1, CAST(N'2023-04-14T09:08:13.1716404' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (51, N'ItemVatPriceFormat', N'Formát Položky Cena s DPH', N'Item Vat Price Format', 1, CAST(N'2023-04-14T09:08:55.7354288' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (53, N'DocumentRowHeight', N'Výška řádku Přehledu adresáře', N'Row Height of Address List', 1, CAST(N'2023-04-14T09:09:39.1901143' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (56, N'ReportSqlRowHeight', N'Výška řádku přehledu Report Datasetů', N'Row Height of Report DatasetList', 1, CAST(N'2023-04-14T09:10:16.6549404' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (58, N'AccessRoleList', N'Přístupy', N'AccessRoleList', 1, CAST(N'2023-04-15T00:00:47.7766794' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (59, N'AttachmentList', N'Přílohy', N'AttachmentList', 1, CAST(N'2023-04-15T00:06:47.9745366' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (60, N'AddressList', N'Adresář', N'Address List', 1, CAST(N'2023-04-14T23:59:36.4078137' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (61, N'BranchList', N'Pobočky', N'BranchList', 1, CAST(N'2023-04-15T00:02:46.7274908' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (62, N'CreditNoteList', N'Dobropisy', N'CreditNoteList', 1, CAST(N'2023-04-15T00:11:44.7042534' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (63, N'CreditNoteItemList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (64, N'CurrencyList', N'Měny', N'CurrencyList', 1, CAST(N'2023-04-15T00:14:32.4139703' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (65, N'DocumentAdviceList', N'Řady Dokladů', N'DocumentAdviceList', 1, CAST(N'2023-04-15T00:36:19.9743754' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (66, N'DocumentTypeList', N'Typy Dokumentů', N'DocumentTypeList', 1, CAST(N'2023-04-15T00:22:23.9047200' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (67, N'ExchangeRateList', N'Kurzovní Lístky', N'ExchangeRateList', 1, CAST(N'2023-04-15T00:12:07.3817560' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (68, N'IgnoredExceptionList', N'Ignorované Vyjímky', N'IgnoredExceptionList', 1, CAST(N'2023-04-15T00:31:40.8874090' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (69, N'IncomingInvoiceList', N'Faktura Přijatá', N'IncomingInvoiceList', 1, CAST(N'2023-04-15T00:32:37.9103570' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (70, N'IncomingInvoiceItemList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (71, N'IncomingOrderList', N'Objednávky Přijaté', N'IncomingOrderList', 1, CAST(N'2023-04-15T00:36:53.3416228' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (72, N'IncomingOrderItemList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (73, N'ItemList', N'Položky', N'ItemList', 1, CAST(N'2023-04-15T00:32:53.7747917' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (74, N'LanguageList', N'Jazyky Systému', N'LanguageList', 1, CAST(N'2023-04-15T00:32:04.4548210' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (75, N'LicenseActivationFailList', N'Lic.Neúspěšné Aktivace', N'LicenseActivationFailList', 1, CAST(N'2023-04-15T00:38:15.7103858' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (76, N'LicenseAlgorithmList', N'Licenční Algoritmy', N'LicenseAlgorithmList', 1, CAST(N'2023-04-15T00:37:46.6058327' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (77, N'LoginHistoryList', N'Historie Příhlášení', N'LoginHistoryList', 1, CAST(N'2023-04-15T00:37:24.4310047' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (78, N'MaturityList', N'Splatnosti', N'MaturityList', 1, CAST(N'2023-04-15T00:38:35.6602801' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (79, N'MottoList', N'Nápady a Vize', N'MottoList', 1, CAST(N'2023-04-15T00:33:17.3351334' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (80, N'OfferList', N'Nabídky', N'OfferList', 1, CAST(N'2023-04-15T00:35:44.0940439' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (81, N'OfferItemList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (82, N'OutgoingInvoiceList', N'Faktury Vydané', N'OutgoingInvoiceList', 1, CAST(N'2023-04-15T00:40:36.7902943' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (83, N'OutgoingInvoiceItemList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (84, N'OutgoingOrderList', N'Odchozí Objednávky', N'OutgoingOrderList', 1, CAST(N'2023-04-15T00:34:15.4702185' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (85, N'OutgoingOrderItemList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (86, N'ParameterList', N'Systémové parametry', N'System Parameters', 1, CAST(N'2023-04-14T23:45:02.8458817' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (87, N'PaymentMethodList', N'Platební Metody', N'Payment Methods', 1, CAST(N'2023-04-14T23:46:26.7999878' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (88, N'PaymentStatusList', N'Platební Statusy', N'Payment Statuses', 1, CAST(N'2023-04-14T23:49:14.6955996' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (89, N'ReceiptList', N'Příjemky', N'Receipts', 1, CAST(N'2023-04-14T23:49:33.7902623' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (90, N'ReceiptItemList', N'Položky Příjemky', N'Receipt Items', 1, CAST(N'2023-04-14T23:48:53.1351012' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (91, N'ReportQueueList', N'Report Datasety', N'Report Datasets', 1, CAST(N'2023-04-14T23:47:27.3436706' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (92, N'ReportList', N'Reporty', N'Reports', 1, CAST(N'2023-04-14T23:46:47.6238742' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (93, N'UnitList', N'Jednotky', N'Units', 1, CAST(N'2023-04-14T23:47:04.2858974' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (94, N'UsedLicenseList', N'Použité Licence', N'Used Licences', 1, CAST(N'2023-04-14T23:48:18.2226144' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (95, N'UserList', N'Uživatelé', N'Users', 1, CAST(N'2023-04-14T23:47:41.8700626' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (96, N'UserRoleList', N'Uživatelské Role', N'Users Role', 1, CAST(N'2023-04-14T23:48:01.2315603' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (97, N'SystemFailList', N'Systémový Log', N'System Log', 1, CAST(N'2023-04-14T23:49:53.3046428' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (98, N'VatList', N'Nastavení DPH', N'VAT setting', 1, CAST(N'2023-04-14T23:50:23.2627269' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (99, N'WarehouseList', N'Sklady', N'WareHouses', 1, CAST(N'2023-04-14T23:52:22.7111177' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (100, N'TemplateClassList', N'Ukázková Třída', N'Template Class', 1, CAST(N'2023-04-14T23:53:01.5527947' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (101, N'Přehled loginů', N'Přehled loginů', N'Login Overview', 1, CAST(N'2023-04-15T00:43:49.6874633' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (102, N'Tisk Účtenky', N'Tisk Účtenky', N'Printing Receipts', 1, CAST(N'2023-04-15T00:43:14.1496533' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (103, N'LoginHistoryAdvancedFilter', N'Log.Přihlášení Pokročilý Filt', N'LoginHistoryAdvancedFilter', 1, CAST(N'2023-04-15T00:41:29.8849062' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (104, N'Tisk Faktury', N'Tisk Faktury', N'Print Invoice', 1, CAST(N'2023-04-15T00:41:52.5914246' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (105, N'Hromadný Tisk Faktur', N'Hromadný Tisk FA', N'Bulk Invoice Print', 1, CAST(N'2023-04-15T00:42:51.5916333' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (106, N'Authentication', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (107, N'BackendCheck', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (108, N'Calendar', N'Kalendář', N'Calendar', 1, CAST(N'2023-04-15T00:39:04.9913144' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (109, N'ServerSetting', N'Nastavení Serveru', N'Server Setting', 1, CAST(N'2023-04-14T23:55:21.5120818' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (110, N'DataViewsShowDateFormat', N'Formát datumu v Data pohledu', N'Formát date in DataViews', 1, CAST(N'2023-04-17T00:51:46.4399508' AS DateTime2))
GO
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (111, N'ReportSupportForListOnly', N'Reporty pouze pro pro seznamy', N'Report Support For Lists Only', 1, CAST(N'2023-04-17T00:50:24.8818600' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (113, N'Missing Server Parameter', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (114, N'activeSystemSaver', N'Spořič Systému', N'System Saver', 1, CAST(N'2023-04-29T03:28:50.8256696' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (115, N'ImageGalleryList', N'Galerie obrázků', N'Image gallery', 1, CAST(N'2023-04-29T03:29:15.5400233' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (116, N'DeactivateIgnoredException', N'Přímá deaktivace všech zadaných ignorovaných vyjímek chyb systému', N'Directly disabling all specified ignored system error exceptions', 1, CAST(N'2023-04-29T11:10:56.1054545' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (118, N'GroupList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (119, N'OperationList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (120, N'PartList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (121, N'PersonList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (122, N'WorkList', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[LanguageList] ([Id], [SystemName], [DescriptionCz], [DescriptionEn], [UserId], [Timestamp]) VALUES (123, N'Přehled práce měsíčně', N'', N'', 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[LanguageList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LanguageList]    Script Date: 03.05.2023 11:24:04 ******/
ALTER TABLE [dbo].[LanguageList] ADD  CONSTRAINT [IX_LanguageList] UNIQUE NONCLUSTERED 
(
	[SystemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LanguageList] ADD  CONSTRAINT [DF_LanguageList_UserId]  DEFAULT ((0)) FOR [UserId]
GO
ALTER TABLE [dbo].[LanguageList] ADD  CONSTRAINT [DF_LanguageList_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[LanguageList]  WITH CHECK ADD  CONSTRAINT [FK_LanguageList_UserList] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserList] ([Id])
GO
ALTER TABLE [dbo].[LanguageList] CHECK CONSTRAINT [FK_LanguageList_UserList]
GO
