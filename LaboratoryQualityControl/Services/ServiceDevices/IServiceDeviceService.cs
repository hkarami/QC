using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.ServiceDevices
{
    interface IServiceDeviceService
    {
        #region [Methods]
        ServiceDevice GetServiceDeviceById(int servicedeviceid);

        void DeleteServiceDevice(ServiceDevice servicedevice);
        IList<ServiceDevice> GetAllServiceDevices();

        void InsertServiceDevice(ServiceDevice servicedevice);

        void UpdateServiceDevice(ServiceDevice servicedevice);

        #endregion
    }
}
