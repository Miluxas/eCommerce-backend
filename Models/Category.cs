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
    [Table("Category")]
    public class Category : BaseModel
    {
        [Required]
        public string Ml_Name { get; set; }
        [Required]
        public string Mm_Image { get; set; }
        [ForeignKey("Parent")]
        public Guid? ParentID { get; set; }
        public Category Parent { get; set; }

        public IList<ProductCategory> ProductCategories { get; set; }


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

        [NotMapped]
        public Dictionary<string, Media>? Image
        {
            get
            {
                if (Mm_Image!=null)
                    return JsonConvert.DeserializeObject<Dictionary<string, Media>>(Mm_Image);
                return null;

            }
            set
            {
                if (value != null)
                    Mm_Image = JsonConvert.SerializeObject(value);
                else
                    Mm_Image = "";
            }
        }
    }
}
