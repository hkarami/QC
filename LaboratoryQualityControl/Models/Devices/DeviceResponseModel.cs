using System.Collections.Generic;

namespace LaboratoryQualityControl.Models.Devices
{
    public class DevicesResponseModel : ApiResult<List<DeviceModel>>
    {
        #region [Ctor]
        public DevicesResponseModel()
        {
            Data = new List<DeviceModel>();
        }
        #endregion
    }
}
