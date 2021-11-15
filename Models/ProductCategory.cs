using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using eCommerce_backend.Base;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace eCommerce_backend.Models
{
    public class ProductCategory
    {
        public Int64 ID { get; set; }
        public Int64 ProductID { get; set; }
        public Int64 StoreID { get; set; }
        public Int64 CountryID { get; set; }
    }
}
