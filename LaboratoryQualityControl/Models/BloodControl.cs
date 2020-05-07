using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Models
{
    public partial class BloodControl : BaseEntity
    {
        #region [Ctor]
        public BloodControl() : base()
        {
            BloodControlDetails = new HashSet<BloodControlDetail>();
        }
        #endregion
        #region [Properties]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BloodControlId { get; set; }
        public string Name { get; set; }
        public int? AnalyteId { get; set; }
        public int? MaterialId { get; set; }
        public string Lot { get; set; }
        public decimal? Mean { get; set; }
        public int? Number { get; set; }
        public decimal? CoefficientVariation { get; set; }
        public decimal? StandardDeviation { get; set; }
        public int? MinLockNumber { get; set; }
        public int? MaxLockNumber { get; set; }
        public decimal? LockMean { get; set; }
        public int? LockNumber { get; set; }
        public decimal? LockCoefficientVariation { get; set; }
        public decimal? LockStandardDeviation { get; set; }
        public bool? Active { get; set; }
        public int? UserCode { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public DateTime? RecordTime { get; set; }
        #endregion

        #region [Navigation Properties]
        public virtual Analyte Analyte { get; set; }
        public virtual Material Material { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BloodControlDetail> BloodControlDetails { get; set; }
        #endregion
    }
}
