using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_backend.Data.Models
{
    public class PurchaseItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        public Guid PurchaseId { get; set; }
        [JsonIgnore]
        public virtual Purchase Purchase { get; set; }
        public Guid SkuId { get; set; }
        public virtual Sku Sku { get; set; }
        public int Qty { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
    }

}
