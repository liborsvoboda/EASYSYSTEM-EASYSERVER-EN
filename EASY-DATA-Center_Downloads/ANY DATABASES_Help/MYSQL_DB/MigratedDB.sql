-- ----------------------------------------------------------------------------
-- MySQL Workbench Migration
-- Migrated Schemata: EASYDATACenter
-- Source Schemata: EASYDATACenter
-- Created: Mon May 15 03:53:34 2023
-- Workbench Version: 8.0.33
-- ----------------------------------------------------------------------------

SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------------------------------------------------------
-- Schema EASYDATACenter
-- ----------------------------------------------------------------------------
DROP SCHEMA IF EXISTS `EASYDATACenter` ;
CREATE SCHEMA IF NOT EXISTS `EASYDATACenter` ;

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ServerTablesLocUsedList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ServerTablesLocUsedList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_ServerTablesLocUsedList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_ServerTablesLocUsedList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.NotesList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`NotesList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_NotesList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_NotesList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.BranchList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`BranchList` (
  `Id` INT NOT NULL,
  `CompanyName` VARCHAR(150) NOT NULL,
  `ContactName` VARCHAR(150) NULL,
  `Street` VARCHAR(150) NOT NULL,
  `City` VARCHAR(150) NOT NULL,
  `PostCode` VARCHAR(20) NOT NULL,
  `Phone` VARCHAR(20) NOT NULL,
  `Email` VARCHAR(150) NULL,
  `BankAccount` VARCHAR(150) NULL,
  `Ico` VARCHAR(20) NULL,
  `Dic` VARCHAR(20) NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_BranchList` (`CompanyName` ASC) VISIBLE,
  CONSTRAINT `FK_BranchList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.IgnoredExceptionList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`IgnoredExceptionList` (
  `Id` INT NOT NULL,
  `ErrorNumber` VARCHAR(50) NOT NULL,
  `Description` LONGTEXT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_IgnoredExceptionList` (`ErrorNumber` ASC) VISIBLE,
  CONSTRAINT `FK_IgnoredExceptionList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ExchangeRateList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ExchangeRateList` (
  `Id` INT NOT NULL,
  `CurrencyId` INT NOT NULL,
  `Value` DECIMAL(10,2) NOT NULL,
  `ValidFrom` DATE NULL,
  `ValidTo` DATE NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_ExchangeRateList_CurrencyList`
    FOREIGN KEY (`CurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_CourseList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.LanguageList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`LanguageList` (
  `Id` INT NOT NULL,
  `SystemName` VARCHAR(50) NOT NULL,
  `DescriptionCz` VARCHAR(250) NULL,
  `DescriptionEn` VARCHAR(250) NULL,
  `UserId` INT NULL DEFAULT 0,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_LanguageList` (`SystemName` ASC) VISIBLE,
  CONSTRAINT `FK_LanguageList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ReportQueueList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ReportQueueList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Sequence` INT NOT NULL,
  `Sql` VARCHAR(0) CHARACTER SET 'utf8mb4' NOT NULL,
  `TableName` VARCHAR(150) NOT NULL,
  `Filter` VARCHAR(0) CHARACTER SET 'utf8mb4' NULL,
  `Search` VARCHAR(50) NULL,
  `SearchColumnList` VARCHAR(0) CHARACTER SET 'utf8mb4' NULL,
  `SearchFilterIgnore` TINYINT(1) NOT NULL DEFAULT 0,
  `RecId` INT NULL,
  `RecIdFilterIgnore` TINYINT(1) NOT NULL DEFAULT 0,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_ReportQueue` (`Name` ASC) VISIBLE,
  INDEX `IX_ReportQueueList` (`TableName` ASC) VISIBLE,
  UNIQUE INDEX `IX_ReportQueueList_1` (`TableName` ASC, `Sequence` ASC) VISIBLE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.DocumentAdviceList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`DocumentAdviceList` (
  `Id` INT NOT NULL,
  `BranchId` INT NOT NULL,
  `DocumentType` VARCHAR(50) NOT NULL,
  `Prefix` VARCHAR(10) NOT NULL,
  `Number` VARCHAR(10) NOT NULL,
  `StartDate` DATE NOT NULL,
  `EndDate` DATE NOT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_DocumentAdviceList` (`BranchId` ASC, `DocumentType` ASC) VISIBLE,
  CONSTRAINT `FK_DocumentAdvice_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_DocumentAdviceList_BranchList`
    FOREIGN KEY (`BranchId`)
    REFERENCES `EASYDATACenter`.`BranchList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_DocumentAdviceList_DocumentTypeList`
    FOREIGN KEY (`DocumentType`)
    REFERENCES `EASYDATACenter`.`DocumentTypeList` (`SystemName`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ReceiptItemList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ReceiptItemList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `PartNumber` VARCHAR(50) NULL,
  `Name` VARCHAR(150) NOT NULL,
  `Unit` VARCHAR(10) NOT NULL,
  `PcsPrice` DECIMAL(10,2) NOT NULL,
  `Count` DECIMAL(10,2) NOT NULL,
  `TotalPrice` DECIMAL(10,2) NOT NULL,
  `Vat` DECIMAL(10,2) NOT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_ReceiptItemList_UnitList`
    FOREIGN KEY (`Unit`)
    REFERENCES `EASYDATACenter`.`UnitList` (`Name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ReceiptItemList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ReceiptItemList_ReceiptList`
    FOREIGN KEY (`DocumentNumber`)
    REFERENCES `EASYDATACenter`.`ReceiptList` (`DocumentNumber`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.UnitList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`UnitList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(10) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  `Default` TINYINT(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_UnitList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_UnitList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.MaturityList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`MaturityList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Value` INT NOT NULL,
  `Default` TINYINT(1) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_MaturityList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_MaturityList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.PaymentMethodList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`PaymentMethodList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(20) NOT NULL,
  `Default` TINYINT(1) NOT NULL,
  `Description` LONGTEXT NULL,
  `AutoGenerateReceipt` TINYINT(1) NOT NULL DEFAULT 0,
  `AllowGenerateReceipt` TINYINT(1) NOT NULL DEFAULT 0,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_PaymentMethodList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_PaymentMethodList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ImageGalleryList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ImageGalleryList` (
  `Id` INT NOT NULL,
  `IsPrimary` TINYINT(1) NOT NULL,
  `FileName` VARCHAR(150) NOT NULL,
  `Attachment` LONGBLOB NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `UX_ImageGalleryList` (`FileName` ASC) VISIBLE,
  CONSTRAINT `FK_ImageGalleryList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.IncomingOrderItemList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`IncomingOrderItemList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `PartNumber` VARCHAR(50) NULL,
  `Name` VARCHAR(150) NOT NULL,
  `Unit` VARCHAR(10) NOT NULL,
  `PcsPrice` DECIMAL(10,2) NOT NULL,
  `Count` DECIMAL(10,2) NOT NULL,
  `TotalPrice` DECIMAL(10,2) NOT NULL,
  `Vat` DECIMAL(10,2) NOT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_IncomingOrderItemList` (`DocumentNumber` ASC) VISIBLE,
  CONSTRAINT `FK_IncomingOrderItemList_UnitList`
    FOREIGN KEY (`Unit`)
    REFERENCES `EASYDATACenter`.`UnitList` (`Name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingOrderItemList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingOrderItemList_IncomingOrderList`
    FOREIGN KEY (`DocumentNumber`)
    REFERENCES `EASYDATACenter`.`IncomingOrderList` (`DocumentNumber`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ServerSetting
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ServerSetting` (
  `Id` INT NOT NULL,
  `Key` VARCHAR(150) CHARACTER SET 'utf8mb4' NOT NULL,
  `Value` VARCHAR(150) CHARACTER SET 'utf8mb4' NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`Id`));

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.OutgoingInvoiceList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`OutgoingInvoiceList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `Supplier` VARCHAR(512) NOT NULL,
  `Customer` VARCHAR(512) NOT NULL,
  `IssueDate` DATETIME(6) NOT NULL,
  `TaxDate` DATETIME(6) NOT NULL,
  `MaturityDate` DATETIME(6) NOT NULL,
  `PaymentMethodId` INT NOT NULL,
  `MaturityId` INT NOT NULL,
  `OrderNumber` VARCHAR(50) NULL,
  `Storned` TINYINT(1) NOT NULL,
  `PaymentStatusId` INT NOT NULL,
  `TotalCurrencyId` INT NOT NULL,
  `Description` LONGTEXT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `ReceiptId` INT NULL,
  `CreditNoteId` INT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_OutgoingInvoiceList` (`DocumentNumber` ASC) VISIBLE,
  INDEX `IX_OutgoingInvoiceList_Customer` (`Customer`(255) ASC) VISIBLE,
  CONSTRAINT `FK_OutgoingInvoiceList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingInvoiceList_MaturityList`
    FOREIGN KEY (`MaturityId`)
    REFERENCES `EASYDATACenter`.`MaturityList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingInvoiceList_PaymentMethodList`
    FOREIGN KEY (`PaymentMethodId`)
    REFERENCES `EASYDATACenter`.`PaymentMethodList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingInvoiceList_CurrencyList`
    FOREIGN KEY (`TotalCurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingInvoiceList_ReceiptList`
    FOREIGN KEY (`ReceiptId`)
    REFERENCES `EASYDATACenter`.`ReceiptList` (`Id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingInvoiceList_CreditNoteList`
    FOREIGN KEY (`CreditNoteId`)
    REFERENCES `EASYDATACenter`.`CreditNoteList` (`Id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingInvoiceList_PaymentStatusList`
    FOREIGN KEY (`PaymentStatusId`)
    REFERENCES `EASYDATACenter`.`PaymentStatusList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.OutgoingOrderItemList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`OutgoingOrderItemList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `PartNumber` VARCHAR(50) NULL,
  `Name` VARCHAR(150) NOT NULL,
  `Unit` VARCHAR(10) NOT NULL,
  `PcsPrice` DECIMAL(10,2) NOT NULL,
  `Count` DECIMAL(10,2) NOT NULL,
  `TotalPrice` DECIMAL(10,2) NOT NULL,
  `Vat` DECIMAL(10,2) NOT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_OutgoingOrderItemList` (`DocumentNumber` ASC) VISIBLE,
  CONSTRAINT `FK_OutgoingOrderItemList_UnitList`
    FOREIGN KEY (`Unit`)
    REFERENCES `EASYDATACenter`.`UnitList` (`Name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingOrderItemList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingOrderItemList_OutgoingOrderList`
    FOREIGN KEY (`DocumentNumber`)
    REFERENCES `EASYDATACenter`.`OutgoingOrderList` (`DocumentNumber`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.SystemFailList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`SystemFailList` (
  `Id` INT NOT NULL,
  `UserId` INT NULL,
  `UserName` VARCHAR(50) NULL,
  `LogLevel` VARCHAR(20) NOT NULL,
  `Message` LONGTEXT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_SystemFailList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.OutgoingOrderList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`OutgoingOrderList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `Customer` VARCHAR(512) NOT NULL,
  `Supplier` VARCHAR(512) NOT NULL,
  `Storned` TINYINT(1) NOT NULL,
  `TotalCurrencyId` INT NOT NULL,
  `Description` LONGTEXT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_OutgoingOrderList` (`DocumentNumber` ASC) VISIBLE,
  INDEX `IX_OutgoingOrderList_Supplier` (`Supplier`(255) ASC) VISIBLE,
  CONSTRAINT `FK_OutgoingOrderList_CurrencyList`
    FOREIGN KEY (`TotalCurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingOrderList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ProdGuidGroupList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ProdGuidGroupList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `UserId` INT NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_ProdGuidGroupList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ReceiptList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ReceiptList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `InvoiceNumber` VARCHAR(20) NULL,
  `Supplier` VARCHAR(512) NOT NULL,
  `Customer` VARCHAR(512) NOT NULL,
  `IssueDate` DATETIME(6) NOT NULL,
  `Storned` TINYINT(1) NOT NULL,
  `TotalCurrencyId` INT NOT NULL,
  `Description` LONGTEXT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_ReceiptList` (`DocumentNumber` ASC) VISIBLE,
  CONSTRAINT `FK_ReceiptList_OutgoingInvoiceList`
    FOREIGN KEY (`InvoiceNumber`)
    REFERENCES `EASYDATACenter`.`OutgoingInvoiceList` (`DocumentNumber`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ReceiptList_CurrencyList`
    FOREIGN KEY (`TotalCurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ReceiptList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.OfferList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`OfferList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `Supplier` VARCHAR(512) NOT NULL,
  `Customer` VARCHAR(512) NOT NULL,
  `OfferValidity` INT NOT NULL,
  `Storned` TINYINT(1) NOT NULL,
  `TotalCurrencyId` INT NOT NULL,
  `Description` LONGTEXT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_OfferList` (`DocumentNumber` ASC) VISIBLE,
  INDEX `IX_OfferList_Customer` (`Customer`(255) ASC) VISIBLE,
  CONSTRAINT `FK_OfferList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OfferList_CurrencyList1`
    FOREIGN KEY (`TotalCurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.PaymentStatusList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`PaymentStatusList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Default` TINYINT(1) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `Receipt` TINYINT(1) NOT NULL DEFAULT 0,
  `CreditNote` TINYINT(1) NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_PaymentStatusList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_PaymentStatusList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.Calendar
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`Calendar` (
  `UserId` INT NOT NULL,
  `Date` DATE NOT NULL,
  `Notes` VARCHAR(1024) NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`UserId`, `Date`),
  CONSTRAINT `FK_Calendar_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ProdGuidPersonList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ProdGuidPersonList` (
  `Id` INT NOT NULL,
  `GroupId` INT NOT NULL,
  `PersonalNumber` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `SurName` VARCHAR(100) NOT NULL,
  `UserId` INT NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_ProdGuidPersonList` (`PersonalNumber` ASC) VISIBLE,
  CONSTRAINT `FK_ProdGuidPersonList_ProdGuidGroupList`
    FOREIGN KEY (`GroupId`)
    REFERENCES `EASYDATACenter`.`ProdGuidGroupList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ProdGuidPersonList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.UserList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`UserList` (
  `Id` INT NOT NULL,
  `RoleId` INT NOT NULL,
  `UserName` VARCHAR(150) NOT NULL,
  `Password` VARCHAR(2048) NOT NULL,
  `Name` VARCHAR(150) NOT NULL,
  `SurName` VARCHAR(150) NOT NULL,
  `Description` LONGTEXT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `Timestamp` DATETIME(6) NOT NULL,
  `Token` VARCHAR(2048) NULL,
  `Expiration` DATETIME(6) NULL,
  `Photo` LONGBLOB NULL,
  `MimeType` VARCHAR(100) NULL,
  `PhotoPath` VARCHAR(500) NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_UserList` (`UserName` ASC) VISIBLE,
  CONSTRAINT `FK_UserList_UserList`
    FOREIGN KEY (`Id`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_UserList_UserRoleList`
    FOREIGN KEY (`RoleId`)
    REFERENCES `EASYDATACenter`.`UserRoleList` (`Id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.OutgoingInvoiceItemList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`OutgoingInvoiceItemList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `PartNumber` VARCHAR(50) NULL,
  `Name` VARCHAR(150) NOT NULL,
  `Unit` VARCHAR(10) NOT NULL,
  `PcsPrice` DECIMAL(10,2) NOT NULL,
  `Count` DECIMAL(10,2) NOT NULL,
  `TotalPrice` DECIMAL(10,2) NOT NULL,
  `Vat` DECIMAL(10,2) NOT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_OutgoingInvoiceItemList` (`DocumentNumber` ASC) VISIBLE,
  CONSTRAINT `FK_OutgoingInvoiceItemList_UnitList`
    FOREIGN KEY (`Unit`)
    REFERENCES `EASYDATACenter`.`UnitList` (`Name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingInvoiceItemList_OutgoingInvoiceList`
    FOREIGN KEY (`DocumentNumber`)
    REFERENCES `EASYDATACenter`.`OutgoingInvoiceList` (`DocumentNumber`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OutgoingInvoiceItemList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.IncomingOrderList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`IncomingOrderList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `Supplier` VARCHAR(512) NOT NULL,
  `Customer` VARCHAR(512) NOT NULL,
  `Storned` TINYINT(1) NOT NULL,
  `TotalCurrencyId` INT NOT NULL,
  `Description` LONGTEXT NULL,
  `CustomerOrderNumber` VARCHAR(50) NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_IncomingOrderList` (`DocumentNumber` ASC) VISIBLE,
  INDEX `IX_IncomingOrderList_Supplier` (`Supplier`(255) ASC) VISIBLE,
  CONSTRAINT `FK_IncomingOrderList_CurrencyList`
    FOREIGN KEY (`TotalCurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingOrderList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ProdGuidPartList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ProdGuidPartList` (
  `Id` INT NOT NULL,
  `WorkPlace` INT NOT NULL,
  `Number` VARCHAR(50) NOT NULL,
  `Name` VARCHAR(100) NULL,
  `UserId` INT NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_ProdGuidPartList` (`WorkPlace` ASC, `Number` ASC) VISIBLE,
  CONSTRAINT `FK_ProdGuidPartList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ProdGuidOperationList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ProdGuidOperationList` (
  `Id` INT NOT NULL,
  `WorkPlace` INT NOT NULL,
  `PartNumber` VARCHAR(50) NOT NULL,
  `OperationNumber` INT NOT NULL,
  `Note` VARCHAR(100) NOT NULL,
  `PcsPerHour` INT NOT NULL,
  `KcPerKs` DECIMAL(10,4) NOT NULL,
  `UserId` INT NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_ProdGuidOperationList` (`WorkPlace` ASC, `OperationNumber` ASC) VISIBLE,
  CONSTRAINT `FK_ProdGuidOperationList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.VatList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`VatList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(20) NOT NULL,
  `Value` DECIMAL(10,2) NOT NULL,
  `Default` TINYINT(1) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_VatList` (`Value` ASC, `Active` ASC) VISIBLE,
  CONSTRAINT `FK_VatList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ProdGuidWorkList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ProdGuidWorkList` (
  `Id` INT NOT NULL,
  `Date` DATETIME(6) NOT NULL,
  `PersonalNumber` INT NOT NULL,
  `WorkPlace` INT NOT NULL,
  `OperationNumber` INT NOT NULL,
  `WorkTime` TIME(6) NOT NULL,
  `Pcs` INT NOT NULL,
  `Amount` DECIMAL(10,2) NOT NULL,
  `WorkPower` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_ProdGuidWorkList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_ProdGuidWorkList_ProdGuidPersonList`
    FOREIGN KEY (`PersonalNumber`)
    REFERENCES `EASYDATACenter`.`ProdGuidPersonList` (`PersonalNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ProdGuidWorkList_ProdGuidWorkList`
    FOREIGN KEY (`Id`)
    REFERENCES `EASYDATACenter`.`ProdGuidWorkList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.IncomingInvoiceList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`IncomingInvoiceList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `Supplier` VARCHAR(512) NOT NULL,
  `Customer` VARCHAR(512) NOT NULL,
  `IssueDate` DATETIME(6) NOT NULL,
  `TaxDate` DATETIME(6) NOT NULL,
  `MaturityDate` DATETIME(6) NOT NULL,
  `PaymentMethodId` INT NOT NULL,
  `MaturityId` INT NOT NULL,
  `OrderNumber` VARCHAR(50) NULL,
  `Storned` TINYINT(1) NOT NULL,
  `PaymentStatusId` INT NOT NULL,
  `TotalCurrencyId` INT NOT NULL,
  `Description` LONGTEXT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_IncomingInvoiceList` (`DocumentNumber` ASC) VISIBLE,
  CONSTRAINT `FK_IncomingInvoiceList_PaymentMethodList`
    FOREIGN KEY (`PaymentMethodId`)
    REFERENCES `EASYDATACenter`.`PaymentMethodList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingInvoiceList_PaymentStatusList`
    FOREIGN KEY (`PaymentStatusId`)
    REFERENCES `EASYDATACenter`.`PaymentStatusList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingInvoiceList_CurrencyList`
    FOREIGN KEY (`TotalCurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingInvoiceList_MaturityList`
    FOREIGN KEY (`MaturityId`)
    REFERENCES `EASYDATACenter`.`MaturityList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingInvoiceList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.WarehouseList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`WarehouseList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `AllowNegativeStatus` TINYINT(1) NOT NULL,
  `Default` TINYINT(1) NOT NULL,
  `LockedByStockTaking` TINYINT(1) NOT NULL DEFAULT 0,
  `LastStockTaking` DATETIME(6) NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_WarehouseList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_WarehouseList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ItemList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ItemList` (
  `Id` INT NOT NULL,
  `PartNumber` VARCHAR(50) NOT NULL,
  `Name` VARCHAR(150) NOT NULL,
  `Description` LONGTEXT NULL,
  `Unit` VARCHAR(10) NOT NULL,
  `Price` DECIMAL(10,2) NOT NULL,
  `VatId` INT NOT NULL,
  `CurrencyId` INT NOT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_ItemList` (`PartNumber` ASC) VISIBLE,
  CONSTRAINT `FK_ItemList_VatList`
    FOREIGN KEY (`VatId`)
    REFERENCES `EASYDATACenter`.`VatList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemList_CurrencyList`
    FOREIGN KEY (`CurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemList_UnitList`
    FOREIGN KEY (`Unit`)
    REFERENCES `EASYDATACenter`.`UnitList` (`Name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.LoginHistoryList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`LoginHistoryList` (
  `Id` INT NOT NULL,
  `IpAddress` VARCHAR(50) NOT NULL,
  `UserId` INT NOT NULL DEFAULT 0,
  `UserName` VARCHAR(150) NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_LoginHistoryList` (`IpAddress` ASC) VISIBLE,
  INDEX `IX_LoginHistoryList_1` (`UserId` ASC) VISIBLE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ReportList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ReportList` (
  `Id` INT NOT NULL,
  `PageName` VARCHAR(50) NOT NULL,
  `SystemName` VARCHAR(50) NOT NULL,
  `JoinedId` TINYINT(1) NOT NULL DEFAULT 0,
  `Description` LONGTEXT NULL,
  `ReportPath` VARCHAR(500) NULL,
  `MimeType` VARCHAR(100) NOT NULL,
  `File` LONGBLOB NOT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `Timestamp` DATETIME(6) NOT NULL,
  `Default` TINYINT(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_ReportList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.IncomingInvoiceItemList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`IncomingInvoiceItemList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `PartNumber` VARCHAR(50) NULL,
  `Name` VARCHAR(150) NOT NULL,
  `Unit` VARCHAR(10) NOT NULL,
  `PcsPrice` DECIMAL(10,2) NOT NULL,
  `Count` DECIMAL(10,2) NOT NULL,
  `TotalPrice` DECIMAL(10,2) NOT NULL,
  `Vat` DECIMAL(10,2) NOT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_IncomingInvoiceItemList` (`DocumentNumber` ASC) VISIBLE,
  CONSTRAINT `FK_IncomingInvoiceItemList_UnitList`
    FOREIGN KEY (`Unit`)
    REFERENCES `EASYDATACenter`.`UnitList` (`Name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingInvoiceItemList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_IncomingInvoiceItemList_IncomingInvoiceList`
    FOREIGN KEY (`DocumentNumber`)
    REFERENCES `EASYDATACenter`.`IncomingInvoiceList` (`DocumentNumber`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.AccessRoleList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`AccessRoleList` (
  `Id` INT NOT NULL,
  `TableName` VARCHAR(50) NOT NULL,
  `AccessRole` VARCHAR(1024) NOT NULL DEFAULT 'Admin,',
  `UserId` INT NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_AccessRuleList` (`TableName` ASC) VISIBLE,
  CONSTRAINT `FK_AccessRuleList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.CreditNoteList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`CreditNoteList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `Supplier` VARCHAR(512) NOT NULL,
  `Customer` VARCHAR(512) NOT NULL,
  `IssueDate` DATETIME(6) NOT NULL,
  `InvoiceNumber` VARCHAR(20) NULL,
  `Storned` TINYINT(1) NOT NULL,
  `TotalCurrencyId` INT NOT NULL,
  `Description` LONGTEXT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_CreditNoteList` (`DocumentNumber` ASC) VISIBLE,
  CONSTRAINT `FK_CreditNoteList_OutgoingInvoiceList`
    FOREIGN KEY (`InvoiceNumber`)
    REFERENCES `EASYDATACenter`.`OutgoingInvoiceList` (`DocumentNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_CreditNoteList_CurrencyList`
    FOREIGN KEY (`TotalCurrencyId`)
    REFERENCES `EASYDATACenter`.`CurrencyList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_CreditNoteList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.ParameterList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`ParameterList` (
  `Id` INT NOT NULL,
  `UserId` INT NULL,
  `SystemName` VARCHAR(50) NOT NULL,
  `Value` VARCHAR(50) NOT NULL,
  `Type` VARCHAR(20) NOT NULL,
  `Description` LONGTEXT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_ParameterList` (`SystemName` ASC, `UserId` ASC) VISIBLE,
  CONSTRAINT `FK_ParameterList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.AttachmentList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`AttachmentList` (
  `Id` INT NOT NULL,
  `ParentId` INT NOT NULL,
  `ParentType` VARCHAR(20) NOT NULL,
  `FileName` VARCHAR(150) NOT NULL,
  `Attachment` LONGBLOB NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `UX_AttachmentList` (`ParentId` ASC, `FileName` ASC) VISIBLE,
  INDEX `IX_AttachmentList` (`ParentId` ASC, `ParentType` ASC) VISIBLE,
  CONSTRAINT `FK_AttachmentList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.DocumentTypeList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`DocumentTypeList` (
  `Id` INT NOT NULL,
  `SystemName` VARCHAR(50) NOT NULL DEFAULT 'MustProgramming',
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_DocumentTypeList` (`SystemName` ASC) VISIBLE,
  CONSTRAINT `FK_DocumentTypeList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.TemplateList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`TemplateList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Default` TINYINT(1) NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_TemplateList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_TemplateList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.CreditNoteItemList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`CreditNoteItemList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `PartNumber` VARCHAR(50) NULL,
  `Name` VARCHAR(150) NOT NULL,
  `Unit` VARCHAR(10) NOT NULL,
  `PcsPrice` DECIMAL(10,2) NOT NULL,
  `Count` DECIMAL(10,2) NOT NULL,
  `TotalPrice` DECIMAL(10,2) NOT NULL,
  `Vat` DECIMAL(10,2) NOT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_CreditNoteItemList_CreditNoteList`
    FOREIGN KEY (`DocumentNumber`)
    REFERENCES `EASYDATACenter`.`CreditNoteList` (`DocumentNumber`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_CreditNoteItemList_UnitList`
    FOREIGN KEY (`Unit`)
    REFERENCES `EASYDATACenter`.`UnitList` (`Name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_CreditNoteItemList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.UserRoleList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`UserRoleList` (
  `Id` INT NOT NULL,
  `SystemName` VARCHAR(50) NOT NULL,
  `Description` LONGTEXT NULL,
  `UserId` INT NULL,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_UserRoleList` (`SystemName` ASC) VISIBLE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.AddressList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`AddressList` (
  `Id` INT NOT NULL,
  `AddressType` VARCHAR(20) NOT NULL,
  `CompanyName` VARCHAR(150) NOT NULL,
  `ContactName` VARCHAR(150) NULL,
  `Street` VARCHAR(150) NOT NULL,
  `City` VARCHAR(150) NOT NULL,
  `PostCode` VARCHAR(20) NOT NULL,
  `Phone` VARCHAR(20) NOT NULL,
  `Email` VARCHAR(150) NULL,
  `BankAccount` VARCHAR(150) NULL,
  `Ico` VARCHAR(20) NULL,
  `Dic` VARCHAR(20) NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_AddressList` (`AddressType` ASC) VISIBLE,
  CONSTRAINT `FK_AddressList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.CurrencyList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`CurrencyList` (
  `Id` INT NOT NULL,
  `Name` VARCHAR(5) NOT NULL,
  `ExchangeRate` DECIMAL(10,2) NOT NULL DEFAULT 1,
  `Fixed` TINYINT(1) NOT NULL DEFAULT 1,
  `Description` LONGTEXT NULL,
  `UserId` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL DEFAULT 1,
  `TimeStamp` DATETIME(6) NOT NULL,
  `Default` TINYINT(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_CurrencyList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.OfferItemList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`OfferItemList` (
  `Id` INT NOT NULL,
  `DocumentNumber` VARCHAR(20) NOT NULL,
  `PartNumber` VARCHAR(50) NULL,
  `Name` VARCHAR(150) NOT NULL,
  `Unit` VARCHAR(10) NOT NULL,
  `PcsPrice` DECIMAL(10,2) NOT NULL,
  `Count` DECIMAL(10,2) NOT NULL,
  `TotalPrice` DECIMAL(10,2) NOT NULL,
  `Vat` DECIMAL(10,2) NOT NULL,
  `TotalPriceWithVat` DECIMAL(10,2) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_OfferItemList` (`DocumentNumber` ASC) VISIBLE,
  CONSTRAINT `FK_OfferItemList_OfferList`
    FOREIGN KEY (`DocumentNumber`)
    REFERENCES `EASYDATACenter`.`OfferList` (`DocumentNumber`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_OfferItemList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.MottoList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`MottoList` (
  `Id` INT NOT NULL,
  `SystemName` VARCHAR(50) NOT NULL,
  `UserId` INT NOT NULL DEFAULT 1,
  `Timestamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_MottoList` (`SystemName` ASC) VISIBLE,
  CONSTRAINT `FK_MottoList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.LicenseAlgorithmList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`LicenseAlgorithmList` (
  `Id` INT NOT NULL,
  `AddressId` INT NOT NULL,
  `ItemId` INT NOT NULL,
  `Name` VARCHAR(30) NOT NULL,
  `ValidFrom` DATE NULL,
  `ValidTo` DATE NULL,
  `Algorithm` VARCHAR(2000) NOT NULL,
  `Description` LONGTEXT NULL,
  `LimitActive` TINYINT(1) NOT NULL,
  `ActivationLimit` INT NULL,
  `UsedCount` INT NOT NULL,
  `Active` TINYINT(1) NOT NULL,
  `UserId` INT NOT NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_LicenseAlgorithmList` (`Name` ASC) VISIBLE,
  CONSTRAINT `FK_LicenseAlgorithmList_AddressList`
    FOREIGN KEY (`AddressId`)
    REFERENCES `EASYDATACenter`.`AddressList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_LicenseAlgorithmList_ItemList`
    FOREIGN KEY (`ItemId`)
    REFERENCES `EASYDATACenter`.`ItemList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_LicenseAlgorithmList_UserList`
    FOREIGN KEY (`UserId`)
    REFERENCES `EASYDATACenter`.`UserList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.LicenseActivationFailList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`LicenseActivationFailList` (
  `Id` INT NOT NULL,
  `IpAddress` VARCHAR(50) NOT NULL,
  `UnlockCode` VARCHAR(50) NULL,
  `PartNumber` VARCHAR(50) NULL,
  `TimeStamp` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_LicenseActivationFailList_PartNumber` (`PartNumber` ASC) VISIBLE,
  INDEX `IX_LicenseActivationFailList_IpAddress` (`IpAddress` ASC) VISIBLE);

-- ----------------------------------------------------------------------------
-- Table EASYDATACenter.UsedLicenseList
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `EASYDATACenter`.`UsedLicenseList` (
  `Id` INT NOT NULL,
  `AlgorithmName` VARCHAR(30) NOT NULL,
  `PartNumber` VARCHAR(50) NOT NULL,
  `UnlockCode` VARCHAR(50) NOT NULL,
  `AddressId` INT NOT NULL,
  `ItemId` INT NOT NULL,
  `License` VARCHAR(50) NOT NULL,
  `ActivateDate` DATETIME(6) NOT NULL,
  `IpAddress` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_UsedLicenseList_AddressList`
    FOREIGN KEY (`AddressId`)
    REFERENCES `EASYDATACenter`.`AddressList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_UsedLicenseList_ItemList`
    FOREIGN KEY (`ItemId`)
    REFERENCES `EASYDATACenter`.`ItemList` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_BranchList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- 
-- CREATE   TRIGGER [dbo].[TR_BranchList] ON [dbo].[BranchList]
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setActive bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setActive = ins.[Active] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setActive = 1) BEGIN
-- 			UPDATE [dbo].BranchList SET [Active] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setActive = ins.[Active] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setActive = 1) BEGIN
-- 				UPDATE [dbo].BranchList SET [Active] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setActive = ins.[Active] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setActive = 1) BEGIN
-- 		UPDATE [dbo].BranchList SET [Active] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].BranchList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_UnitList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- 
-- CREATE   TRIGGER [dbo].[TR_UnitList] ON [dbo].[UnitList]
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].UnitList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].UnitList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].UnitList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].UnitList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_MaturityList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- 
-- CREATE   TRIGGER [dbo].[TR_MaturityList] ON [dbo].[MaturityList]
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].MaturityList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].MaturityList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].MaturityList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].MaturityList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_PaymentMethodList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- CREATE   TRIGGER [dbo].[TR_PaymentMethodList] ON dbo.PaymentMethodList
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].PaymentMethodList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].PaymentMethodList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].PaymentMethodList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].PaymentMethodList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_ImageGalleryList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- 
-- 
-- 
-- 
-- CREATE   TRIGGER [dbo].[TR_ImageGalleryList] ON [dbo].[ImageGalleryList]
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @isPrimary bit;DECLARE @RecId int;DECLARE @HotelId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @isPrimary = ins.[IsPrimary] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@isPrimary = 1) BEGIN
-- 			UPDATE [dbo].ImageGalleryList SET [IsPrimary] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @isPrimary = ins.[IsPrimary] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@isPrimary = 1) BEGIN
-- 				UPDATE [dbo].ImageGalleryList SET [IsPrimary] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @isPrimary = ins.[IsPrimary] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@isPrimary = 1) BEGIN
-- 		UPDATE [dbo].ImageGalleryList SET [IsPrimary] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].ImageGalleryList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_PaymentStatusList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- CREATE   TRIGGER [dbo].[TR_PaymentStatusList] ON dbo.PaymentStatusList
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].PaymentStatusList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].PaymentStatusList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].PaymentStatusList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].PaymentStatusList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_PaymentStatusListCreditNote
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- CREATE   TRIGGER [dbo].[TR_PaymentStatusListCreditNote] ON dbo.PaymentStatusList
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setCreditNote bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setCreditNote = ins.[CreditNote] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setCreditNote = 1) BEGIN
-- 			UPDATE [dbo].PaymentStatusList SET [CreditNote] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setCreditNote = ins.[CreditNote] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setCreditNote = 1) BEGIN
-- 				UPDATE [dbo].PaymentStatusList SET [CreditNote] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setCreditNote = ins.[CreditNote] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setCreditNote = 1) BEGIN
-- 		UPDATE [dbo].PaymentStatusList SET [CreditNote] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].PaymentStatusList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_PaymentStatusListReceipt
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- 
-- CREATE   TRIGGER [dbo].[TR_PaymentStatusListReceipt] ON [dbo].[PaymentStatusList]
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setReceipt bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setReceipt = ins.[Receipt] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setReceipt = 1) BEGIN
-- 			UPDATE [dbo].PaymentStatusList SET [Receipt] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setReceipt = ins.[Receipt] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setReceipt = 1) BEGIN
-- 				UPDATE [dbo].PaymentStatusList SET [Receipt] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setReceipt = ins.[Receipt] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setReceipt = 1) BEGIN
-- 		UPDATE [dbo].PaymentStatusList SET [Receipt] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].PaymentStatusList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_VatList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- CREATE   TRIGGER [dbo].[TR_VatList] ON dbo.VatList
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].VatList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].VatList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].VatList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].VatList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_WarehouseList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- CREATE   TRIGGER [dbo].[TR_WarehouseList] ON dbo.WarehouseList
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].WarehouseList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].WarehouseList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].WarehouseList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].WarehouseList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_ReportList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- CREATE   TRIGGER [dbo].[TR_ReportList] ON dbo.ReportList
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].ReportList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].ReportList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].ReportList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].ReportList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_TemplateList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- 
-- CREATE   TRIGGER [dbo].[TR_TemplateList] ON [dbo].[TemplateList]
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].TemplateList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].TemplateList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].TemplateList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].TemplateList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;

-- ----------------------------------------------------------------------------
-- Trigger EASYDATACenter.TR_CurrencyList
-- ----------------------------------------------------------------------------
-- DELIMITER $$
-- USE `EASYDATACenter`$$
-- CREATE   TRIGGER [dbo].[TR_CurrencyList] ON dbo.CurrencyList
-- FOR INSERT, UPDATE, DELETE
-- AS
-- DECLARE @Operation VARCHAR(15)
--  
-- IF EXISTS (SELECT 0 FROM inserted)
-- BEGIN
-- 	DECLARE @setDefault bit;DECLARE @RecId int;
-- 	SET NOCOUNT ON;
-- 
--     IF EXISTS (SELECT 0 FROM deleted)
--     BEGIN --UPDADE
-- 		SELECT @setDefault = ins.[Default] from inserted ins;
-- 		SELECT @RecId = ins.Id from inserted ins;
-- 
-- 		IF(@setDefault = 1) BEGIN
-- 			UPDATE [dbo].CurrencyList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 		END
-- 	END ELSE
-- 		BEGIN -- INSERT
-- 			SELECT @setDefault = ins.[Default] from inserted ins;
-- 			SELECT @RecId = ins.Id from inserted ins;
-- 
-- 			IF(@setDefault = 1) BEGIN
-- 				UPDATE [dbo].CurrencyList SET [Default] = 0 WHERE Id <> @RecId; 		
-- 			END
-- 		
-- 		END
-- END ELSE 
-- BEGIN --DELETE
-- 	SELECT @setDefault = ins.[Default] from deleted ins;
-- 	SELECT @RecId = ins.Id from deleted ins;
-- 
-- 	IF(@setDefault = 1) BEGIN
-- 		UPDATE [dbo].CurrencyList SET [Default] = 1  
-- 		WHERE Id IN(SELECT TOP (1) Id FROM [dbo].CurrencyList WHERE Id <> @RecId)
-- 		;
-- 	END
-- END
-- ;
SET FOREIGN_KEY_CHECKS = 1;
