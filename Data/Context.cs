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
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<AttributeItem> AttributeItems { get; set; }
        public DbSet<Variation> Variations { get; set; }
        public DbSet<VariationItem> VariationItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Models.Attribute>().ToTable("Attribute");
            modelBuilder.Entity<AttributeItem>().ToTable("AttributeItem");
            modelBuilder.Entity<Variation>().ToTable("Variation");
            modelBuilder.Entity<VariationItem>().ToTable("VariationItem");
        }
    }
}
