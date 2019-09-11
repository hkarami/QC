using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("SupportCompany")]
    public class SupportCompany
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int SupportCompanyID { get; set; }
        [StringLength(50)]
        [DisplayName("شرکت پشتیبان")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string SupportCompanyName { get; set; }
        [DisplayName("وضعیت نمایشی")]
        public bool Visible { get; set; }
        [DisplayName("مرتب")]
        public int InOrder { get; set; }
        [DisplayName("زمان ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<ServiceDevice> ServiceDevices { get; set; }


    }
}
