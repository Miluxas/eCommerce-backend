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
    public class Product : BaseModel
    {
        public string Ml_Name { get; set; }
        public int Type { get; set; }
        [NotMapped]
        public List<Sku> Skus
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
    public class Sku
    {
        public Int64 ID { get; set; }
        public Int64 ProductID { get; set; }
        public string Ml_Name { get; set; }
        public string Value { get; set; }
        public string Md_Images { get; set; }
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
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(Ml_Name);
            }
            set
            {
                Ml_Name = JsonConvert.SerializeObject(value);
            }
        }

    }
}
