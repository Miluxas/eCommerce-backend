﻿using System;
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
    public class Warehouse : BaseModel
    {
        [Required]
        public string Ml_Name { get; set; }
        public virtual IList<WarehouseArea> WarehouseAreas { get; set; }


        [NotMapped]
        public Dictionary<string, string> Name
        {
            get
            {
                if (Ml_Name == null)
                    return null;
                return JsonConvert.DeserializeObject<Dictionary<string,string>>(Ml_Name);
            }
            set 
            {
                Ml_Name = JsonConvert.SerializeObject(value);
            }
        }
    }
}
