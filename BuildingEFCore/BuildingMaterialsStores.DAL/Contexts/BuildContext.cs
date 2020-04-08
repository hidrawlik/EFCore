using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using BuildingMaterialsStores.DAL.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace BuildingMaterialsStores.DAL
{
    public partial class BuildContext : DbContext
    {
        public BuildContext()
        {
        }

        public BuildContext(DbContextOptions<BuildContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsInStocks> ProductsInStocks { get; set; }
        public virtual DbSet<StockStore> StockStore { get; set; }
        public virtual DbSet<Stocks> Stocks { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<Streets> Streets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Не працює, а повинно.. Перевірив у класі Program:

            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            optionsBuilder.UseSqlServer(MyConnection.Connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductsInStocks>(entity =>
            {
                entity.HasKey(e => new { e.Stock, e.Product })
                    .HasName("PK_Product_Stock");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.ProductsInStocks)
                    .HasForeignKey(d => d.Product)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductsInStocks_Products");

                entity.HasOne(d => d.StockNavigation)
                    .WithMany(p => p.ProductsInStocks)
                    .HasForeignKey(d => d.Stock)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductsInStocks_Stocks");
            });

            modelBuilder.Entity<StockStore>(entity =>
            {
                entity.HasKey(e => new { e.StockId, e.StoreId })
                    .HasName("PK_Склад_Магазин");

                entity.ToTable("Stock_Store");

                entity.Property(e => e.StockId).HasColumnName("Stock_id");

                entity.Property(e => e.StoreId).HasColumnName("Store_id");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.StockStore)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_Store_Stocks");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StockStore)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_Store_Stores");
            });

            modelBuilder.Entity<Stocks>(entity =>
            {
                entity.HasIndex(e => new { e.Street, e.HouseNumber })
                    .HasName("UIX_Street_HouseNumber")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.StreetNavigation)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.Street)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stocks_Streets");
            });

            modelBuilder.Entity<Stores>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.StreetNavigation)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.Street)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stores_Streets");
            });

            modelBuilder.Entity<Streets>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
