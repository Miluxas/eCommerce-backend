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
        public Guid SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        [Required]
        public Guid WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [Required]
        public string Status { get; set; } = PurchaseStatus.Draft;
        [Required]
        public string TransactionType { get; set; } = PurchaseTransactionType.Entry;
        [Required]
        public string Type { get; set; } = PurchaseType.Purchase;

        public Guid ApprovedById { get; set; }
        public virtual IdentityAuth.ApplicationUser ApprovedBy { get; set; }
        public DateTime ApprovedAt { get; set; }
        public decimal TotalPrice { get;  }


        [InverseProperty("Purchase")]
        public virtual IList<PurchaseItem> Items { get; set; }
        [InverseProperty("Purchase")]
        public virtual IList<PurchaseReceive> PurchaseReceives { get; set; }
    }

    public class PurchaseType
    {
        public const string Purchase = "Purchase";
        public const string Consignment = "Consignment";
        public const string Return = "Return";
    }
    public class PurchaseTransactionType
    {
        public const string Entry = "Entry";
        public const string Exit = "Exit";
    }
    public class PurchaseStatus
    {
        public const string Draft = "Draft";
        public const string Pending = "Pending";
        public const string Approved = "Approved";
    }
}
