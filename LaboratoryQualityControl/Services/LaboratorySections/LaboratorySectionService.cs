using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.LaboratorySections
{
    public class LaboratorySectionService : BaseService<LaboratorySection>, ILaboratorySectionService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public LaboratorySectionService(LaboratoryQCContext dbContext, IRepository<LaboratorySection> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteLaboratorySection(LaboratorySection laboratorysection)
        {
            if (laboratorysection==null)
            {
                throw new ArgumentNullException(nameof(laboratorysection));
            }
            MainRepository.Delete(laboratorysection);
        }

        public IList<LaboratorySection> GetAllLaboratorySections()
        {
            return MainRepository.Table.ToList();
        }

        public LaboratorySection GetLaboratorySectionById(int sectioncodelab)
        {
            if (sectioncodelab==0)
            {
                return null;
            }
            return MainRepository.GetById(sectioncodelab);
        }

        public void InsertLaboratorySection(LaboratorySection laboratorysection)
        {
            if (laboratorysection == null)
            {
                throw new ArgumentNullException(nameof(laboratorysection));
            }
            MainRepository.Insert(laboratorysection);
        }

        public void UpdateLaboratorySection(LaboratorySection laboratorysection)
        {
            if (laboratorysection==null)
            {
                throw new ArgumentNullException(nameof(laboratorysection));
            }
            MainRepository.Update(laboratorysection);
        }
        #endregion
    }
}
