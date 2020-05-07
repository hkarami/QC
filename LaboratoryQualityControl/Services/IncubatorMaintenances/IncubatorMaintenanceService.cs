using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.IncubatorMaintenances
{
    public class IncubatorMaintenanceService : BaseService<IncubatorMaintenance>, IIncubatorMaintenanceService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public IncubatorMaintenanceService(LaboratoryQCContext dbContext, IRepository<IncubatorMaintenance> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteIncubatorMaintenance(IncubatorMaintenance incubatormaintenance)
        {
            if (incubatormaintenance==null)
            {
                throw new ArgumentNullException(nameof(incubatormaintenance));
            }
            MainRepository.Delete(incubatormaintenance);
        }

        public IList<IncubatorMaintenance> GetAllIncubatorMaintenances()
        {
            return MainRepository.Table.ToList();
        }

        public IncubatorMaintenance GetIncubatorMaintenanceById(int incubatormaintenanceid)
        {
            if (incubatormaintenanceid==0)
            {
                return null;
            }
            return MainRepository.GetById(incubatormaintenanceid);
        }

        public void InsertIncubatorMaintenance(IncubatorMaintenance incubatormaintenance)
        {
            if (incubatormaintenance==null)
            {
                throw new ArgumentNullException(nameof(incubatormaintenance));
            }
            MainRepository.Insert(incubatormaintenance);
        }

        public void UpdateIncubatorMaintenance(IncubatorMaintenance incubatormaintenance)
        {
            if (incubatormaintenance==null)
            {
                throw new ArgumentNullException(nameof(incubatormaintenance));
            }
            MainRepository.Update(incubatormaintenance);
        }
        #endregion
    }
}
