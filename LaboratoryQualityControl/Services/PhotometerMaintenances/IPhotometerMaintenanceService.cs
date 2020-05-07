using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.PhotometerMaintenances
{
    interface IPhotometerMaintenanceService
    {
        #region [Methods]
        PhotometerMaintenance GetPhotometerMaintenanceById(int photometermaintenanceid);

        void DeletePhotometerMaintenance(PhotometerMaintenance photometermaintenance);
        IList<PhotometerMaintenance> GetAllPhotometerMaintenances();

        void InsertPhotometerMaintenance(PhotometerMaintenance photometermaintenance);

        void UpdatePhotometerMaintenance(PhotometerMaintenance photometermaintenance);

        #endregion
    }
}
