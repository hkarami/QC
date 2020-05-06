using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.SpectrophotometerMaintenances
{
    public class SpectrophotometerMaintenanceService : BaseService<SpectrophotometerMaintenance>, ISpectrophotometerMaintenanceService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public SpectrophotometerMaintenanceService(LaboratoryQCContext dbContext, IRepository<SpectrophotometerMaintenance> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteSpectrophotometerMaintenance(SpectrophotometerMaintenance spectrophotometermaintenance)
        {
            if (spectrophotometermaintenance==null)
            {
                throw new ArgumentNullException(nameof(spectrophotometermaintenance));
            }
            MainRepository.Delete(spectrophotometermaintenance);
        }

        public IList<SpectrophotometerMaintenance> GetAllSpectrophotometerMaintenances()
        {
            return MainRepository.Table.ToList();
        }

        public SpectrophotometerMaintenance GetSpectrophotometerMaintenanceById(int spectrophotometermaintenanceid)
        {
            if (spectrophotometermaintenanceid==0)
            {
                return null;
            }
            return MainRepository.GetById(spectrophotometermaintenanceid);
        }

        public void InsertSpectrophotometerMaintenance(SpectrophotometerMaintenance spectrophotometermaintenance)
        {
            if (spectrophotometermaintenance==null)
            {
                throw new ArgumentNullException(nameof(spectrophotometermaintenance));
            }
            MainRepository.Insert(spectrophotometermaintenance);
        }

        public void UpdateSpectrophotometerMaintenance(SpectrophotometerMaintenance spectrophotometermaintenance)
        {
            if (spectrophotometermaintenance==null)
            {
                throw new ArgumentNullException(nameof(spectrophotometermaintenance));
            }
            MainRepository.Update(spectrophotometermaintenance);
        }
        #endregion
    }
}
