using System;
using System.Collections.Generic;
using System.Linq;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.BloodControls
{
    public class BloodControlService : BaseService<BloodControl>,IBloodControlService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public BloodControlService(LaboratoryQCContext dbContext, IRepository<BloodControl> repository) : base(dbContext, repository)
        {
        }

        #endregion
        #region [Methods]
        public void DeleteBloodcontrol(BloodControl bloodControl)
        {
            if (bloodControl == null)
                throw new ArgumentNullException(nameof(bloodControl));

            MainRepository.Delete(bloodControl);
        }

        public IList<BloodControl> GetAllBloodControls()
        {
            return MainRepository.Table.ToList();
        }

        public BloodControl GetBloodControlById(int bloodControlId)
        {
            if (bloodControlId == 0)
                return null;

            return MainRepository.GetById(bloodControlId);
        }

        public void InsertBloodControl(BloodControl bloodControl)
        {
            if (bloodControl == null)
                throw new ArgumentNullException(nameof(bloodControl));

            MainRepository.Insert(bloodControl);
        }

        public void UpdadteBloodControl(BloodControl bloodControl)
        {
            if (bloodControl == null)
                throw new ArgumentNullException(nameof(bloodControl));

            MainRepository.Update(bloodControl);
        }

        #endregion
    }
}
