using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("PhotometerMaintenance")]
    public class PhotometerMaintenance : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int PhotometerMaintenanceID { get; set; }
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName("تاریخ انجام")]
        public DateTime DoTime { get; set; }
        [DisplayName("کاربر انجام دهنده")]
        public int UserCodeFunctor { get; set; }
        [DisplayName("شست و شوی دستگاه")]
        public bool DeviceWash { get; set; }
        [DisplayName("محل اتصال گاز")]
        public bool GasJunction { get; set; }
        [DisplayName("لوله ها و مکنده ها")]
        public bool PipesAndSuckers { get; set; }
        [DisplayName("فیلتر")]
        public bool Filter { get; set; }
        [DisplayName("شیشه")]
        public bool Glass { get; set; }
        [DisplayName("کوره")]
        public bool Kiln { get; set; }
        [DisplayName("دودکش")]
        public bool Chimney { get; set; }
        [DisplayName("تنظیم صفر دستگاه")]
        public bool SetDeviceZero { get; set; }
        [DisplayName("نشتی لوله ها ")]
        public bool pipeLeaky { get; set; }
        [DisplayName("تعویض هر یک از اجزا ")]
        public bool ReplaceAnyComponent { get; set; }
        [DisplayName("تخلیه ظروف پسماند")]
        public bool DischargeDishesWaste { get; set; }
        [DisplayName("کمپرسور")]
        public bool Compressor { get; set; }
        [DisplayName("ملاحظات")]
        [StringLength(200)]
        public String Description { get; set; }
        [DisplayName("کاربر تایید کننده")]
        public int UserCodeConfirm { get; set; }
        [DisplayName("کاربر ثبت رکورد")]
        public int UserCode { get; set; }
        [DisplayName("زمان آخرین تغییر رکورد")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("زمان ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        #region ForeignKey
        public virtual Device Device { get; set; }
        [ForeignKey("UserCodeFunctor")]
        [InverseProperty("PhotometerMaintenanceUserFunctor")]
        public virtual User UserFunctor { get; set; }
        [ForeignKey("UserCodeConfirm")]
        [InverseProperty("PhotometerMaintenanceUserConfirm")]
        public virtual User UserConfirm { get; set; }
        public virtual User User { get; set; }

        #endregion



    }
}
