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

namespace eCommerce_backend.Data.Models
{
    public class Product : BaseModel
    {
        [Required]
        public string Ml_Name { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public bool HasWrapping { get; set; }
        [Required]
        public bool HasGiftCard { get; set; }
        [Required]
        public bool HasCustomText { get; set; }
        public string Ml_Description { get; set; }
        [Required]
        public bool Taxable { get; set; }
        public Guid SizeGuildId { get; set; }
        [Required]
        public bool IsStandardProduct { get; set; }
        public Guid ApprovedBy { get; set; }
        public string Code { get; set; }
        public Guid BrandId { get; set; }
        public virtual Brand Brand { get; set; }


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
        public virtual IList<Sku> Skus { get; set; }=new List<Sku>();
        public virtual IList<ProductAttributeItem> ProductAttributeItems { get; set; }
        public virtual IList<ProductBadge> ProductBadges { get; set; }
        public virtual IList<ProductCategory> ProductCategories { get; set; }
        public virtual IList<ProductCountry> ProductCountries { get; set; }
        public virtual IList<ProductStore> ProductStores { get; set; }
        public virtual IList<ProductSupplier> ProductSuppliers { get; set; }
        public virtual IList<ProductTag> ProductTags { get; set; }


    }
}
