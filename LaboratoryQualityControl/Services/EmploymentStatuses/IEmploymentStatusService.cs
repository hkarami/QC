using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.EmploymentStatuses
{
    interface IEmploymentStatusService
    {
        #region [Methods]
        EmploymentStatus GetEmploymentStatusById(int employmentstatusid);

        void DeleteEmploymentStatus(EmploymentStatus employmentstatus);
        IList<EmploymentStatus> GetAllEmploymentStatuses();

        void InsertEmploymentStatus(EmploymentStatus employmentstatus);

        void UpdateEmploymentStatus(EmploymentStatus employmentstatus);

        #endregion
    }
}
