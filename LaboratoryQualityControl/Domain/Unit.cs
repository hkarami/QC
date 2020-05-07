using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("Unit")]
    public class Unit : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UnitID  {get;set;}
        [DisplayName("واحد")]
        [StringLength(200)]
        public string UnitName { get; set; }
        [DisplayName("وضعیت نمایش")]
        public bool Visible { get; set; }
        [DisplayName("ترتیب نمایش")]
        public int InOrder { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<Analyte> Analytes { get; set; }

    }
}
