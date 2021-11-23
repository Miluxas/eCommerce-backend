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
    public class WarehouseArea
    {
       
        public Guid WarehouseID { get; set; }
        public Warehouse Warehouse { get; set; }
        public Guid AreaID { get; set; }
        public Area Area { get; set; }
        public bool IsActive { get; set; }
        public int DeliveryMaxDay { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal DeliveryCost { get; set; }
    }
}
