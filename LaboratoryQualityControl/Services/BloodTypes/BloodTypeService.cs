using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.BloodTypes
{
    public class BloodTypeService:BaseService<BloodType>,IBloodTypeService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public BloodTypeService(LaboratoryQCContext dbContext, IRepository<BloodType> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteBloodType(BloodType bloodControl)
        {
            if (bloodControl==null)
            {
                throw new ArgumentNullException(nameof(bloodControl));
            }
            MainRepository.Delete(bloodControl);
        }

        public IList<BloodType> GetAllBloodTypes()
        {
            return MainRepository.Table.ToList();
        }

        public BloodType GetBloodTypeById(int BloodTypeID)
        {
            if (BloodTypeID==0)
            {
                return null;
            }
            return MainRepository.GetById(BloodTypeID);
        }

        public void InsertBloodType(BloodType bloodControl)
        {
            if (bloodControl==null)
            {
                throw new ArgumentNullException(nameof(bloodControl));
            }
            MainRepository.Insert(bloodControl);
        }

        public void UpdadteBloodType(BloodType bloodControl)
        {
            if (bloodControl==null)
            {
                throw new ArgumentNullException(nameof(bloodControl));
            }
            MainRepository.Update(bloodControl);
        }

        #endregion

    }
}
