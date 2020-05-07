using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.MaritalStatuses
{
    interface IMaritalStatusService
    {
        #region [Methods]
        MaritalStatus GetMaritalStatusById(int maritalstatusid);

        void DeleteMaritalStatus(MaritalStatus maritalstatus);
        IList<MaritalStatus> GetAllMaritalStatuses();

        void InsertMaritalStatus(MaritalStatus maritalstatus);

        void UpdateMaritalStatus(MaritalStatus maritalstatus);

        #endregion
    }
}
