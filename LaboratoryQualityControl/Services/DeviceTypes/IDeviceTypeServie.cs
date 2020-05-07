using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.DeviceTypes
{
    interface IDeviceTypeServie
    {
        #region [Methods]
        DeviceType GetDeviceTypeById(int devicetypeid);

        void DeleteDeviceType(DeviceType devicetype);

        IList<DeviceType> GetAllDeviceTypes();

        void InsertDeviceType(DeviceType devicetype);

        void UpdadteDeviceType(DeviceType devicetype);

        #endregion
    }
}
