﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("Analyte")]
    public class Analyte : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnalyteID { get; set; }
        [DisplayName("آنالیت")]
        [StringLength(50)]
        public string AnalyteName { get; set; }
        [DisplayName("ضمیمه")]
        [StringLength(50)]
        public string Appedix { get; set; }
        [DisplayName("سطح")]
        [Range(1, 3)]
        [StringLength(3, MinimumLength = 1)]
        public byte Levels { get; set; }
        [DisplayName("واحد")]
        public int UnitID { get; set; }
        [DisplayName("تعداد رقم اعشار")]
        [Range(0, 3)]
        [StringLength(3, MinimumLength = 0)]
        public byte Decimals { get; set; }
        [DisplayName("حداقل مقدار")]
        public int Min { get; set; }
        [DisplayName("حداکثر مقدار")]
        public int Max { get; set; }
        [DisplayName("قوانین")]
        public byte RulesQCID { get; set; }
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
        public virtual User User { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual RulesQC RulesQC { get; set; }
        public virtual ICollection<AnalyteMaterial> AnalyteMaterials { get; set; }

    }
}
