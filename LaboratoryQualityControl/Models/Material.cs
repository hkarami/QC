using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("Material")]
    public class Material : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialID { get; set; }
        [DisplayName("جنس")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string MaterialName { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string Lot { get; set; }
        [DisplayName("تاریخ انقضا")]
        public DateTime ExpireTime { get; set; }
        [DisplayName("وضعیت نمایش")]
        public bool Visible { get; set; }

        [DisplayName("کاربر ثبت کننده")]
        public int UserCode { get; set; }
        [DisplayName("ترتیب نمایش")]
        public int InOrder { get; set; }
        [DisplayName("تاریخ آخرین ویرایش")]
        public DateTime LastUpdateTime { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<AnalyteMaterial> AnalyteMaterials { get; set; }

    }
}
