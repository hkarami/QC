using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.LocationServices
{
    public class LocationServiceService : BaseService<LocationService>, ILocationServiceService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public LocationServiceService(LaboratoryQCContext dbContext, IRepository<LocationService> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteLocationService(LocationService locationservice)
        {
            if (locationservice==null)
            {
                throw new ArgumentNullException(nameof(locationservice));
            }
            MainRepository.Delete(locationservice);
        }

        public IList<LocationService> GetAllLocationServices()
        {
            return MainRepository.Table.ToList();
        }

        public LocationService GetLocationServiceById(int locationserviceid)
        {
            if (locationserviceid==0)
            {
                return null;
            }
            return MainRepository.GetById(locationserviceid);
        }

        public void InsertLocationService(LocationService locationservice)
        {
            if (locationservice==null)
            {
                throw new ArgumentNullException(nameof(locationservice));
            }
            MainRepository.Insert(locationservice);
        }

        public void UpdateLocationService(LocationService locationservice)
        {
            if (locationservice==null)
            {
                throw new ArgumentNullException(nameof(locationservice));
            }
            MainRepository.Update(locationservice);
        }
        #endregion
    }
}
