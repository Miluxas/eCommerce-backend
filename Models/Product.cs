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
        public bool HasWrapping { get; set; }
        public bool HasGiftCard { get; set; }
        public bool HasCustomText { get; set; }
        public string Ml_Description { get; set; }
        public bool Taxable { get; set; }
        public Int64 SizeGuildID { get; set; }
        public bool IsStandardProduct { get; set; }
        public Int64 ApprovedBy { get; set; }
        public string Code { get; set; }

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
        [NotMapped]
        public List<Sku> Skus { get; set; }
        [NotMapped]
        public List<AttributeItem> AttributeItems { get; set; }
        [NotMapped]
        public List<Tag> Tags { get; set; }
        [NotMapped]
        public List<Badge> Badges { get; set; }
        [NotMapped]
        public List<Store> Stores { get; set; }
        [NotMapped]
        public List<Supplier> Suppliers { get; set; }
    }
}
