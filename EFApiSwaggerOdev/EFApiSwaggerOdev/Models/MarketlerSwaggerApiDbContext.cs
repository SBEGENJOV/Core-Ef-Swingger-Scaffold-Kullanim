using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFApiSwaggerOdev.Models
{
    public partial class MarketlerSwaggerApiDbContext : DbContext
    {
        public MarketlerSwaggerApiDbContext()
        {
        }

        public MarketlerSwaggerApiDbContext(DbContextOptions<MarketlerSwaggerApiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calisan> Calisans { get; set; } = null!;
        public virtual DbSet<Market> Markets { get; set; } = null!;
        public virtual DbSet<Sube> Subes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=MarketlerSwaggerApiDb;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calisan>(entity =>
            {
                entity.ToTable("Calisan");

                entity.Property(e => e.CalisanId).HasColumnName("CalisanID");

                entity.Property(e => e.CalisanAd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CalisanGorev)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketId).HasColumnName("MarketID");

                //entity.HasOne(d => d.Market)
                //    .WithMany(p => p.Calisans)
                //    .HasForeignKey(d => d.MarketId)
                //    .HasConstraintName("FK_Calisan_Market");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.ToTable("Market");

                entity.Property(e => e.MarketId).HasColumnName("MarketID");

                entity.Property(e => e.MarketAd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketAdres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketKod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubeId).HasColumnName("SubeID");

                //entity.HasOne(d => d.Sube)
                //    //.WithMany(p => p.Markets)
                //    .HasForeignKey(d => d.SubeId)
                //    .HasConstraintName("FK_Market_Sube");
            });

            modelBuilder.Entity<Sube>(entity =>
            {
                entity.ToTable("Sube");

                entity.Property(e => e.SubeId).HasColumnName("SubeID");

                entity.Property(e => e.SubeAd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubeKonum)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
