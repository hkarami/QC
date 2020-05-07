using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models.Devices;

namespace LaboratoryQualityControl.Models
{
    [Table("IncubatorMaintenance")]
    public class IncubatorMaintenance : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int IncubatorMaintenanceID { get; set; }
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName("تاریخ")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime DoTime { get; set; }
        [DisplayName("کاربر انجام دهنده")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public int UserCodeFunctor { get; set; }
        [DisplayName("دما بر حسب درجه سانتی گراد-ساعت 8 ")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [Range(0,100,ErrorMessage = " {0} مقدار بین {0} و  ")]
        public Byte  Temperatures8 { get; set; }
        [DisplayName("دما بر حسب درجه سانتی گراد-ساعت 16 ")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [Range(0, 100, ErrorMessage = " {0} مقدار بین {0} و  ")]
        public Byte Temperatures16 { get; set; }
        [DisplayName("نظافت")]
        public bool Clean { get; set; }
        [DisplayName("ملاحظات")]
        [StringLength(200)]
        public string Description { get; set; }
        [DisplayName("کاربر تایید کننده")]
        public int UserCodeConfirm { get; set; }
        [DisplayName("کاربر ثبت رکورد")]
        public int UserCode { get; set; }
        [DisplayName("تاریخ آخرین تغییر")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        [ForeignKey("UserCodeFunctor")]
        [InverseProperty("FunctorUserIncubatorMaintenance")]
        public virtual User UserFunctor { get; set; }
        public virtual DeviceModel Device { get; set; }
        [ForeignKey("UserCodeConfirm")]
        [InverseProperty("UserConfirmIncubatorMaintenance")]
        public virtual User UserConfirm { get; set; }
        public virtual User User { get; set; }
    }
}
