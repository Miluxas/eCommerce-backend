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
    public class Purchase : BaseModel
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public Int64 SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        [Required]
        public Int64 WaerhouseID { get; set; }
        public Warehouse Warehouse { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string InvoiceType { get; set; }

        public Int64 ApprovedByID { get; set; }
        public IdentityAuth.ApplicationUser ApprovedBy { get; set; }
        public DateTime ApprovedAt { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal TotalPrice { get; set; }



        [InverseProperty("Purchase")]
        public IList<PurchaseItem> Items { get; set; }
        [InverseProperty("Purchase")]
        public IList<PurchaseReceive> PurchaseReceives { get; set; }
    }
    public class PurchaseItem
    {
        public Int64 PurchaseID { get; set; }
        public Purchase Purchase { get; set; }
        public Int64 SkuID { get; set; }
        public Sku Sku { get; set; }
        public int Qty { get; set; }
    }
    public class PurchaseReceive
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Int64 ID { get; set; }
        public Int64 PurchaseID { get; set; }
        public Purchase Purchase { get; set; }
        public Int64 ReciveByID { get; set; }
        public IdentityAuth.ApplicationUser ReceiveBy { get; set; }
        public DateTime ReceiveAt { get; set; }
        [InverseProperty("PurchaseReceive")]
        public IList<PurchaseReceiveItem> Items { get; set; }
    }
    public class PurchaseReceiveItem
    {
        public Int64 PurchaseReceiveID { get; set; }
        public PurchaseReceive PurchaseReceive { get; set; }
        public Int64 SkuID { get; set; }
        public Sku Sku { get; set; }
        public int Qty { get; set; }
    }
}
