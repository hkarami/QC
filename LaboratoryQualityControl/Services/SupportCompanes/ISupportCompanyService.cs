using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.SupportCompanes
{
    interface ISupportCompanyService
    {
        #region [Methods]
        SupportCompany GetSupportCompanyById(int supportcompanyid);

        void DeleteSupportCompany(SupportCompany supportcompany);
        IList<SupportCompany> GetAllSupportCompanes();

        void InsertSupportCompany(SupportCompany supportcompany);

        void UpdateSupportCompany(SupportCompany supportcompany);

        #endregion
    }
}
