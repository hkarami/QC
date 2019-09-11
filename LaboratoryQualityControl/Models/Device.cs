using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace LaboratoryQualityControl.Models
{
    [Table("Device")]
    public class Device
    {
        #region Properties  
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
        //   [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        [DisplayName("نام دستگاه")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string DeviceName { get; set; }
        [DisplayName("نوع دستگاه")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public int DeviceTypeID { get; set; }
        //   [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        [DisplayName("کارخانه")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string Factory { get; set; }
        //   [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        [DisplayName("مدل")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string Model { get; set; }
        //   [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [DisplayName("کشور سازنده")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string ManufacturingCountry { get; set; }
        //    [Column(TypeName ="NVARCHAR")]
        [StringLength(30)]
        [DisplayName("شماره سریال")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string SerialNumber { get; set; }
        //   [Column(TypeName ="NVARCHAR")]
        [StringLength(50)]
        [DisplayName("شرکت پشتیبان")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string SupportCompany { get; set; }
        //   [Column(TypeName ="NVARCHAR")]
        [StringLength(100)]
        [DisplayName("محل استقرار")]
        public string Location { get; set; }
        //   [Column(TypeName ="NVARCHAR")]
        [StringLength(100)]
        [DisplayName("کاربران ویژه")]
        public string FeaturedUsers { get; set; }
        //   [Column(TypeName ="NVARCHAR")]
        [StringLength(30)]
        [DisplayName("کد شناسایی")]
        public string IdentificationCode { get; set; }
        [DisplayName("تاریخ رسید به آزمایشگاه")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime DateSubmittedToLab { get; set; }
        [DisplayName("تاریخ راه اندازی در بخش")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime SectionLaunchDATE { get; set; }
        //    [Column(TypeName ="NVARCHAR")]
        [StringLength(30)]
        [DisplayName("شرایط دستگاه در موقع تحویل")]
        public string DeliveryStatus { get; set; }
        //    [Column(TypeName ="NVARCHAR")]
        [StringLength(200)]
        [DisplayName("ویژگی خاص")]
        public string SpecialCharacteristic { get; set; }
        //   [Column(TypeName ="NVARCHAR")]
        [StringLength(200)]
        [DisplayName("تجهیزات مرتبط")]
        public string RelatedEquipment { get; set; }
        //   [Column(TypeName ="NVARCHAR")]
       // [StringLength(11)]
        [DisplayName("تلفن تماس با شرکت پشتیبان")]
        [StringLength(11, ErrorMessage = "{0} باید {1} رقم باشد", MinimumLength = 10)]
        public string PhoneToSupportCompany { get; set; }
        [DisplayName(" بخش آزمایشگاه")]
        public int SectionCodeLab { get; set; }
        //   [Column(TypeName ="NVARCHAR")]
        [StringLength(200)]
        [DisplayName("سایر")]
        public string Other { get; set; }
        [DisplayName("کاربر")]
        public int UserCode { get; set; }
        [DisplayName("تاریخ آخرین تغییر")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        #endregion
        #region by_ForeignKey
        public virtual LaboratorySections LaboratorySections { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        public virtual User User { get; set; }
        #endregion

        #region ForeignKey_by
        public virtual ICollection<ServiceDevice> ServiceDevices { get; set; }
        public virtual ICollection<LogBookDevice> LogBookDevices { get; set; }
        public virtual ICollection<AutoclaveQualityControl> AutoclaveQualityControls { get; set; }
        public virtual ICollection<DeviceMaintenance> DeviceMaintenances { get; set; }
        public virtual ICollection<IncubatorMaintenance> IncubatorMaintenances { get; set; }
        public virtual ICollection<WaterBathMaintenance> WaterBathMaintenances { get; set; }
        public virtual ICollection<SpectrophotometerMaintenance> SpectrophotometerMaintenances { get; set; }
        public virtual ICollection<PhotometerMaintenance> PhotometerMaintenances { get; set; }
        #endregion
    }


}   
