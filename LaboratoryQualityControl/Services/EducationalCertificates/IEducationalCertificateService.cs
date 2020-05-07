using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.EducationalCertificates
{
    interface IEducationalCertificateService
    {
        #region [Methods]
        EducationalCertificate GetEducationalCertificateById(int educationalcertificateid);

        void DeleteEducationalCertificate(EducationalCertificate educationalcertificate);
        IList<EducationalCertificate> GetAllEducationalCertificates();

        void InsertEducationalCertificate(EducationalCertificate educationalcertificate);

        void UpdateEducationalCertificate(EducationalCertificate educationalcertificate);

        #endregion
    }
}
