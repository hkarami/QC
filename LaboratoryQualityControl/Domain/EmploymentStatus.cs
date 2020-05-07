using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("EmploymentStatus")]
    public class EmploymentStatus : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int EmploymentStatusID { get; set; }
        [DisplayName("عنوان استخدام")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public String EmploymentStatusName { get; set; }
        [DisplayName("مرتب")]
        public int InOrder { get; set; }
        [DisplayName("زمان ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
