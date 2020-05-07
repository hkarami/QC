using System.Collections.Generic;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.Devices
{
    public interface IDeviceService
    {
        #region [Methods]
         Device GetDeviceByID(int deviceCode);
        void DeleteDevice(Device device);
        IList<Device> GetAllDevice();
        void UpdateDevice(Device device);
        void InsertDevice(Device device);
        Task InsertDeviceAsync(Device device);
        #endregion
    }
}
