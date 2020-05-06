using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.DeviceMaintenances
{
    public class DeviceMaintenanceService : BaseService<DeviceMaintenance>, IDeviceMaintenanceService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public DeviceMaintenanceService(LaboratoryQCContext dbContext, IRepository<DeviceMaintenance> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteDeviceMaintenance(DeviceMaintenance devicemaintenance)
        {
            if (devicemaintenance==null)
            {
                throw new ArgumentNullException(nameof(devicemaintenance));
            }
            MainRepository.Delete(devicemaintenance);
        }

        public IList<DeviceMaintenance> GetAllDeviceMaintenances()
        {
            return MainRepository.Table.ToList();
        }

        public DeviceMaintenance GetDeviceMaintenanceById(int devicemaintenanceid)
        {
            if (devicemaintenanceid==0)
            {
                return null;
            }
            return MainRepository.GetById(devicemaintenanceid);
        }

        public void InsertDeviceMaintenance(DeviceMaintenance devicemaintenance)
        {
            if (devicemaintenance == null)
            {
                throw new ArgumentNullException(nameof(devicemaintenance));
            }
            MainRepository.Insert(devicemaintenance);
        }

        public void UpdadteDeviceMaintenance(DeviceMaintenance devicemaintenance)
        {
            if (devicemaintenance==null)
            {
                throw new ArgumentNullException(nameof(devicemaintenance));
            }
            MainRepository.Update(devicemaintenance);
        }
        #endregion
    }
}
