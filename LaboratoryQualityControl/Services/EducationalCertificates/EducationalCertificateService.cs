using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.EducationalCertificates
{
    public class EducationalCertificateService : BaseService<EducationalCertificate>, IEducationalCertificateService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public EducationalCertificateService(LaboratoryQCContext dbContext, IRepository<EducationalCertificate> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteEducationalCertificate(EducationalCertificate educationalcertificate)
        {
            if (educationalcertificate==null)
            {
                throw new ArgumentNullException(nameof(educationalcertificate));
            }
            MainRepository.Delete(educationalcertificate);
        }

        public IList<EducationalCertificate> GetAllEducationalCertificates()
        {
            return MainRepository.Table.ToList();
        }

        public EducationalCertificate GetEducationalCertificateById(int educationalcertificateid)
        {
            if (educationalcertificateid==0)
            {
                return null;
            }
            return MainRepository.GetById(educationalcertificateid);

        }

        public void InsertEducationalCertificate(EducationalCertificate educationalcertificate)
        {
            if (educationalcertificate==null)
            {
                throw new ArgumentNullException(nameof(educationalcertificate));
            }
            MainRepository.Insert(educationalcertificate);
        }

        public void UpdateEducationalCertificate(EducationalCertificate educationalcertificate)
        {
            if (educationalcertificate==null)
            {
                throw new ArgumentNullException(nameof(educationalcertificate));
            }
            MainRepository.Update(educationalcertificate);
        }
        #endregion
    }
}
