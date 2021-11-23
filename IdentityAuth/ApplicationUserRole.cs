using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_backend.IdentityAuth
{
    [Table("AspNetUserRoles")]

    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
    }
}