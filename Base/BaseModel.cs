using System;
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
        public Guid Id { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = System.DateTime.Now;


        public Guid CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public virtual User CreatedBy { get; set; }

        [Required]
        public string DeleteStatus { get; set; } = Base.DeleteStatus.Default;
    }

    public class DeleteStatus
    {
        public const string Default = "Default";
        public const string Trash = "Trash";
        public const string Deleted = "Deleted";
    }
}
