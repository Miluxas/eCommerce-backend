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
    public class Store : BaseModel
    {
        [Required]
        public string Ml_Name { get; set; }
        public string Md_Image { get; set; }
        public virtual IList<ProductStore> ProductStores { get; set; }

        [NotMapped]

        public Media? Image
        {
            get
            {
                if (Md_Image != null)
                    return JsonConvert.DeserializeObject<Media>(Md_Image);
                return null;

            }
            set
            {
                if (value != null)
                    Md_Image = JsonConvert.SerializeObject(value);
                else
                    Md_Image = "";
            }
        }
        [NotMapped]
        public Dictionary<string, string> Name
        {
            get
            {
                return JsonConvert.DeserializeObject<Dictionary<string,string>>(Ml_Name);
            }
            set 
            {
                Ml_Name = JsonConvert.SerializeObject(value);
            }
        }
    }
}
