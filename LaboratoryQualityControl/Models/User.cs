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
    [Table("Users")]
    public class User:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد کاربر")]
        public int UserCode { get; set; }
        [DisplayName("نام کاربری")]
        [Required, StringLength(20)]
        public string UserName { get; set; }
        [DisplayName("رمز عبور")]
        [Required, StringLength(20)]
        public String PassWord { get; set; }
        [DisplayName("کد مجوز")]
        public int RoleCode { get; set; }
        [DisplayName("نام خانوادگی")]
        [Required, StringLength(50)]
        public string LName { get; set; }
        [DisplayName("نام ")]
        [Required, StringLength(50)]
        public string FName { get; set; }
        [DisplayName("نام نمایشی ")]
        [Required, StringLength(50)]
        public string NickName { get; set; }
        [DisplayName("جنسیت ")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public bool Sex { get; set; }
        [DisplayName("تاریخ تولد")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime BirthDate { get; set; }
        [DisplayName("تاریخ انقضاء")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime ExpireTime { get; set; }
        [DisplayName("عکس")]
        public Byte[] Picture { get; set; }
        [DisplayName("تعداد ورود مجاز")]
        [Range(0, 255, ErrorMessage = "لطقا عدد بین 0 تا 255 وارد کنید")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public byte EnterNum { get; set; }
        [DisplayName("ایمیل")]
        //[Display(Name = " ایمیل ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("وضعیت تاهل")]
        public int MaritalStatusID { get; set; }
        [DisplayName("شماره شناسنامه")]
        public int NumberID { get; set; }
        [DisplayName("صادره")]
        [StringLength(50)]
        public string Issued { get; set; }
        [DisplayName("نام پدر")]
        [StringLength(50)]
        public String FatherName { get; set; }
        [DisplayName("مدرک")]
        public int EducationalCertificateID { get; set; }
        [DisplayName("نام دانشکاه")]
        [StringLength(50)]
        public string UniversityName { get; set; }
        [DisplayName("سال اخذ مدرک")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [StringLength(4, ErrorMessage = "{0} باید {1} رقم باشد", MinimumLength = 4)]
        //[StringLength(4)]
        //[MaxLength(4)]
        //[MinLength(4)]
        public String YearGet { get; set; }
        [DisplayName("آدرس")]
        [StringLength(200)]
        public String Address { get; set; }
        [DisplayName("تلفن")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [StringLength(11, ErrorMessage = "{0} باید {1} رقم باشد", MinimumLength = 10)]
        public string Telephone { get; set; }
        [DisplayName("شماره تماس  اضطراری")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [StringLength(11, ErrorMessage = "{0} باید {1} رقم باشد", MinimumLength = 10)]
        public String TelephoneNecessary { get; set; }
        [DisplayName("گروه خونی")]
        public int BloodTypeID { get; set; }
        [DisplayName("حساسیت دارویی")]
        public bool DrugSensitivity { get; set; }
        [DisplayName("تاریخ شروع به کار ")]
        public DateTime BeginTime { get; set; }
        [DisplayName("واحد محل خدمت")]
        public int SectionCodeLab { get; set; }
        [DisplayName("وضعیت استخدام")]
        public int EmploymentStatusID { get; set; }
        [DisplayName("سابقه واکسیناسیون")]
        public bool HistoryVaccination {get;set;}
        [DisplayName("سابقه آسیب شغلی")]
        public bool HistoryOfOccupationalInjury { get; set; }
        [DisplayName("توضیحات")]

        public string Description { get; set; }
        [DisplayName("جانشین")]
        public int? UserCodeSuccessor { get; set; }
        [DisplayName("کاربر ثبت کننده")]
        public int UserCodeSave { get; set; }
        [DisplayName("تاریخ آخرین تغییر")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        //public User UserCodeSuccessors { get; set; }
        //public User UserCodeSaves { get; set; }
        #region ForeignKey
        public virtual Role Role { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual EducationalCertificate EducationalCertificate { get; set; }
        public virtual BloodType BloodType { get; set; }
        public virtual LaboratorySection LaboratorySections { get; set; }
        public virtual EmploymentStatus EmploymentStatus { get; set; }
        #endregion
        public virtual ICollection<DeviceModel> Devices { get; set; }
        public virtual ICollection<LogBookDevice> LogBookDevices { get; set; }
        #region ServiceDevice
        public virtual ICollection<ServiceDevice> ServiceDevices { get; set; }
        public virtual ICollection<ServiceDevice> ConfirmUserServiceDevices { get; set; }
        public virtual ICollection<ServiceDevice> UserDisinfectantServiceDevices { get; set; }
        //public virtual ICollection<Analyte> Analytes { get; set; }
        public virtual ICollection<Material> Materials { get; set;}
        public virtual ICollection<AnalyteMaterial> AnalyteMaterials { get; set; }
        
        #endregion

        #region DeviceMaintenance
        public virtual ICollection<DeviceMaintenance> DeviceMaintenances { get; set; }
        public virtual ICollection<DeviceMaintenance> ConfirmUserDeviceMaintenances { get; set; }
        public virtual ICollection<DeviceMaintenance> FunctorUserDeviceMaintenances { get; set; }
        #endregion

        #region AutoclaveQualityControl
        public virtual ICollection<AutoclaveQualityControl> FunctorUserAutoclaveQualityControls { get; set; }
        public virtual ICollection<AutoclaveQualityControl> AutoclaveQualityControls { get; set; }
        #endregion

        #region IncubatorMaintenance
        public virtual ICollection<IncubatorMaintenance> FunctorUserIncubatorMaintenance { get; set; }
        public virtual ICollection<IncubatorMaintenance> UserConfirmIncubatorMaintenance { get; set; }
        public virtual ICollection<IncubatorMaintenance> IncubatorMaintenances { get; set; }
        #endregion

        #region WaterBathMaintenance
        public virtual ICollection<WaterBathMaintenance> UserFunctorWaterBathMaintenance { get; set; }
        public virtual ICollection<WaterBathMaintenance> UserConfirmWaterBathMaintenance { get; set; }
        public virtual ICollection<WaterBathMaintenance> WaterBathMaintenances { get; set; }
        #endregion

        #region SpectrophotometerMaintenanceUserConfirm
        public virtual ICollection<SpectrophotometerMaintenance> SpectrophotometerMaintenanceUserFunctor { get; set; }
        public virtual ICollection<SpectrophotometerMaintenance> SpectrophotometerMaintenanceUserConfirm { get; set; }
        public virtual ICollection <SpectrophotometerMaintenance> SpectrophotometerMaintenances { get; set; }
        #endregion
        #region PhotometerMaintenance
        public virtual ICollection<PhotometerMaintenance> PhotometerMaintenanceUserFunctor { get; set; }
        public virtual ICollection<PhotometerMaintenance> PhotometerMaintenanceUserConfirm { get; set; }
        public virtual ICollection<PhotometerMaintenance> PhotometerMaintenances { get; set; }
        #endregion
        #region Users

        #endregion

    }
}


