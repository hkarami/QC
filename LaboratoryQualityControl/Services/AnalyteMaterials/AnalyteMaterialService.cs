using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.AnalyteMaterials
{
    public class AnalyteMaterialService : BaseService<AnalyteMaterial>, IAnalyteMaterialService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public AnalyteMaterialService(LaboratoryQCContext dbContext, IRepository<AnalyteMaterial> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteAnalyteMaterial(AnalyteMaterial analytematerial)
        {
            if (analytematerial==null)
            {
                throw new ArgumentNullException(nameof(analytematerial));
            }
            MainRepository.Delete(analytematerial);
        }

        public IList<AnalyteMaterial> GetAllAnalyteMaterial()
        {
            return MainRepository.Table.ToList();
        }

        public AnalyteMaterial GetAnalyteMaterialByID(int analytematerialid)
        {
            if (analytematerialid==0)
            {
                return null;
            }
            return MainRepository.GetById(analytematerialid);
        }

        public void InsertAnalyteMaterial(AnalyteMaterial analytematerial)
        {
            if (analytematerial==null)
            {
                throw new ArgumentNullException(nameof(analytematerial));
            }
            MainRepository.Insert(analytematerial);
        }

        public void UpdateAnalyteMaterial(AnalyteMaterial analytematerial)
        {
            if (analytematerial==null)
            {
                throw new ArgumentNullException(nameof(analytematerial));
            }
            MainRepository.Update(analytematerial);

        }
        #endregion
    }
}
