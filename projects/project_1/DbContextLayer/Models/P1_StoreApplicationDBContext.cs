using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ModelsLayer.EFModels;

#nullable disable

namespace DbContextLayer.Models
{
    public partial class P1_StoreApplicationDBContext : DbContext
    {
        public P1_StoreApplicationDBContext()
        {
        }

        public P1_StoreApplicationDBContext(DbContextOptions<P1_StoreApplicationDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookGenre> BookGenres { get; set; }
        public virtual DbSet<BookType> BookTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=P1_StoreApplicationDB;Trusted_Connection=True;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.Property(e => e.BookId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BookID");

                entity.Property(e => e.BookGenreId).HasColumnName("BookGenreID");

                entity.Property(e => e.BookPrice).HasColumnType("money");

                entity.Property(e => e.BookTypeId).HasColumnName("BookTypeID");

                entity.HasOne(d => d.BookGenre)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.BookGenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_BookGenre");

                entity.HasOne(d => d.BookType)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.BookTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_BookType");
            });

            modelBuilder.Entity<BookGenre>(entity =>
            {
                entity.ToTable("BookGenre");

                entity.Property(e => e.BookGenreId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BookGenreID");

                entity.Property(e => e.BookGenre1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BookGenre");
            });

            modelBuilder.Entity<BookType>(entity =>
            {
                entity.ToTable("BookType");

                entity.Property(e => e.BookTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BookTypeID");

                entity.Property(e => e.BookType1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BookType");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CustomerID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Book");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Store");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");

                entity.Property(e => e.StoreId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StoreID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
