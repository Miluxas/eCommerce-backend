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
    public class ProductBadge
    {
        public Int64 ProductID { get; set; }
        public Product Product { get; set; }

        public Int64 BadgeID { get; set; }
        public Badge Badge { get; set; }
    }
}
