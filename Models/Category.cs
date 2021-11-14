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
    [Table("Category")]
    public class Category : BaseModel
    {
        public string Ml_Name { get; set; }
        public string Mm_Image { get; set; }
        public Int64? ParentID { get; set; }



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
