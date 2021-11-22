using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eCommerce_backend.IdentityAuth
{
    public class ApplicationUser : IdentityUser
    {
    }
    public class UserRoles
    {
        static public string Admin = "Admin";
        static public string User = "User";

    }
}
