using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.WaterBathMaintenances
{
    public class WaterBathMaintenanceService : BaseService<WaterBathMaintenance>, IWaterBathMaintenanceService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public WaterBathMaintenanceService(LaboratoryQCContext dbContext, IRepository<WaterBathMaintenance> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteWaterBathMaintenance(WaterBathMaintenance waterbathmaintenance)
        {
            if (waterbathmaintenance== null)
            {
                throw new ArgumentNullException(nameof(waterbathmaintenance));
            }
            MainRepository.Delete(waterbathmaintenance);

        }

        public IList<WaterBathMaintenance> GetAllWaterBathMaintenances()
        {
            return MainRepository.Table.ToList();
        }

        public WaterBathMaintenance GetWaterBathMaintenanceById(int waterbathmaintenanceid)
        {
            if (waterbathmaintenanceid==0)
            {
                return null;
            }
            return MainRepository.GetById(waterbathmaintenanceid);
        }

        public void InsertWaterBathMaintenance(WaterBathMaintenance waterbathmaintenance)
        {
            if (waterbathmaintenance==null)
            {
                throw new ArgumentNullException(nameof(waterbathmaintenance));
            }
            MainRepository.Insert(waterbathmaintenance);
        }

        public void UpdateWaterBathMaintenance(WaterBathMaintenance waterbathmaintenance)
        {
            if (waterbathmaintenance==null)
            {
                throw new ArgumentNullException(nameof(waterbathmaintenance));
            }
            MainRepository.Update(waterbathmaintenance);
        }
        #endregion
    }
}
