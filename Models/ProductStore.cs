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
    public class ProductStore
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public Guid StoreId { get; set; }
        public virtual Store Store { get; set; }
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
