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
    public class Category : BaseModel
    {
        public string Ml_Name { get; set; }
        public string MM_Image { get; set; }
        public Int64 ParentID { get; set; }



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
        public Dictionary<string, string> Image
        {
            get
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(MM_Image);
            }
            set
            {
                MM_Image = JsonConvert.SerializeObject(value);
            }
        }
    }
}
