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

namespace eCommerce_backend.Models
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
        public Guid SizeGuildID { get; set; }
        [Required]
        public bool IsStandardProduct { get; set; }
        public Guid ApprovedBy { get; set; }
        public string Code { get; set; }
        public Guid BrandID { get; set; }
        public Brand Brand { get; set; }


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
        [InverseProperty("Product")]
        public ICollection<Sku> Skus { get; set; }
        public IList<ProductAttributeItem> ProductAttributeItems { get; set; }
        public IList<ProductBadge> ProductBadges { get; set; }
        public IList<ProductCategory> ProductCategories { get; set; }
        public IList<ProductCountry> ProductCountries { get; set; }
        public IList<ProductStore> ProductStores { get; set; }
        public IList<ProductSupplier> ProductSuppliers { get; set; }
        public IList<ProductTag> ProductTags { get; set; }


    }
}
