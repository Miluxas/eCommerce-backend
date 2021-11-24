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
    public class ProductTag
    {
       
        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }
        public Guid TagID { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
