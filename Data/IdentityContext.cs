using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Models;
using eCommerce_backend.Base;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace eCommerce_backend.Data
{

    public class IdentityContext : IdentityDbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options):base(options)
        { }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
