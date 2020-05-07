using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.WaterBathMaintenances
{
    interface IWaterBathMaintenanceService
    {
        #region [Methods]
        WaterBathMaintenance GetWaterBathMaintenanceById(int waterbathmaintenanceid);

        void DeleteWaterBathMaintenance(WaterBathMaintenance waterbathmaintenance);
        IList<WaterBathMaintenance> GetAllWaterBathMaintenances();

        void InsertWaterBathMaintenance(WaterBathMaintenance waterbathmaintenance);

        void UpdateWaterBathMaintenance(WaterBathMaintenance waterbathmaintenance);

        #endregion
    }
}
