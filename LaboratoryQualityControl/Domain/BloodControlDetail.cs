﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    public partial class BloodControlDetail : BaseEntity
    {
        #region [Ctor]
        public BloodControlDetail()
        {

        }
        #endregion

        #region [Properties]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BloodControlDetailsId { get; set; }
        public int? BloodControlId { get; set; }
        public decimal? Value { get; set; }
        public int? RulesQcdetailsId { get; set; }
        public string Description { get; set; }
        public bool? Reject { get; set; }
        public int? UserCode { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public DateTime? RecordTime { get; set; }

        #endregion

        #region [Navigation Properties]
        public virtual BloodControl BloodControl { get; set; }
        public virtual RulesQCDetails RulesQcdetails { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
