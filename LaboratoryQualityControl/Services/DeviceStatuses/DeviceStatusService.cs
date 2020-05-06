using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.DeviceStatuses
{
    public class DeviceStatusService : BaseService<DeviceStatus>, IDeviceStatusService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public DeviceStatusService(LaboratoryQCContext dbContext, IRepository<DeviceStatus> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteDeviceStatus(DeviceStatus devicestatus)
        {
            if (devicestatus==null)
            {
                throw new ArgumentNullException(nameof(devicestatus));
            }
            MainRepository.Delete(devicestatus);
        }

        public IList<DeviceStatus> GetAllDeviceStatuss()
        {
            return MainRepository.Table.ToList();
        }

        public DeviceStatus GetDeviceStatusById(int devicestatusid)
        {
            if (devicestatusid==0)
            {
                return null;
            }
            return MainRepository.GetById(devicestatusid);
        }

        public void InsertDeviceStatus(DeviceStatus devicestatus)
        {
            if (devicestatus==null)
            {
                throw new ArgumentNullException(nameof(devicestatus));
            }
            MainRepository.Insert(devicestatus);
        }

        public void UpdadteDeviceStatus(DeviceStatus devicestatus)
        {
            if (devicestatus==null)
            {
                throw new ArgumentNullException(nameof(devicestatus));
            }
            MainRepository.Update(devicestatus);
        }
        #endregion
    }
}
