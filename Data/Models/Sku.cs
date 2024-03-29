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
    public class Sku
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductId { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
        [Required]
        public string Ml_Name { get; set; }
        public string Value { get; set; }
        public string Md_Images { get; set; }
        public virtual IList<SkuVariationItem> SkuVariationItems { get; set; }
        [NotMapped]

        public List<Media>? Images
        {
            get
            {
                if (Md_Images != null)
                    return JsonConvert.DeserializeObject<List<Media>>(Md_Images);
                return null;

            }
            set
            {
                if (value != null)
                    Md_Images = JsonConvert.SerializeObject(value);
                else
                    Md_Images = "";
            }
        }

        [NotMapped]
        public Dictionary<string, string> Name
        {
            get
            {
                if(Ml_Name!=null)
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(Ml_Name);
                return null;
            }
            set
            {
                Ml_Name = JsonConvert.SerializeObject(value);
            }
        }

    }
}
