using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("Roles")]
    public class Role : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد مجور")]
        public int RoleCode { get; set; }
        [DisplayName("نام مجوز")]
        [Required(ErrorMessage = " {0}  نمی تواند خالی باشد ")]
        public String RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
