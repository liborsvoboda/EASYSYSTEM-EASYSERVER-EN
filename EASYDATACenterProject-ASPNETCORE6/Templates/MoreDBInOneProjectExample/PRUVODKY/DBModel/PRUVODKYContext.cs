using System;
using System.Collections.Generic;
using BACKENDCORE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRUVODKY.DBModel
{
    public partial class PRUVODKYContext : DbContext
    {
        public PRUVODKYContext()
        {
        }

        public PRUVODKYContext(DbContextOptions<PRUVODKYContext> options)
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

                optionsBuilder.UseSqlServer("Server=192.168.1.141;Database=PRUVODKY;User ID=pruvodky;Password=pruvodky;",
                  //optionsBuilder.UseSqlServer(Program.ServerSettings.DbConnectionString,
                  x => x.MigrationsHistoryTable("MigrationsHistory", "dbo"))
                //.UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }))
                //.LogTo(message => Debug.WriteLine(message))
                //.LogTo(Console.WriteLine)
                ;
            }
        }

        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<GroupList> GroupLists { get; set; } = null!;
        public virtual DbSet<LoginHistoryList> LoginHistoryLists { get; set; } = null!;
        public virtual DbSet<MottoList> MottoLists { get; set; } = null!;
        public virtual DbSet<OperationList> OperationLists { get; set; } = null!;
        public virtual DbSet<PartList> PartLists { get; set; } = null!;
        public virtual DbSet<PersonList> PersonLists { get; set; } = null!;
        public virtual DbSet<ReportList> ReportLists { get; set; } = null!;
        public virtual DbSet<ServerSetting> ServerSettings { get; set; } = null!;
        public virtual DbSet<TemplateList> TemplateLists { get; set; } = null!;
        public virtual DbSet<UserList> UserLists { get; set; } = null!;
        public virtual DbSet<UserRoleList> UserRoleLists { get; set; } = null!;
        public virtual DbSet<VisitorIpList> VisitorIpLists { get; set; } = null!;
        public virtual DbSet<VisitorList> VisitorLists { get; set; } = null!;
        public virtual DbSet<WorkList> WorkLists { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<GroupList>(entity =>
            {
                entity.ToTable("GroupList");

                entity.HasIndex(e => e.Name, "IX_GroupList")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GroupLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_GroupList_UserList");
            });

            modelBuilder.Entity<LoginHistoryList>(entity =>
            {
                entity.ToTable("LoginHistoryList");

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

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

                entity.HasIndex(e => e.Name, "IX_MottoList")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationList>(entity =>
            {
                entity.ToTable("OperationList");

                entity.HasIndex(e => new { e.WorkPlace, e.OperationNumber }, "IX_OperationList")
                    .IsUnique();

                entity.Property(e => e.KcPerKs).HasColumnType("numeric(10, 4)");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OperationLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OperationList_UserList");
            });

            modelBuilder.Entity<PartList>(entity =>
            {
                entity.ToTable("PartList");

                entity.HasIndex(e => new { e.WorkPlace, e.Number }, "IX_PartList")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PartLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PartList_UserList");
            });

            modelBuilder.Entity<PersonList>(entity =>
            {
                entity.ToTable("PersonList");

                entity.HasIndex(e => e.PersonalNumber, "IX_PersonList")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PersonLists)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonList_GroupList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PersonLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PersonList_UserList");
            });

            modelBuilder.Entity<ReportList>(entity =>
            {
                entity.ToTable("ReportList");

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

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

            modelBuilder.Entity<UserList>(entity =>
            {
                entity.ToTable("UserList");

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

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

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisitorIpList>(entity =>
            {
                entity.ToTable("VisitorIpList");

                entity.Property(e => e.VisitorIp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VisitorIpNavigation)
                    .WithMany(p => p.VisitorIpLists)
                    .HasPrincipalKey(p => p.VisitorIp)
                    .HasForeignKey(d => d.VisitorIp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitorIpList_VisitorList");
            });

            modelBuilder.Entity<VisitorList>(entity =>
            {
                entity.ToTable("VisitorList");

                entity.HasIndex(e => e.VisitorIp, "IX_VisitorList")
                    .IsUnique();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.VisitorIp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhoIs).HasColumnType("text");
            });

            modelBuilder.Entity<WorkList>(entity =>
            {
                entity.ToTable("WorkList");

                entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.WorkPower).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_WorkList_UserList");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
