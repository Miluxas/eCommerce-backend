using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Models;
using eCommerce_backend.Base;

namespace eCommerce_backend.Data
{
    public class ECommerceContext:DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
        { }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<AttributeItem> AttributeItems { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Variation> Variations { get; set; }
        public DbSet<VariationItem> VariationItems { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttributeItem> ProductAttributeItems { get; set; }
        public DbSet<ProductBadge> ProductBadges { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductCountry> ProductCountries { get; set; }
        public DbSet<ProductStore> ProductStores { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Sku> Skus { get; set; }
        public DbSet<SkuVariationItem> SkuVariationItems { get; set; }
        public DbSet<StatusHistory> StatusHistories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Badge>().ToTable("Badge");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Models.Attribute>().ToTable("Attribute");
            modelBuilder.Entity<AttributeItem>().ToTable("AttributeItem");
            modelBuilder.Entity<Variation>().ToTable("Variation");
            modelBuilder.Entity<VariationItem>().ToTable("VariationItem");
            modelBuilder.Entity<Store>().ToTable("Store");
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ProductAttributeItem>().ToTable("ProductAttributeItem");
            modelBuilder.Entity<ProductBadge>().ToTable("ProductBadge");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<ProductCountry>().ToTable("ProductCountry");
            modelBuilder.Entity<ProductStore>().ToTable("ProductStore");
            modelBuilder.Entity<ProductSupplier>().ToTable("ProductSupplier");
            modelBuilder.Entity<ProductTag>().ToTable("ProductTag");
            modelBuilder.Entity<Sku>().ToTable("Sku");
            modelBuilder.Entity<SkuVariationItem>().ToTable("SkuVariationItem");
            modelBuilder.Entity<StatusHistory>().ToTable("StatusHistory");

        }
    }
}
