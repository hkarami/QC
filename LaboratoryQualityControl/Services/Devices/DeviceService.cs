using System;
using LaboratoryQualityControl.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;

namespace LaboratoryQualityControl.Services.Devices
{
    public class DeviceService: BaseService<Device>,IDeviceService
    {
        public DeviceService(LaboratoryQCContext dbContext, IRepository<Device> repository) : base(dbContext, repository)
        {

        }

        public void DeleteDevice(Device device)
        {
            if (device == null)
            {
                throw new ArgumentNullException(nameof(device));
            }
            MainRepository.Delete(device);
        }

        public IList<Device> GetAllDevice()
        {
            return MainRepository.Table.ToList();
        }

        public Device GetDeviceByID(int deviceode)
        {
            if (deviceode == 0)
            {
                return null;
            }
            return MainRepository.GetById(deviceode);
        }
        
        public void InsertDevice(Device device)
        {
            if (device == null)
            {
                throw new ArgumentNullException(nameof(device));
            }
            MainRepository.Insert(device);

        }

        public void UpdateDevice(Device device)
        {
            if (device == null)
            {
                throw new ArgumentNullException(nameof(device));
            }
            MainRepository.Update(device);
        }
    }
}
