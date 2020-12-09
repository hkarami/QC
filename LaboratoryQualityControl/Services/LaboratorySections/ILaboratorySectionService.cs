using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.LaboratorySections
{
    public interface ILaboratorySectionService
    {
        #region [Methods]
        LaboratorySection GetLaboratorySectionById(int sectioncodelab);

        void DeleteLaboratorySection(LaboratorySection laboratorysection);
        IList<LaboratorySection> GetAllLaboratorySections();

        void InsertLaboratorySection(LaboratorySection laboratorysection);

        void UpdateLaboratorySection(LaboratorySection laboratorysection);

        #endregion
    }
}
