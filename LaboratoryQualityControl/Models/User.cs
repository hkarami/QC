using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد کاربر")]
        public int UserCode { get; set; }
        [DisplayName("نام کاربری")]
        [Required,StringLength(20)]
        public string UserName { get; set; }
        [DisplayName("رمز عبور")]
        [Required,StringLength(20)]
        public String PassWord { get; set; }
        [DisplayName("کد مجوز")]
        public int RoleCode { get; set; }
        [DisplayName("نام خانوادگی")]
        [Required,StringLength(50)]
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
        [Range(0,255, ErrorMessage = "لطقا عدد بین 0 تا 255 وارد کنید")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public Int16 EnterNum { get; set; }
        [DisplayName("ایمیل")]
        //[Display(Name = " ایمیل ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("تلفن")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [StringLength(11,ErrorMessage = "{0} باید {1} رقم باشد", MinimumLength =10)]
        public string Telephone { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<LogBookDevice> LogBookDevices { get; set; }

    }
}
