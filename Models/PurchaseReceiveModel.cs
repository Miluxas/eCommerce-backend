using eCommerce_backend.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce_backend.Models
{
    public class PurchaseReceiveModel
    {
        public Guid PurchaseId { get; set; }
        public Guid WarehouseId { get; set; }
        public List<PurchaseReceiveItemModel> Items { get; set; }
    }

    public class PurchaseReceiveItemModel
    {
        public Guid SkuId { get; set; }
        public int Qty { get; set; }
    }
}
