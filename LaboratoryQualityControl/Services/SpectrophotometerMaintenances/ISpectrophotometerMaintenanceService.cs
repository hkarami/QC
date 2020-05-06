using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.SpectrophotometerMaintenances
{
    interface ISpectrophotometerMaintenanceService
    {
        #region [Methods]
        SpectrophotometerMaintenance GetSpectrophotometerMaintenanceById(int spectrophotometermaintenanceid);

        void DeleteSpectrophotometerMaintenance(SpectrophotometerMaintenance spectrophotometermaintenance);
        IList<SpectrophotometerMaintenance> GetAllSpectrophotometerMaintenances();

        void InsertSpectrophotometerMaintenance(SpectrophotometerMaintenance spectrophotometermaintenance);

        void UpdateSpectrophotometerMaintenance(SpectrophotometerMaintenance spectrophotometermaintenance);

        #endregion
    }
}
