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
    public class WarehouseArea
    {
       
        public Guid WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public Guid AreaId { get; set; }
        public virtual Area Area { get; set; }
        public bool IsActive { get; set; }
        public int DeliveryMaxDay { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal DeliveryCost { get; set; }
    }
}
