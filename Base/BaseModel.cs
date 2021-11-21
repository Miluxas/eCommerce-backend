using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Base
{
     
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Int64 ID { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        
        [Required]
        public Int64 CreatedByID { get; set; }
        
        [Required]
        public Int16 DeleteStatus { get; set; }
    }
}
