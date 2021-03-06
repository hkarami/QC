﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("RulesQC")]
    public class RulesQC : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte RulesQCID { get; set; }
        [DisplayName("نام قوانین")]
        [StringLength(50)]
        public string Name { get; set; }
        [DisplayName("وضعیت نمایش")]
        public bool Visible { get; set; }
        [DisplayName("ترتیب نمایش")]
        public byte InOrder { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<RulesQCDetails> RulesQCDetails { get; set; }
        public virtual ICollection<Analyte> Analytes { get; set; }
    }
}
