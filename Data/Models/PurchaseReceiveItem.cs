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
    public class PurchaseReceiveItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }=Guid.NewGuid();
        public Guid PurchaseReceiveId { get; set; }
        [JsonIgnore]
        public virtual PurchaseReceive PurchaseReceive { get; set; }
        public Guid SkuId { get; set; }
        public virtual Sku Sku { get; set; }
        public int Qty { get; set; }
    }
}
