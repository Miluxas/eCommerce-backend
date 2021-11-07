using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Models;

namespace eCommerce_backend.Data
{
    public class ECommerceContext:DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
        { }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
        }
    }
}
