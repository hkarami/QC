using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LaboratoryQualityControl.Models.Devices
{
    public class DeviceModel : BaseModel
    {
        #region [Properties]  
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }

        [StringLength(100)]
        [DisplayName("نام دستگاه")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string DeviceName { get; set; }


        [DisplayName("نوع دستگاه")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public int DeviceTypeID { get; set; }

        public string DeviceTypeName { get; set; }

        [StringLength(100)]
        [DisplayName("کارخانه")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string Factory { get; set; }

        [StringLength(100)]
        [DisplayName("مدل")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string Model { get; set; }

        [StringLength(50)]
        [DisplayName("کشور سازنده")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string ManufacturingCountry { get; set; }

        [StringLength(30)]
        [DisplayName("شماره سریال")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        [DisplayName("شرکت پشتیبان")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string SupportCompany { get; set; }

        [StringLength(100)]
        [DisplayName("محل استقرار")]
        public string Location { get; set; }

        [StringLength(100)]
        [DisplayName("کاربران ویژه")]
        public string FeaturedUsers { get; set; }

        [StringLength(30)]
        [DisplayName("کد شناسایی")]
        public string IdentificationCode { get; set; }

        [DisplayName("تاریخ رسید به آزمایشگاه")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime DateSubmittedToLab { get; set; }

        [DisplayName("تاریخ راه اندازی در بخش")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime SectionLaunchDate { get; set; }

        [StringLength(30)]
        [DisplayName("شرایط دستگاه در موقع تحویل")]
        public string DeliveryStatus { get; set; }

        [StringLength(200)]
        [DisplayName("ویژگی خاص")]
        public string SpecialCharacteristic { get; set; }

        [StringLength(200)]
        [DisplayName("تجهیزات مرتبط")]
        public string RelatedEquipment { get; set; }

        [DisplayName("تلفن تماس با شرکت پشتیبان")]
        [StringLength(11, ErrorMessage = "{0} باید {1} رقم باشد", MinimumLength = 10)]
        public string PhoneToSupportCompany { get; set; }
       
        [DisplayName(" بخش آزمایشگاه")]
        public int LaboratorySectionId { get; set; }

        public string LaboratorySectionName { get; set; }
        
        [StringLength(200)]
        [DisplayName("سایر")]
        public string Other { get; set; }
        
        [DisplayName("کاربر")]
        public int UserId { get; set; }

        public string UserFullName { get; set; }

        [DisplayName("تاریخ آخرین تغییر")]
        public DateTime UpdateRecordTime { get; set; }
        
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        #endregion

        #region [List Properties]
        public IList<LaboratorySectionModel> LaboratorySections { get; set; }
        
        public IList<DeviceTypeModel> DeviceTypes { get; set; }
        
        public IList<UserModel> Users { get; set; }
        #endregion
    }
}
