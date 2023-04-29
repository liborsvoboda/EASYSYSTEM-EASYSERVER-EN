using System;
using System.Collections.Generic;
using BACKENDCORE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GLOBALNET.DBModel
{
    public partial class GLOBALNETContext : DbContext
    {
        public GLOBALNETContext()
        {
        }

        public GLOBALNETContext(DbContextOptions<GLOBALNETContext> options)
                    : base(options) {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.ConfigureLoggingCacheTime(TimeSpan.FromMinutes(Program.ServerSettings.LoggingCacheTimeMinutes));
                optionsBuilder.EnableServiceProviderCaching(Program.ServerSettings.InternalCachingEnabled);

                optionsBuilder.UseSqlServer(Program.ServerSettings.DbConnectionString,
                      x => x.MigrationsHistoryTable("MigrationsHistory", "dbo"))
                //.UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }))
                //.LogTo(message => Debug.WriteLine(message))
                //.LogTo(Console.WriteLine)
                ;
            }
        }

        public virtual DbSet<AccessRoleList> AccessRoleLists { get; set; } = null!;
        public virtual DbSet<AddressList> AddressLists { get; set; } = null!;
        public virtual DbSet<AttachmentList> AttachmentLists { get; set; } = null!;
        public virtual DbSet<BranchList> BranchLists { get; set; } = null!;
        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<CreditNoteItemList> CreditNoteItemLists { get; set; } = null!;
        public virtual DbSet<CreditNoteList> CreditNoteLists { get; set; } = null!;
        public virtual DbSet<CurrencyList> CurrencyLists { get; set; } = null!;
        public virtual DbSet<DocumentAdviceList> DocumentAdviceLists { get; set; } = null!;
        public virtual DbSet<DocumentTypeList> DocumentTypeLists { get; set; } = null!;
        public virtual DbSet<ExchangeRateList> ExchangeRateLists { get; set; } = null!;
        public virtual DbSet<IgnoredExceptionList> IgnoredExceptionLists { get; set; } = null!;
        public virtual DbSet<ImageGalleryList> ImageGalleryLists { get; set; } = null!;
        public virtual DbSet<IncomingInvoiceItemList> IncomingInvoiceItemLists { get; set; } = null!;
        public virtual DbSet<IncomingInvoiceList> IncomingInvoiceLists { get; set; } = null!;
        public virtual DbSet<IncomingOrderItemList> IncomingOrderItemLists { get; set; } = null!;
        public virtual DbSet<IncomingOrderList> IncomingOrderLists { get; set; } = null!;
        public virtual DbSet<ItemList> ItemLists { get; set; } = null!;
        public virtual DbSet<LanguageList> LanguageLists { get; set; } = null!;
        public virtual DbSet<LicenseActivationFailList> LicenseActivationFailLists { get; set; } = null!;
        public virtual DbSet<LicenseAlgorithmList> LicenseAlgorithmLists { get; set; } = null!;
        public virtual DbSet<LoginHistoryList> LoginHistoryLists { get; set; } = null!;
        public virtual DbSet<MaturityList> MaturityLists { get; set; } = null!;
        public virtual DbSet<MottoList> MottoLists { get; set; } = null!;
        public virtual DbSet<NotesList> NotesLists { get; set; } = null!;
        public virtual DbSet<OfferItemList> OfferItemLists { get; set; } = null!;
        public virtual DbSet<OfferList> OfferLists { get; set; } = null!;
        public virtual DbSet<OutgoingInvoiceItemList> OutgoingInvoiceItemLists { get; set; } = null!;
        public virtual DbSet<OutgoingInvoiceList> OutgoingInvoiceLists { get; set; } = null!;
        public virtual DbSet<OutgoingOrderItemList> OutgoingOrderItemLists { get; set; } = null!;
        public virtual DbSet<OutgoingOrderList> OutgoingOrderLists { get; set; } = null!;
        public virtual DbSet<ParameterList> ParameterLists { get; set; } = null!;
        public virtual DbSet<PaymentMethodList> PaymentMethodLists { get; set; } = null!;
        public virtual DbSet<PaymentStatusList> PaymentStatusLists { get; set; } = null!;
        public virtual DbSet<ReceiptItemList> ReceiptItemLists { get; set; } = null!;
        public virtual DbSet<ReceiptList> ReceiptLists { get; set; } = null!;
        public virtual DbSet<ReportList> ReportLists { get; set; } = null!;
        public virtual DbSet<ReportQueueList> ReportQueueLists { get; set; } = null!;
        public virtual DbSet<ServerSetting> ServerSettings { get; set; } = null!;
        public virtual DbSet<SystemFailList> SystemFailLists { get; set; } = null!;
        public virtual DbSet<TemplateList> TemplateLists { get; set; } = null!;
        public virtual DbSet<UnitList> UnitLists { get; set; } = null!;
        public virtual DbSet<UsedLicenseList> UsedLicenseLists { get; set; } = null!;
        public virtual DbSet<UserList> UserLists { get; set; } = null!;
        public virtual DbSet<UserRoleList> UserRoleLists { get; set; } = null!;
        public virtual DbSet<VatList> VatLists { get; set; } = null!;
        public virtual DbSet<ViewAttachmentList> ViewAttachmentLists { get; set; } = null!;
        public virtual DbSet<WarehouseList> WarehouseLists { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessRoleList>(entity =>
            {
                entity.ToTable("AccessRoleList");

                entity.HasIndex(e => e.TableName, "IX_AccessRuleList")
                    .IsUnique();

                entity.Property(e => e.AccessRole)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccessRoleLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccessRuleList_UserList");
            });

            modelBuilder.Entity<AddressList>(entity =>
            {
                entity.ToTable("AddressList");

                entity.HasIndex(e => e.AddressType, "IX_AddressList");

                entity.Property(e => e.AddressType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Dic)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ico)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AddressLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddressList_UserList");
            });

            modelBuilder.Entity<AttachmentList>(entity =>
            {
                entity.ToTable("AttachmentList");

                entity.HasIndex(e => new { e.ParentId, e.ParentType }, "IX_AttachmentList");

                entity.HasIndex(e => new { e.ParentId, e.FileName }, "UX_AttachmentList")
                    .IsUnique();

                entity.Property(e => e.FileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ParentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AttachmentLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttachmentList_UserList");
            });

            modelBuilder.Entity<BranchList>(entity =>
            {
                entity.ToTable("BranchList");

                entity.HasIndex(e => e.CompanyName, "IX_BranchList")
                    .IsUnique();

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Dic)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ico)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BranchLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchList_UserList");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Date });

                entity.ToTable("Calendar");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Calendars)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Calendar_UserList");
            });

            modelBuilder.Entity<CreditNoteItemList>(entity =>
            {
                entity.ToTable("CreditNoteItemList");

                entity.Property(e => e.Count).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcsPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.CreditNoteItemLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_CreditNoteItemList_CreditNoteList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.CreditNoteItemLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CreditNoteItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteItemList_UserList");
            });

            modelBuilder.Entity<CreditNoteList>(entity =>
            {
                entity.ToTable("CreditNoteList");

                entity.HasIndex(e => e.DocumentNumber, "IX_CreditNoteList")
                    .IsUnique();

                entity.Property(e => e.Customer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.InvoiceNumberNavigation)
                    .WithMany(p => p.CreditNoteLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.InvoiceNumber)
                    .HasConstraintName("FK_CreditNoteList_OutgoingInvoiceList");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.CreditNoteLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CreditNoteLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteList_UserList");
            });

            modelBuilder.Entity<CurrencyList>(entity =>
            {
                entity.ToTable("CurrencyList");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CurrencyLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CurrencyList_UserList");
            });

            modelBuilder.Entity<DocumentAdviceList>(entity =>
            {
                entity.ToTable("DocumentAdviceList");

                entity.HasIndex(e => new { e.BranchId, e.DocumentType }, "IX_DocumentAdviceList");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Number)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DocumentAdviceLists)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentAdviceList_BranchList");

                entity.HasOne(d => d.DocumentTypeNavigation)
                    .WithMany(p => p.DocumentAdviceLists)
                    .HasPrincipalKey(p => p.SystemName)
                    .HasForeignKey(d => d.DocumentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentAdviceList_DocumentTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DocumentAdviceLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentAdvice_UserList");
            });

            modelBuilder.Entity<DocumentTypeList>(entity =>
            {
                entity.ToTable("DocumentTypeList");

                entity.HasIndex(e => e.SystemName, "IX_DocumentTypeList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DocumentTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentTypeList_UserList");
            });

            modelBuilder.Entity<ExchangeRateList>(entity =>
            {
                entity.ToTable("ExchangeRateList");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.Property(e => e.Value).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.ExchangeRateLists)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExchangeRateList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ExchangeRateLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseList_UserList");
            });

            modelBuilder.Entity<IgnoredExceptionList>(entity =>
            {
                entity.ToTable("IgnoredExceptionList");

                entity.HasIndex(e => e.ErrorNumber, "IX_IgnoredExceptionList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ErrorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IgnoredExceptionLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IgnoredExceptionList_UserList");
            });

            modelBuilder.Entity<ImageGalleryList>(entity =>
            {
                entity.ToTable("ImageGalleryList");

                entity.HasIndex(e => e.FileName, "UX_ImageGalleryList")
                    .IsUnique();

                entity.Property(e => e.FileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ImageGalleryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageGalleryList_UserList");
            });

            modelBuilder.Entity<IncomingInvoiceItemList>(entity =>
            {
                entity.ToTable("IncomingInvoiceItemList");

                entity.HasIndex(e => e.DocumentNumber, "IX_IncomingInvoiceItemList");

                entity.Property(e => e.Count).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcsPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.IncomingInvoiceItemLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_IncomingInvoiceItemList_IncomingInvoiceList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.IncomingInvoiceItemLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IncomingInvoiceItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceItemList_UserList");
            });

            modelBuilder.Entity<IncomingInvoiceList>(entity =>
            {
                entity.ToTable("IncomingInvoiceList");

                entity.HasIndex(e => e.DocumentNumber, "IX_IncomingInvoiceList")
                    .IsUnique();

                entity.Property(e => e.Customer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.Maturity)
                    .WithMany(p => p.IncomingInvoiceLists)
                    .HasForeignKey(d => d.MaturityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_MaturityList");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.IncomingInvoiceLists)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_PaymentMethodList");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.IncomingInvoiceLists)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_PaymentStatusList");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.IncomingInvoiceLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IncomingInvoiceLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_UserList");
            });

            modelBuilder.Entity<IncomingOrderItemList>(entity =>
            {
                entity.ToTable("IncomingOrderItemList");

                entity.HasIndex(e => e.DocumentNumber, "IX_IncomingOrderItemList");

                entity.Property(e => e.Count).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcsPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.IncomingOrderItemLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_IncomingOrderItemList_IncomingOrderList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.IncomingOrderItemLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingOrderItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IncomingOrderItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingOrderItemList_UserList");
            });

            modelBuilder.Entity<IncomingOrderList>(entity =>
            {
                entity.ToTable("IncomingOrderList");

                entity.HasIndex(e => e.DocumentNumber, "IX_IncomingOrderList")
                    .IsUnique();

                entity.HasIndex(e => e.Supplier, "IX_IncomingOrderList_Supplier");

                entity.Property(e => e.Customer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.IncomingOrderLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingOrderList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IncomingOrderLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingOrderList_UserList");
            });

            modelBuilder.Entity<ItemList>(entity =>
            {
                entity.ToTable("ItemList");

                entity.HasIndex(e => e.PartNumber, "IX_ItemList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.ItemLists)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemList_CurrencyList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.ItemLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemList_UserList");

                entity.HasOne(d => d.Vat)
                    .WithMany(p => p.ItemLists)
                    .HasForeignKey(d => d.VatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemList_VatList");
            });

            modelBuilder.Entity<LanguageList>(entity =>
            {
                entity.ToTable("LanguageList");

                entity.HasIndex(e => e.SystemName, "IX_LanguageList")
                    .IsUnique();

                entity.Property(e => e.DescriptionCz)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionEn)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LanguageLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LanguageList_UserList");
            });

            modelBuilder.Entity<LicenseActivationFailList>(entity =>
            {
                entity.ToTable("LicenseActivationFailList");

                entity.HasIndex(e => e.IpAddress, "IX_LicenseActivationFailList_IpAddress");

                entity.HasIndex(e => e.PartNumber, "IX_LicenseActivationFailList_PartNumber");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnlockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LicenseAlgorithmList>(entity =>
            {
                entity.ToTable("LicenseAlgorithmList");

                entity.HasIndex(e => e.Name, "IX_LicenseAlgorithmList")
                    .IsUnique();

                entity.Property(e => e.Algorithm)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.LicenseAlgorithmLists)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenseAlgorithmList_AddressList");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.LicenseAlgorithmLists)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenseAlgorithmList_ItemList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LicenseAlgorithmLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenseAlgorithmList_UserList");
            });

            modelBuilder.Entity<LoginHistoryList>(entity =>
            {
                entity.ToTable("LoginHistoryList");

                entity.HasIndex(e => e.IpAddress, "IX_LoginHistoryList");

                entity.HasIndex(e => e.UserId, "IX_LoginHistoryList_1");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaturityList>(entity =>
            {
                entity.ToTable("MaturityList");

                entity.HasIndex(e => e.Name, "IX_MaturityList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MaturityLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaturityList_UserList");
            });

            modelBuilder.Entity<MottoList>(entity =>
            {
                entity.ToTable("MottoList");

                entity.HasIndex(e => e.SystemName, "IX_MottoList")
                    .IsUnique();

                entity.Property(e => e.SystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MottoLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MottoList_UserList");
            });

            modelBuilder.Entity<NotesList>(entity =>
            {
                entity.ToTable("NotesList");

                entity.HasIndex(e => e.Name, "IX_NotesList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotesLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotesList_UserList");
            });

            modelBuilder.Entity<OfferItemList>(entity =>
            {
                entity.ToTable("OfferItemList");

                entity.HasIndex(e => e.DocumentNumber, "IX_OfferItemList");

                entity.Property(e => e.Count).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcsPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.OfferItemLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_OfferItemList_OfferList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OfferItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfferItemList_UserList");
            });

            modelBuilder.Entity<OfferList>(entity =>
            {
                entity.ToTable("OfferList");

                entity.HasIndex(e => e.DocumentNumber, "IX_OfferList")
                    .IsUnique();

                entity.HasIndex(e => e.Customer, "IX_OfferList_Customer");

                entity.Property(e => e.Customer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.OfferLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfferList_CurrencyList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OfferLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfferList_UserList");
            });

            modelBuilder.Entity<OutgoingInvoiceItemList>(entity =>
            {
                entity.ToTable("OutgoingInvoiceItemList");

                entity.HasIndex(e => e.DocumentNumber, "IX_OutgoingInvoiceItemList");

                entity.Property(e => e.Count).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcsPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.OutgoingInvoiceItemLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_OutgoingInvoiceItemList_OutgoingInvoiceList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.OutgoingInvoiceItemLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OutgoingInvoiceItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceItemList_UserList");
            });

            modelBuilder.Entity<OutgoingInvoiceList>(entity =>
            {
                entity.ToTable("OutgoingInvoiceList");

                entity.HasIndex(e => e.DocumentNumber, "IX_OutgoingInvoiceList")
                    .IsUnique();

                entity.HasIndex(e => e.Customer, "IX_OutgoingInvoiceList_Customer");

                entity.Property(e => e.Customer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.OutgoingInvoiceLists)
                    .HasForeignKey(d => d.CreditNoteId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_CreditNoteList");

                entity.HasOne(d => d.Maturity)
                    .WithMany(p => p.OutgoingInvoiceLists)
                    .HasForeignKey(d => d.MaturityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_MaturityList");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.OutgoingInvoiceLists)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_PaymentMethodList");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.OutgoingInvoiceLists)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_PaymentStatusList");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.OutgoingInvoiceLists)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_ReceiptList");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.OutgoingInvoiceLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OutgoingInvoiceLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_UserList");
            });

            modelBuilder.Entity<OutgoingOrderItemList>(entity =>
            {
                entity.ToTable("OutgoingOrderItemList");

                entity.HasIndex(e => e.DocumentNumber, "IX_OutgoingOrderItemList");

                entity.Property(e => e.Count).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcsPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.OutgoingOrderItemLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_OutgoingOrderItemList_OutgoingOrderList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.OutgoingOrderItemLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingOrderItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OutgoingOrderItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingOrderItemList_UserList");
            });

            modelBuilder.Entity<OutgoingOrderList>(entity =>
            {
                entity.ToTable("OutgoingOrderList");

                entity.HasIndex(e => e.DocumentNumber, "IX_OutgoingOrderList")
                    .IsUnique();

                entity.HasIndex(e => e.Supplier, "IX_OutgoingOrderList_Supplier");

                entity.Property(e => e.Customer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.OutgoingOrderLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingOrderList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OutgoingOrderLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingOrderList_UserList");
            });

            modelBuilder.Entity<ParameterList>(entity =>
            {
                entity.ToTable("ParameterList");

                entity.HasIndex(e => new { e.SystemName, e.UserId }, "IX_ParameterList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ParameterLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ParameterList_UserList");
            });

            modelBuilder.Entity<PaymentMethodList>(entity =>
            {
                entity.ToTable("PaymentMethodList");

                entity.HasIndex(e => e.Name, "IX_PaymentMethodList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PaymentMethodLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentMethodList_UserList");
            });

            modelBuilder.Entity<PaymentStatusList>(entity =>
            {
                entity.ToTable("PaymentStatusList");

                entity.HasIndex(e => e.Name, "IX_PaymentStatusList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PaymentStatusLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentStatusList_UserList");
            });

            modelBuilder.Entity<ReceiptItemList>(entity =>
            {
                entity.ToTable("ReceiptItemList");

                entity.Property(e => e.Count).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcsPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.ReceiptItemLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_ReceiptItemList_ReceiptList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.ReceiptItemLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReceiptItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptItemList_UserList");
            });

            modelBuilder.Entity<ReceiptList>(entity =>
            {
                entity.ToTable("ReceiptList");

                entity.HasIndex(e => e.DocumentNumber, "IX_ReceiptList")
                    .IsUnique();

                entity.Property(e => e.Customer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPriceWithVat).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.InvoiceNumberNavigation)
                    .WithMany(p => p.ReceiptLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.InvoiceNumber)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ReceiptList_OutgoingInvoiceList");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.ReceiptLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReceiptLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptList_UserList");
            });

            modelBuilder.Entity<ReportList>(entity =>
            {
                entity.ToTable("ReportList");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.MimeType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportList_UserList");
            });

            modelBuilder.Entity<ReportQueueList>(entity =>
            {
                entity.ToTable("ReportQueueList");

                entity.HasIndex(e => e.Name, "IX_ReportQueue")
                    .IsUnique();

                entity.HasIndex(e => e.TableName, "IX_ReportQueueList");

                entity.HasIndex(e => new { e.TableName, e.Sequence }, "IX_ReportQueueList_1")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Search)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServerSetting>(entity =>
            {
                entity.ToTable("ServerSetting");

                entity.Property(e => e.Key).HasMaxLength(150);

                entity.Property(e => e.Value).HasMaxLength(150);
            });

            modelBuilder.Entity<SystemFailList>(entity =>
            {
                entity.ToTable("SystemFailList");

                entity.Property(e => e.LogLevel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemFailLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SystemFailList_UserList");
            });

            modelBuilder.Entity<TemplateList>(entity =>
            {
                entity.ToTable("TemplateList");

                entity.HasIndex(e => e.Name, "IX_TemplateList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TemplateLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateList_UserList");
            });

            modelBuilder.Entity<UnitList>(entity =>
            {
                entity.ToTable("UnitList");

                entity.HasIndex(e => e.Name, "IX_UnitList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UnitLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitList_UserList");
            });

            modelBuilder.Entity<UsedLicenseList>(entity =>
            {
                entity.ToTable("UsedLicenseList");

                entity.Property(e => e.AlgorithmName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.License)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnlockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.UsedLicenseLists)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsedLicenseList_AddressList");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.UsedLicenseLists)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsedLicenseList_ItemList");
            });

            modelBuilder.Entity<UserList>(entity =>
            {
                entity.ToTable("UserList");

                entity.HasIndex(e => e.UserName, "IX_UserList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.MimeType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserLists)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserList_UserRoleList");
            });

            modelBuilder.Entity<UserRoleList>(entity =>
            {
                entity.ToTable("UserRoleList");

                entity.HasIndex(e => e.SystemName, "IX_UserRoleList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VatList>(entity =>
            {
                entity.ToTable("VatList");

                entity.HasIndex(e => new { e.Value, e.Active }, "IX_VatList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VatLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VatList_UserList");
            });

            modelBuilder.Entity<ViewAttachmentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AttachmentList");

                entity.Property(e => e.FileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseList>(entity =>
            {
                entity.ToTable("WarehouseList");

                entity.HasIndex(e => e.Name, "IX_WarehouseList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WarehouseLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarehouseList_UserList");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
