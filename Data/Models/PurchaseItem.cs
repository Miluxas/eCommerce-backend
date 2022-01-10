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
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public Guid PurchaseId { get; set; }
        [JsonIgnore]
        public virtual Purchase Purchase { get; set; }
        [Required]
        public Guid SkuId { get; set; }
        public virtual Sku Sku { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 5)")]
        public decimal BuyPrice { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 5)")]
        public decimal SellPrice { get; set; }
    }

}
