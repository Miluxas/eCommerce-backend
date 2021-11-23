using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Models;
using eCommerce_backend.Base;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using eCommerce_backend.IdentityAuth;
using Microsoft.AspNetCore.Identity;

namespace eCommerce_backend.Data
{

    public class IdentityContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid, IdentityUserClaim<Guid>,
ApplicationUserRole, IdentityUserLogin<Guid>,
IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options):base(options)
        { }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    
    }
}
