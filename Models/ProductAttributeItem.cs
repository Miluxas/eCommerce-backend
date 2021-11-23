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
    public class ProductAttributeItem
    {
        public Guid ProductID { get; set; }
        public Product Product { get; set; }
        public Guid AttributeItemID { get; set; }
        public AttributeItem AttributeItem { get; set; }
    }
}
