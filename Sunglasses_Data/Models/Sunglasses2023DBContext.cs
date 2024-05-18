using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Sunglasses_Repository.Models
{
    public partial class Sunglasses2023DBContext : DbContext
    {
        public Sunglasses2023DBContext()
        {
        }

        public Sunglasses2023DBContext(DbContextOptions<Sunglasses2023DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Sunglass> Sunglasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
            var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];

            return strConn;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.MemberAccountId)
                    .HasName("PK__Account__0FB64058FF1C29EC");

                entity.ToTable("Account");

                entity.HasIndex(e => e.MemberEmail, "UQ__Account__3F37B77ADACAFE6A")
                    .IsUnique();

                entity.Property(e => e.MemberAccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemberAccountID");

                entity.Property(e => e.MemberAccountPassword)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.MemberEmail).HasMaxLength(100);

                entity.Property(e => e.MemberFullName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.Property(e => e.ManufacturerId).HasMaxLength(30);

                entity.Property(e => e.ManufacturerDescription)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ManufacturerName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Sunglass>(entity =>
            {
                entity.HasKey(e => e.SunglassesId)
                    .HasName("PK__Sunglass__4C4C38EAB043CB6C");

                entity.Property(e => e.SunglassesId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Feature).HasMaxLength(220);

                entity.Property(e => e.ManufacturerId).HasMaxLength(30);

                entity.Property(e => e.Material).HasMaxLength(40);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Shape).HasMaxLength(40);

                entity.Property(e => e.SunglassesName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Sunglasses)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Sunglasse__Manuf__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
