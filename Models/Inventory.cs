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
        public Guid SkuID { get; set; }
        public Sku Sku { get; set; }
        public Guid PurchaseID { get; set; }
        public Purchase Purchase { get; set; }
        public Guid OrderID { get; set; }
        public Order Order { get; set; }

        [Required]
        public string Status { get; set; }

        public Guid WarehouseID { get; set; }
        public Warehouse Warehouse { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal BuyPrice { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal SellPrice { get; set; }

    }
}
