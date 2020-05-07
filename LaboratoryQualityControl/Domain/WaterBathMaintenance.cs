using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("WaterBathMaintenance")]
    public class WaterBathMaintenance : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int WaterBathMaintenanceID { get; set; }
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName("تاریخ")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime DoTime { get; set; }
        [DisplayName("کاربر انجام دهنده")]
        public int UserCodeFunctor { get; set; }
        [DisplayName("دما")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [Range(0, 100, ErrorMessage = " {0} مقدار بین {0} و  ")]
        public byte Temperatures { get; set; }
        [DisplayName("تعویض آب")]
        public bool WaterExchange { get; set; }
        [DisplayName("رسوب گیری")]
        public bool Sedimentation { get; set; }
        [DisplayName("نظافت ")]
        public bool Clean { get; set; }
        [DisplayName("کاربر تایید کننده")]
        public int UserCodeConfirm { get; set; }
        [DisplayName("ملاحظات")]
        [StringLength(200)]
        public string Description { get; set; }
        [DisplayName("کاربر ثبت کننده")]
        public int UserCode { get; set; }
        [DisplayName("تاریخ آخرین تغییر")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual Device Device { get; set; } 
        [ForeignKey("UserCodeFunctor")]
        [InverseProperty("UserFunctorWaterBathMaintenance")]
        public virtual User UserFunctor { get; set; }
        [ForeignKey("UserCodeConfirm")]
        [InverseProperty("UserConfirmWaterBathMaintenance")]
        public virtual User UserConfirm { get; set; }
        public virtual User User { get; set; }
    }
}
