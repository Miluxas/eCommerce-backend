using System;
using System.Collections.Generic;

namespace eCommerce_backend.Models
{
    public class NewPurchase
    {
        public string Status { get; set; }
        public Guid SupplierId { get; set; }
        public string Type { get; set; }
        public List<NewPurchaseItem> Items { get; set; }
        public List<NewPurchaseEmail> EmailsTo { get; set; }
    }

    public class NewPurchaseItem
    {
        public Guid SkuId { get; set; }
        public int Qty { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
    }

    public class NewPurchaseEmail
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
