using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.ServiceDevices
{
    public class ServiceDeviceService : BaseService<ServiceDevice>, IServiceDeviceService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public ServiceDeviceService(LaboratoryQCContext dbContext, IRepository<ServiceDevice> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteServiceDevice(ServiceDevice servicedevice)
        {
            if (servicedevice==null)
            {
                throw new ArgumentNullException(nameof(servicedevice));
            }
            MainRepository.Delete(servicedevice);
        }

        public IList<ServiceDevice> GetAllServiceDevices()
        {
            return MainRepository.Table.ToList();
        }

        public ServiceDevice GetServiceDeviceById(int servicedeviceid)
        {
            if (servicedeviceid==0)
            {
                return null;
            }
            return MainRepository.GetById(servicedeviceid);
        }

        public void InsertServiceDevice(ServiceDevice servicedevice)
        {
            if (servicedevice==null)
            {
                throw new ArgumentNullException(nameof(servicedevice));
            }
            MainRepository.Insert(servicedevice);
        }

        public void UpdateServiceDevice(ServiceDevice servicedevice)
        {
            if (servicedevice==null)
            {
                throw new ArgumentNullException(nameof(servicedevice));
            }
            MainRepository.Update(servicedevice);
        }
        #endregion
    }
}
