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
    public class Country : BaseModel
    {
        [Required]
        public string Ml_Name { get; set; }
        public virtual IList<ProductCountry> ProductCountries { get; set; }
        public virtual IList<ProductStore> ProductStores { get; set; }
        public virtual IList<ProductSupplier> ProductSuppliers { get; set; }
        public virtual IList<Area> Areas { get; set; }


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
