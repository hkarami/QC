using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.SupportCompanes
{
    public class SupportCompanyService : BaseService<SupportCompany>, ISupportCompanyService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public SupportCompanyService(LaboratoryQCContext dbContext, IRepository<SupportCompany> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteSupportCompany(SupportCompany supportcompany)
        {
            if (supportcompany==null)
            {
                throw new ArgumentNullException(nameof(supportcompany));
            }
            MainRepository.Delete(supportcompany);
        }

        public IList<SupportCompany> GetAllSupportCompanes()
        {
            return MainRepository.Table.ToList();
        }

        public SupportCompany GetSupportCompanyById(int supportcompanyid)
        {
            if (supportcompanyid==0)
            {
                return null;
            }
            return MainRepository.GetById(supportcompanyid);
        }

        public void InsertSupportCompany(SupportCompany supportcompany)
        {
            if (supportcompany==null)
            {
                throw new ArgumentNullException(nameof(supportcompany));
            }
            MainRepository.Insert(supportcompany);
        }

        public void UpdateSupportCompany(SupportCompany supportcompany)
        {
            if (supportcompany==null)
            {
                throw new ArgumentNullException(nameof(supportcompany));
            }
            MainRepository.Update(supportcompany);
        }
        #endregion
    }
}
