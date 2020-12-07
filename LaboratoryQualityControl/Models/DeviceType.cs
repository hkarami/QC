using LaboratoryQualityControl.Models.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LaboratoryQualityControl.Models
{
    public class DeviceTypeModel : BaseModel
    {
        #region[Properties]
        [DisplayName("کد")]
        public int DeviceTypeID { get; set; }

        [DisplayName("نوع تجهیزات")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string DeviceTypeName { get; set; }

        [DisplayName("مرتب")]
        public int InOrder { get; set; }

        [DisplayName("زمان ثبت رکورد")]
        public DateTime RecordTime { get; set; }

        public virtual ICollection<DeviceModel> Devices { get; set; }

        #endregion
    }
}
