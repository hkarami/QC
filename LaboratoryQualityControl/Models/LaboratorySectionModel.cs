using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LaboratoryQualityControl.Models
{
    public class LaboratorySectionModel : BaseModel
    {
        #region [Properties]
        [DisplayName("کد بخش آزمایشگاه")]
        public int SectionCodeLab { get; set; }
        
        [StringLength(50)]
        [DisplayName("نام بخش آزمایشگاه")]
        public string SectionNameLab { get; set; }
        
        [DisplayName("ترتیب نمایش")]
        public int InOrder { get; set; }
        
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime{ get; set; }
        #endregion
    }
}
