using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using eCommerce_backend.Base;
using eCommerce_backend.IdentityAuth;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace eCommerce_backend.Data.Models
{
    public class Brand : BaseModel
    {
        [Required]
        public string Ml_Name { get; set; }
        [Required]
        public string Md_Image { get; set; }

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
        [Required]
        public Dictionary<string, string> Name
        {
            get
            {
                if (Ml_Name != null)
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
