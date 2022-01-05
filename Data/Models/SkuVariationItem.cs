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
    public class SkuVariationItem
    {
        public Guid SkuId { get; set; }
        public virtual Sku Sku { get; set; }
        public Guid VariationItemId { get; set; }
        public virtual VariationItem VariationItem { get; set; }

    }
}
