using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("LaboratorySections")]
    public class LaboratorySection : BaseEntity
    {
        [Key]
        [DisplayName("کد بخش آزمایشگاه")]
        public int SectionCodeLab { get; set; }
        //[Column(TypeName="NVARCHAR")]
        [StringLength(50)]
        [DisplayName("نام بخش آزمایشگاه")]
        public string SectionNameLab { get; set; }
        [DisplayName("ترتیب نمایش")]
        public int InOrder { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime{ get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
