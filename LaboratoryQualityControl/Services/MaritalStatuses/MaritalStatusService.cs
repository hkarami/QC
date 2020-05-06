using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.MaritalStatuses
{
    public class MaritalStatusService : BaseService<MaritalStatus>, IMaritalStatusService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public MaritalStatusService(LaboratoryQCContext dbContext, IRepository<MaritalStatus> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteMaritalStatus(MaritalStatus maritalstatus)
        {
            if (maritalstatus==null)
            {
                throw new ArgumentNullException(nameof(maritalstatus));
            }
            MainRepository.Delete(maritalstatus);
        }

        public IList<MaritalStatus> GetAllMaritalStatuses()
        {
            return MainRepository.Table.ToList();
        }

        public MaritalStatus GetMaritalStatusById(int maritalstatusid)
        {
            if (maritalstatusid==0)
            {
                return null;
            }
            return MainRepository.GetById(maritalstatusid);
        }

        public void InsertMaritalStatus(MaritalStatus maritalstatus)
        {
            if (maritalstatus==null)
            {
                throw new ArgumentNullException(nameof(maritalstatus));
            }
            MainRepository.Insert(maritalstatus);
        }

        public void UpdateMaritalStatus(MaritalStatus maritalstatus)
        {
            if (maritalstatus==null)
            {
                throw new ArgumentNullException(nameof(maritalstatus));
            }
            MainRepository.Update(maritalstatus);
        }
        #endregion
    }
}
