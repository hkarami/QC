using System;
using System.Collections.Generic;

namespace LaboratoryQualityControl.Models2
{
    public partial class BloodControlDetails
    {
        public int BloodControlDetailsId { get; set; }
        public int? BloodControlId { get; set; }
        public decimal? Value { get; set; }
        public int? RulesQcdetailsId { get; set; }
        public string Description { get; set; }
        public bool? Reject { get; set; }
        public int? UserCode { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public DateTime? RecordTime { get; set; }

        public virtual BloodControl BloodControl { get; set; }
        public virtual RulesQcdetails RulesQcdetails { get; set; }
        public virtual Users UserCodeNavigation { get; set; }
    }
}
