using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("LogBookDevice")]
    public class LogBookDevice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLogBook { get; set; } 
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName(" کاربر")]
        public int UserCode { get; set; }
        [DisplayName("شیفت")]
        public int ShiftID { get; set; }
        [DisplayName("تاریخ")]
        public DateTime DoTime { get; set; }
        [DisplayName("زمان شروع استفاده")]
        public DateTime StartTime { get; set; }
        [DisplayName("زمان خاتمه استفاده")]
        public DateTime EndTime { get; set; }
        [DisplayName("وضعیت دستگاه در زمان استفاده")]
        public int DeviceStatusID { get; set; }
        [StringLength(200)]
        [DisplayName("توضیحات")]
        public String Description { get; set; }
         [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual User User { get; set; }
        public virtual Device Device { get; set; }
        public virtual DeviceStatus deviceStatus { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
