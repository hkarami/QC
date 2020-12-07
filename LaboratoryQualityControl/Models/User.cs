using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LaboratoryQualityControl.Models
{
    public class UserModel:BaseModel
    {
        #region[Properties]
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
        #endregion

    }
}


