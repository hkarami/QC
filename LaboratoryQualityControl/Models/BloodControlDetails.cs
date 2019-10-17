using System;
using System.Collections.Generic;

namespace LaboratoryQualityControl.Models
{
    public partial class BloodControlDetails
    {
        #region [Ctor]
        public BloodControlDetails()
        {

        }
        #endregion

        #region [Properties]
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
