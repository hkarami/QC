using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.PhotometerMaintenances
{
    public class PhotometerMaintenanceService : BaseService<PhotometerMaintenance>, IPhotometerMaintenanceService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public PhotometerMaintenanceService(LaboratoryQCContext dbContext, IRepository<PhotometerMaintenance> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeletePhotometerMaintenance(PhotometerMaintenance photometermaintenance)
        {
            if (photometermaintenance==null)
                throw new ArgumentNullException(nameof(photometermaintenance));
            MainRepository.Delete(photometermaintenance);
        }

        public IList<PhotometerMaintenance> GetAllPhotometerMaintenances()
        {
            return MainRepository.Table.ToList();
        }

        public PhotometerMaintenance GetPhotometerMaintenanceById(int photometermaintenanceid)
        {
            if (photometermaintenanceid == 0)
                return null;
            return MainRepository.GetById(photometermaintenanceid);
 
        }

        public void InsertPhotometerMaintenance(PhotometerMaintenance photometermaintenance)
        {
            if (photometermaintenance == null)
                throw new ArgumentNullException(nameof(photometermaintenance));
            MainRepository.Insert(photometermaintenance);
        }

        public void UpdatePhotometerMaintenance(PhotometerMaintenance photometermaintenance)
        {
            if (photometermaintenance==null)
            {
                throw new ArgumentNullException(nameof(photometermaintenance));
            }
            MainRepository.Update(photometermaintenance);
        }
        #endregion
    }
}
