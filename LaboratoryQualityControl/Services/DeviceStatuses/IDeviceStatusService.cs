using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.DeviceStatuses
{
    interface IDeviceStatusService
    {
        #region [Methods]
        DeviceStatus GetDeviceStatusById(int devicestatusid);

        void DeleteDeviceStatus(DeviceStatus devicestatus);

        IList<DeviceStatus> GetAllDeviceStatuss();

        void InsertDeviceStatus(DeviceStatus devicestatus);

        void UpdadteDeviceStatus(DeviceStatus devicestatus);

        #endregion
    }
}
