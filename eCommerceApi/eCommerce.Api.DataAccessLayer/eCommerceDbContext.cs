using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using eCommerce.Api.Models;

namespace eCommerce.Api.DataAccessLayer
{
    public class eCommerceDbContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public eCommerceDbContext(string connectionString)
        {
            this._connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this._connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API entity mapping
            modelBuilder.Entity<Category>().ToTable("Category", "dbo");
            modelBuilder.Entity<Supplier>().ToTable("Supplier", "dbo");
            modelBuilder.Entity<Customer>().ToTable("Customer", "dbo");
            modelBuilder.Entity<Product>().ToTable("Product", "dbo");
            modelBuilder.Entity<Order>().ToTable("Order", "dbo");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail", "dbo");
        }

    }
}
