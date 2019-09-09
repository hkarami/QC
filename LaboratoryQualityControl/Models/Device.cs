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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
     //   [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        [DisplayName("نوع دستگاه")]
        public string DeviceType { get; set; }
     //   [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        [DisplayName("کارخانه")]
        public string Factory { get; set; }
     //   [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        [DisplayName("مدل")]
        public string Model { get; set; }
     //   [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [DisplayName("کشور سازنده")]
        public string ManufacturingCountry { get; set; }
    //    [Column(TypeName ="NVARCHAR")]
        [StringLength(30)]
        [DisplayName("شماره سریال")]
        public string SerialNumber { get; set; }
     //   [Column(TypeName ="NVARCHAR")]
        [StringLength(50)]
        [DisplayName("شرکت پشتیبان")]
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
        public DateTime DateSubmittedToLab { get; set; }
        [DisplayName("تاریخ راه اندازی در بخش")]
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
        [StringLength(11)]
        [DisplayName("تلفن تماس با شرکت پشتیبان")]
        public string PhoneToSupportCompany { get; set; }
        [DisplayName("کد بخش آزمایشگاه")]
        public int SectionCodeLab { get; set; }
     //   [Column(TypeName ="NVARCHAR")]
        [StringLength(200)]
        [DisplayName("سایر")]
        public string Other { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        public virtual LaboratorySections LaboratorySections { get; set; }
        public virtual ICollection<LogBookDevice> LogBookDevices { get; set; }
        public virtual ICollection<AutoclaveQualityControl> AutoclaveQualityControls { get; set; }
        public virtual ICollection<DeviceMaintenance> DeviceMaintenances { get; set; }
        public virtual ICollection<IncubatorMaintenance> IncubatorMaintenances { get; set; }
        public virtual ICollection<WaterBathMaintenance> WaterBathMaintenances { get; set; } 
        public virtual ICollection<SpectrophotometerMaintenance> SpectrophotometerMaintenances { get; set; }
        public virtual ICollection<PhotometerMaintenance> PhotometerMaintenances { get; set; }
        
    }
}   
