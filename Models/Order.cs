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
    public class Order : BaseModel
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public string Status { get; set; }

        public Guid UserID { get; set; }
        public virtual IdentityAuth.ApplicationUser User { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal SubTotal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Shipping { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Pay { get; set; }
        public string Obj_ExteraDetail { get; set; }
        
        [NotMapped]
        public ExtraDetail? ExteraDetail
        {
            get
            {
                if (Obj_ExteraDetail != null)
                    return JsonConvert.DeserializeObject<ExtraDetail>(Obj_ExteraDetail);
                return null;

            }
            set
            {
                if (value != null)
                    Obj_ExteraDetail = JsonConvert.SerializeObject(value);
                else
                    Obj_ExteraDetail = "";
            }
        }


        [InverseProperty("Order")]
        public virtual IList<OrderItem> Items { get; set; } 
    }
    public class ExtraDetail
    {
        public List<dynamic> Items { get; set; }
        public dynamic Customer { get; set; }
        public dynamic Address { get; set; }
        public dynamic Coupon { get; set; }


    }
}
