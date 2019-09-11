using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("ServiceDevice")]

    public class ServiceDevice
    {
        [Key]
        [DisplayName("کد")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceDeviceID { get; set; }
        [DisplayName("دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName("تاریخ خروج از کار")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        
        public DateTime ExitTimeOfWork { get; set; }

        [DisplayName("تاریخ تماس با شرکت پشتیبان")]
        public DateTime ContactTimeForSupportCompany { get; set; }
        [DisplayName("فرد مسئول ضد عفونی ")]
        public int UserCodeDisinfectantDevice { get; set; }
        [DisplayName("تاریخ تعمیر")]
        public DateTime ServiceTime { get; set; }
        [DisplayName("شرکت پشتیبان")]
        public int SupportCompanyID { get; set; }
        [DisplayName("نام تعمیر کار ")]
        [StringLength(50)]
        public String ServiceMenName { get; set; }
        [DisplayName("کد محل تعمیر")]
        public int LocationServiceID { get; set; }
        [DisplayName("شرح تعمیر انجام شده")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد"),StringLength(200)]
        public String DescriptionOfRepairCompleted { get; set; }
        [DisplayName("تاریخ بازگشت به کار")]
        public DateTime TimeReturnToWork { get; set; }
        [DisplayName("تایید فنی قبل  ")]
        public int UserCodeConfirm { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        [DisplayName("کاربر ثبت")]
        public int UserCode { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        public virtual User User { get; set; }
        public virtual LocationService LocationService { get; set; }
        public virtual Device Device { get; set; }
        [ForeignKey("UserCodeConfirm")]
        [InverseProperty("ConfirmUserServiceDevices")]
        public virtual User ConfirmUser { get; set; }
        [ForeignKey("UserCodeDisinfectantDevice")]
        [InverseProperty("UserDisinfectantServiceDevices")]
        public virtual User UserDisinfectantDevice { get; set; }
        public virtual SupportCompany SupportCompany { get; set; }
    }
}
