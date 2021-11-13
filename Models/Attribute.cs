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

namespace eCommerce_backend.Models
{
    [Table("Attribute")]
    public class Attribute : BaseModel
    {
        public string Ml_Name { get; set; }
        [NotMapped]
        public List<AttributeItem> Items
        {
            get; set;
        }
        [NotMapped]
        public Dictionary<string, string> Name
        {
            get
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(Ml_Name);
            }
            set
            {
                Ml_Name = JsonConvert.SerializeObject(value);
            }
        }
    }

    [Table("AttributeItem")]
    public class AttributeItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Int64 ID { get; set; }
        public Int64 AttributeID { get; set; }
        public string Ml_Name { get; set; }
        [NotMapped]
        public Dictionary<string, string> Name
        {
            get
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(Ml_Name);
            }
            set
            {
                Ml_Name = JsonConvert.SerializeObject(value);
            }
        }
    }
}
