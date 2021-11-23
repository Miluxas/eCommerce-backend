using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

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
