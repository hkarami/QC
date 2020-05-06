using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.LocationServices
{
    interface ILocationServiceService
    {
        #region [Methods]
        LocationService GetLocationServiceById(int locationserviceid);

        void DeleteLocationService(LocationService locationservice);
        IList<LocationService> GetAllLocationServices();

        void InsertLocationService(LocationService locationservice);

        void UpdateLocationService(LocationService locationservice);

        #endregion
    }
}
