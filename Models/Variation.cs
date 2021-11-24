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
    public class Variation : BaseModel
    {
        [Required]
        public string Ml_Name { get; set; }
        [Required]
        public int Type { get; set; }
        [InverseProperty("Variation")]
        public virtual ICollection<VariationItem> Items { get; set; }
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
    public class VariationItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid ID { get; set; }

        [Required]
        [ForeignKey("Variation")]
        public Guid VariationID { get; set; }
        public virtual Variation Variation { get; set; }
        [Required]
        public string Ml_Name { get; set; }
        public string Value { get; set; }
        public virtual IList<SkuVariationItem> SkuVariationItems { get; set; }

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
