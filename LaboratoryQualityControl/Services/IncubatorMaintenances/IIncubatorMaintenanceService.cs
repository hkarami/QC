using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.IncubatorMaintenances
{
    interface IIncubatorMaintenanceService
    {
        #region [Methods]
        IncubatorMaintenance GetIncubatorMaintenanceById(int incubatormaintenanceid);

        void DeleteIncubatorMaintenance(IncubatorMaintenance incubatormaintenance);
        IList<IncubatorMaintenance> GetAllIncubatorMaintenances();

        void InsertIncubatorMaintenance(IncubatorMaintenance incubatormaintenance);

        void UpdateIncubatorMaintenance(IncubatorMaintenance incubatormaintenance);

        #endregion
    }
}
