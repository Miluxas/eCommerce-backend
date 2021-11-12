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
    public class Attribute : BaseModel
    {
        public string Ml_Name { get; set; }
    }
    public class AttributeItem
    {
        public Int64 ID { get; set; }
        public Int64 AttributeID { get; set; }
        public string Ml_Name { get; set; }
    }
}
