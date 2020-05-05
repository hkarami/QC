using LaboratoryQualityControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Services.Devices
{
    interface IDeviceService
    {
        #region [Methods]
        Device GetDeviceByID(int DeviceCode);
        void DeleteDevice(Device device);
        IList<Device> GetAllDevice();
        void UpdateDevice(Device device);
        void InsertDevice(Device device);
        #endregion



    }
}
