using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("AnalyteMaterial")]
    public class AnalyteMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnalyteMaterialID { get; set; }
        [DisplayName("آنالیت")]
        public int AnalyteID { get; set; }
        [DisplayName("جنس")]
        public int MaterialID { get; set; }

        [DisplayName("کاربر ثبت کننده")]
        public int UserCode { get; set; }
        [DisplayName("ترتیب نمایش")]
        public int InOrder { get; set; }
        [DisplayName("تاریخ آخرین ویرایش")]
        public DateTime LastUpdateTime { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual Analyte Analyte { get; set; }
        public virtual Material Material { get; set; }
        public virtual User User { get; set; }
    }
}
