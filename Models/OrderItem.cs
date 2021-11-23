using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using eCommerce_backend.Base;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace eCommerce_backend.Models
{
    public class OrderItem
    {
        public Guid OrderID { get; set; }
        public Order Order { get; set; }
        public Guid SkuID { get; set; }
        public Sku Sku { get; set; }
        public int Qty { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Price { get; set; }
    }
}
