using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("Shift")]
    public class Shift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShiftID { get; set; }
        [DisplayName("شیفت")]
        public string ShiftName { get; set; }
        [DisplayName("ترتیب")]
        public int InOrder { get; set; }
        [DisplayName("وضعیت نمایش")]
        public bool Visible { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<LogBookDevice> logBookDevices { get; set; }
            
    }
}
