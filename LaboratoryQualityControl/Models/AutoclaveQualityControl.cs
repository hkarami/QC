using LaboratoryQualityControl.Models.Devices;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Models
{
    [Table("AutoclaveQualityControl")]
    public class AutoclaveQualityControl : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int AutoclaveQualityControlID { get; set; }
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName(" تاریخ انجام")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime DoTime { get; set; }
        [DisplayName("کد کاربر انجام دهنده")]
        public int UserCodeFunctor { get; set; }
        [DisplayName("حرارت در زمان استقرار")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public Decimal HeatDuringDeployment { get; set; }
        [DisplayName("فشار در زمان استقرار")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public Decimal PressureDuringDeployment { get; set; }
        [DisplayName("هدف از استفاده")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [StringLength(100, ErrorMessage =" نمی تواند{0} بیشتر باشد")]
        public string PurposeOfUse { get; set; }
        [DisplayName("نتیجه تست شیمیایی TST")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [StringLength(100, ErrorMessage = "{0}  نمی تواند بیشتر باشد ")]
        public string ResultTST { get; set; }
        [DisplayName("نتیجه تست بیولوژیک")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
         [StringLength(100, ErrorMessage = "{0}  نمی تواند بیشتر باشد ")]
        public string ResultBiologic { get; set; }
        [DisplayName("ملاحظات")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [StringLength(100, ErrorMessage = "{0}  نمی تواند بیشتر باشد ")]
        public string Description { get; set; }
        [DisplayName("کد کاربر ثبت کننده")]
        public int UserCode { get; set; }
        [DisplayName("آخرین زمان تغییر")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }

        public virtual UserModel User { get; set; }
        public virtual DeviceModel Device { set; get; }
        [ForeignKey("UserCodeFunctor")]
        [InverseProperty("FunctorUserAutoclaveQualityControls")]
        public virtual UserModel UserFunctor { set; get; }


    }
}
