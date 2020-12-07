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
    [Table("SpectrophotometerMaintenance")]
    public class SpectrophotometerMaintenance : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int SpectrophotometerMaintenanceID { get; set; }
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName("تاریخ انجام")]
        public DateTime DoTime { get; set; }
        [DisplayName("کد کاربر انجام دهنده")]
        public int UserCodeFunctor { get; set; }
        [DisplayName("تنظیم صفر دستگاه")]
        public bool SetDeviceZero { get; set; }
        [DisplayName("تمیز کردن لامپ")]
        public bool LightBulbClean { get; set; }
        [DisplayName("تعویض لامپ")]
        public bool BulbReplacement { get; set; }
        [DisplayName("تعویض آینه")]
        public bool MirrorSwitch { get; set; }
        [DisplayName("تمیز کردن آینه")]
        public bool MirrorClean { get; set; }
        [DisplayName("تنظیم آینه")]
        public bool MirrorAdjustment { get; set; }
        [DisplayName("ملاحظات")]
        [StringLength(200)]
        public String Description { get; set; }
        [DisplayName("کابر تایید کننده")]
        public int UserCodeConfirm { get; set; }
        [DisplayName("کاریر ثبت رکورد")]
        public int UserCode { get; set; }
        [DisplayName("آخرین تاریخ تغییر رکورد")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        #region ForeignKey
        public virtual DeviceModel Device { get; set; }
        [ForeignKey("UserCodeFunctor")]
        [InverseProperty("SpectrophotometerMaintenanceUserFunctor")]
        public virtual UserModel UserFunctor { get; set; }
        [ForeignKey("UserCodeConfirm")]
        [InverseProperty("SpectrophotometerMaintenanceUserConfirm")]
        public virtual UserModel UserConfirm { get; set; }
        public virtual UserModel User { get; set; }
        #endregion


    }
}
