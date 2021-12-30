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
    public class Inventory : BaseModel
    {
        [Required]
        public Guid SkuId { get; set; }
        public virtual Sku Sku { get; set; }
        public Guid PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        [Required]
        public string Status { get; set; }

        public Guid WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal BuyPrice { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal SellPrice { get; set; }

    }
}
