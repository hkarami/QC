using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models.DeviceTypes
{
    public class DeviceTypesResponseModel : ApiResult<List<DeviceTypeModel>>
    {
        #region [Ctor]
        public DeviceTypesResponseModel()
        {
            Data = new List<DeviceTypeModel>();
        }
        #endregion
    }
}
