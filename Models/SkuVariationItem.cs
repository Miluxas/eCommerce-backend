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
    public class SkuVariationItem
    {
        public Guid SkuID { get; set; }
        public Sku Sku { get; set; }
        public Guid VariationItemID { get; set; }
        public VariationItem VariationItem { get; set; }

    }
}
