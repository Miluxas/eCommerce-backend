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
   
    public class PurchaseReceive
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        public Guid PurchaseId { get; set; }
        [JsonIgnore]
        public virtual Purchase Purchase { get; set; }
        [Required]
        public Guid WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public Guid ReciveById { get; set; }
        public virtual IdentityAuth.ApplicationUser ReceiveBy { get; set; }
        public DateTime ReceiveAt { get; set; }
        [InverseProperty("PurchaseReceive")]
        public virtual IList<PurchaseReceiveItem> Items { get; set; }=new List<PurchaseReceiveItem>();
    }
}
