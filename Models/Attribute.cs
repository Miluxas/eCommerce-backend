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
    [Table("Attribute")]
    public class Attribute : BaseModel
    {
        [Required]
        public string Ml_Name { get; set; }

        public virtual IList<AttributeItem> Items { get; set; } = new List<AttributeItem>();
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

    [Table("AttributeItem")]
    public class AttributeItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid AttributeId { get; set; }
        [JsonIgnore]
        public virtual Attribute Attribute { get; set; }
        public string Ml_Name { get; set; }
        public virtual IList<ProductAttributeItem> ProductAttributeItems { get; set; }

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
