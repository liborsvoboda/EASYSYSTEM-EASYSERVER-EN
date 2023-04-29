using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BACKENDCORE;

namespace LICENSESRV.DBModel
{
    public partial class LICENSESRVContext : DbContext
    {
        public LICENSESRVContext()
        {
        }

        public LICENSESRVContext(DbContextOptions<LICENSESRVContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.ConfigureLoggingCacheTime(TimeSpan.FromMinutes(Program.ServerSettings.LoggingCacheTimeMinutes));
                optionsBuilder.EnableServiceProviderCaching(Program.ServerSettings.InternalCachingEnabled);

                optionsBuilder.UseSqlServer("Server=192.168.1.141;Database=LICENSESRV;User ID=licensesrv;Password=licensesrv;",
                  //optionsBuilder.UseSqlServer(Program.ServerSettings.DbConnectionString,
                  x => x.MigrationsHistoryTable("MigrationsHistory", "dbo"))
                //.UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }))
                //.LogTo(message => Debug.WriteLine(message))
                //.LogTo(Console.WriteLine)
                ;
            }
        }

        public virtual DbSet<AddressList> AddressLists { get; set; } = null!;
        public virtual DbSet<AttachmentList> AttachmentLists { get; set; } = null!;
        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<CurrencyList> CurrencyLists { get; set; } = null!;
        public virtual DbSet<ItemList> ItemLists { get; set; } = null!;
        public virtual DbSet<LicenseActivationFailList> LicenseActivationFailLists { get; set; } = null!;
        public virtual DbSet<LicenseAlgorithmList> LicenseAlgorithmLists { get; set; } = null!;
        public virtual DbSet<LoginHistoryList> LoginHistoryLists { get; set; } = null!;
        public virtual DbSet<MottoList> MottoLists { get; set; } = null!;
        public virtual DbSet<ParameterList> ParameterLists { get; set; } = null!;
        public virtual DbSet<ReportList> ReportLists { get; set; } = null!;
        public virtual DbSet<ServerSetting> ServerSettings { get; set; } = null!;
        public virtual DbSet<TemplateList> TemplateLists { get; set; } = null!;
        public virtual DbSet<UnitList> UnitLists { get; set; } = null!;
        public virtual DbSet<UsedLicenseList> UsedLicenseLists { get; set; } = null!;
        public virtual DbSet<UserList> UserLists { get; set; } = null!;
        public virtual DbSet<UserRoleList> UserRoleLists { get; set; } = null!;
        public virtual DbSet<VatList> VatLists { get; set; } = null!;
        public virtual DbSet<ViewAttachmentList> ViewAttachmentLists { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MottoList>(entity =>
            {
                entity.ToTable("MottoList");

                entity.HasIndex(e => e.Id, "IX_MottoList")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParameterList>(entity =>
            {
                entity.ToTable("ParameterList");

                entity.HasIndex(e => new { e.Parameter, e.UserId }, "IX_ParameterList")
                    .IsUnique();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Parameter)
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParameterList_UserList");
            });

            modelBuilder.Entity<ReportList>(entity =>
            {
                entity.ToTable("ReportList");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.MimeType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportList_UserList");
            });

            modelBuilder.Entity<ServerSetting>(entity =>
            {
                entity.ToTable("ServerSetting");

                entity.Property(e => e.Key).HasMaxLength(150);

                entity.Property(e => e.Value).HasMaxLength(150);
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

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Role)
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
