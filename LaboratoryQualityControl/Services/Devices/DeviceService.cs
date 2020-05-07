using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;
using Microsoft.EntityFrameworkCore;
namespace LaboratoryQualityControl.Services.Devices
{
    public class DeviceService : BaseService<Device>, IDeviceService
    {
        #region[Ctor]
        public DeviceService(LaboratoryQCContext dbContext, IRepository<Device> repository) : base(dbContext, repository)
        {

        }
        #endregion

        #region [Methodss]

        public void DeleteDevice(Device device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            MainRepository.Delete(device);
        }

        public IList<Device> GetAllDevice()
        {
            return DbContext.Devices.Include(device => device.DeviceType)
                                       .Include(device => device.User)
                                       .Include(device => device.LaboratorySections)
                                       .ToList();
        }

        public Device GetDeviceByID(int deviceCode)
        {
            if (deviceCode == 0)
                return null;

            var device = MainRepository.GetById(deviceCode);
            DbContext.Entry(device).Reference<User>(d => d.User).Load();
            DbContext.Entry(device).Reference<LaboratorySection>(d => d.LaboratorySections).Load();
            DbContext.Entry(device).Reference<DeviceType>(d => d.DeviceType).Load();

            return device;
        }

        public void InsertDevice(Device device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            MainRepository.Insert(device);
        }

        public async Task InsertDeviceAsync(Device device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            await MainRepository.InsertAsync(device);
        }

        public void UpdateDevice(Device device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            MainRepository.Update(device);
        }
        #endregion
    }
}
