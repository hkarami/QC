using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.DeviceMaintenances
{
    interface IDeviceMaintenanceService
    {
        #region [Methods]
        DeviceMaintenance GetDeviceMaintenanceById(int devicemaintenanceid);

        void DeleteDeviceMaintenance(DeviceMaintenance devicemaintenance);

        IList<DeviceMaintenance> GetAllDeviceMaintenances();

        void InsertDeviceMaintenance(DeviceMaintenance devicemaintenance);

        void UpdadteDeviceMaintenance(DeviceMaintenance devicemaintenance);

        #endregion
    }
}
