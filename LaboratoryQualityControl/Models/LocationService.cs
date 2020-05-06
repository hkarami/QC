using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("LocationService")]
    public class LocationService : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int LocationServiceID { get; set; }
        [DisplayName("نام محل")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد"),StringLength(50)]
        public String LocationServiceName { get; set; }
        [DisplayName("وضعیت نمایش")]
        public bool Visible { get; set; }
        [DisplayName("ترتیب نمایش")]
        public int InOrder { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<ServiceDevice> ServiceDevices { get; set; }
    }
}
