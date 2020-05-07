using System.Collections.Generic;

namespace LaboratoryQualityControl.Models.Devices
{
    public class DeviceResponseModel : ApiResult<List<DeviceModel>>
    {
        #region [Ctor]
        public DeviceResponseModel()
        {
            Data = new List<DeviceModel>();
        }
        #endregion
    }
}
