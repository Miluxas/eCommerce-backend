using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_backend.IdentityAuth
{
    [Table("AspNetUsers")]
    public class ApplicationUser : IdentityUser<Guid>
    {
    }
    public class UserRoles
    {
        static public string Admin = "Admin";
        static public string User = "User";

    }
}
