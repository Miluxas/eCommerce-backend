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

namespace eCommerce_backend.Data.Models
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public Guid SkuId { get; set; }
        public virtual Sku Sku { get; set; }
        public int Qty { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Price { get; set; }
    }
}
