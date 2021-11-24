﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eCommerce_backend.IdentityAuth;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Base
{
     
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid ID { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        
        public Guid CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public virtual User CreatedBy { get; set; }

        [Required]
        public Int16 DeleteStatus { get; set; }
    }
}
