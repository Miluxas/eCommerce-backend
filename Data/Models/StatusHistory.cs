using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using eCommerce_backend.Base;
using eCommerce_backend.IdentityAuth;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace eCommerce_backend.Data.Models
{
    public class StatusHistory : BaseModel
    {
        public string Status { get; set; }
        public Guid SetterId { get; set; }
        public virtual ApplicationUser Setter { get; set; }
        public string EntityName { get; set; }
        public DateTime SetAt { get; set; }
    }
}
