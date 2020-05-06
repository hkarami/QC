using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.DeviceTypes
{
    public class DeviceTypeServie : BaseService<DeviceType>, IDeviceTypeServie
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public DeviceTypeServie(LaboratoryQCContext dbContext, IRepository<DeviceType> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteDeviceType(DeviceType devicetype)
        {
            if (devicetype==null)
            {
                throw new ArgumentNullException(nameof(devicetype));
            }
            MainRepository.Delete(devicetype);
        }

        public IList<DeviceType> GetAllDeviceTypes()
        {
            return MainRepository.Table.ToList();
        }

        public DeviceType GetDeviceTypeById(int devicetypeid)
        {
            if (devicetypeid==0)
            {
                return null;
            }
            return MainRepository.GetById(devicetypeid);
        }

        public void InsertDeviceType(DeviceType devicetype)
        {
            if (devicetype==null)
            {
                throw new ArgumentNullException(nameof(devicetype));
            }
            MainRepository.Insert(devicetype);
        }

        public void UpdadteDeviceType(DeviceType devicetype)
        {
            if (devicetype==null)
            {
                throw new ArgumentNullException(nameof(devicetype));
            }
            MainRepository.Update(devicetype);
        }
        #endregion
    }
}
