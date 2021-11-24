using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eCommerce_backend.IdentityAuth;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_backend.IdentityAuth
{
    [Table("ApplicationUser")]
    public class User 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

    }
}
