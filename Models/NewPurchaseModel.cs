using eCommerce_backend.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce_backend.Models
{
    public class NewPurchaseModel
    {
        public string Status { get; set; }
        
        public Guid SupplierId { get; set; }
        public string Type { get; set; } = PurchaseType.Purchase;
        [Required(ErrorMessage = "TransactionType is required"),]
        public string TransactionType { get; set; } = PurchaseTransactionType.Entry;
        public List<NewPurchaseItemModel> Items { get; set; }
        public List<NewPurchaseEmailModel> EmailsTo { get; set; }
    }

    public class NewPurchaseItemModel
    {
        public Guid SkuId { get; set; }
        public int Qty { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
    }

    public class NewPurchaseEmailModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
