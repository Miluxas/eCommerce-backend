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
    public class StatusHistory : BaseModel
    {
        public string Status { get; set; }
        public Int64 SetterID { get; set; }
        public string EntityName { get; set; }
        public DateTime SetAt { get; set; }
    }
}
