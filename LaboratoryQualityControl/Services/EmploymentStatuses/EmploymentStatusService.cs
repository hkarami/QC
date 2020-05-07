using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.EmploymentStatuses
{
    public class EmploymentStatusService : BaseService<EmploymentStatus>, IEmploymentStatusService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public EmploymentStatusService(LaboratoryQCContext dbContext, IRepository<EmploymentStatus> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteEmploymentStatus(EmploymentStatus employmentstatus)
        {
            if (employmentstatus==null)
            {
                throw new ArgumentNullException(nameof(employmentstatus));
            }
            MainRepository.Delete(employmentstatus);
        }

        public IList<EmploymentStatus> GetAllEmploymentStatuses()
        {
            return MainRepository.Table.ToList();
        }

        public EmploymentStatus GetEmploymentStatusById(int employmentstatusid)
        {
            if (employmentstatusid==0)
            {
                return null;
            }
            return MainRepository.GetById(employmentstatusid);
        }

        public void InsertEmploymentStatus(EmploymentStatus employmentstatus)
        {
            if (employmentstatus==null)
            {
                throw new ArgumentNullException(nameof(employmentstatus));
            }
            MainRepository.Insert(employmentstatus);
        }

        public void UpdateEmploymentStatus(EmploymentStatus employmentstatus)
        {
            if (employmentstatus==null)
            {
                throw new ArgumentNullException(nameof(employmentstatus));
            }
            MainRepository.Update(employmentstatus);
        }
        #endregion
    }
}
