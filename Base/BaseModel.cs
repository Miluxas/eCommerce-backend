using eCommerce_backend.IdentityAuth;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
        public DateTime CreatedAt { get; set; } = DateTime.Now;


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
