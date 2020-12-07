using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("DeviceStatus")]
    public class DeviceStatus : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int DeviceStatusID { get; set; }
        [StringLength(50)]
        [DisplayName("وضعیت")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string DeviceStatusName { get; set; }
        [DisplayName("مرتب")]
        public int InOrder { get; set; }
        [DisplayName("زمان ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<LogBookDevice> logBookDevices { get; set; }

    }
}
