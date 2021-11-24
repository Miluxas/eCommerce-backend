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
        public Guid SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        [Required]
        public Guid WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string InvoiceType { get; set; }

        public Guid ApprovedByID { get; set; }
        public virtual IdentityAuth.ApplicationUser ApprovedBy { get; set; }
        public DateTime ApprovedAt { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal TotalPrice { get; set; }



        [InverseProperty("Purchase")]
        public virtual IList<PurchaseItem> Items { get; set; }
        [InverseProperty("Purchase")]
        public virtual IList<PurchaseReceive> PurchaseReceives { get; set; }
    }
    public class PurchaseItem
    {
        public Guid PurchaseID { get; set; }
        public virtual Purchase Purchase { get; set; }
        public Guid SkuID { get; set; }
        public virtual Sku Sku { get; set; }
        public int Qty { get; set; }
    }
    public class PurchaseReceive
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid ID { get; set; }
        public Guid PurchaseID { get; set; }
        public virtual Purchase Purchase { get; set; }
        public Guid ReciveByID { get; set; }
        public virtual IdentityAuth.ApplicationUser ReceiveBy { get; set; }
        public DateTime ReceiveAt { get; set; }
        [InverseProperty("PurchaseReceive")]
        public virtual IList<PurchaseReceiveItem> Items { get; set; }
    }
    public class PurchaseReceiveItem
    {
        public Guid PurchaseReceiveID { get; set; }
        public virtual PurchaseReceive PurchaseReceive { get; set; }
        public Guid SkuID { get; set; }
        public virtual Sku Sku { get; set; }
        public int Qty { get; set; }
    }
}
