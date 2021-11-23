using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_backend.IdentityAuth
{
    [Table("AspNetRoles")]

    public class ApplicationRole:IdentityRole<Guid>
    {
        public ApplicationRole(string roleName) : base(roleName) { }
        public ApplicationRole() : base() { }
    }
}