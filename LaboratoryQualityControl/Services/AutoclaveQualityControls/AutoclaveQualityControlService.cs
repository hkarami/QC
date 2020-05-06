using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.AutoclaveQualityControls
{
    public class AutoclaveQualityControlService : BaseService<AutoclaveQualityControl>, IAutoclaveQualityControlService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public AutoclaveQualityControlService(LaboratoryQCContext dbContext, IRepository<AutoclaveQualityControl> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteAutoclaveQualityControl(AutoclaveQualityControl autoclavequalitycontrol)
        {
            if (autoclavequalitycontrol==null)
            {
                throw new ArgumentNullException(nameof(autoclavequalitycontrol));
            }
            MainRepository.Delete(autoclavequalitycontrol);
        }

        public IList<AutoclaveQualityControl> GetAllAutoclaveQualityControl()
        {
            return MainRepository.Table.ToList();
        }

        public AutoclaveQualityControl GetAutoclaveQualityControlByID(int autoclavequalitycontrolid)
        {
            if (autoclavequalitycontrolid==0)
            {
                return null;
            }
            return MainRepository.GetById(autoclavequalitycontrolid);
        }

        public void InsertAutoclaveQualityControl(AutoclaveQualityControl autoclavequalitycontrol)
        {
            if (autoclavequalitycontrol==null)
            {
                throw new ArgumentNullException(nameof(autoclavequalitycontrol));
            }
            MainRepository.Insert(autoclavequalitycontrol);
        }

        public void UpdateAutoclaveQualityControl(AutoclaveQualityControl autoclavequalitycontrol)
        {
            if (autoclavequalitycontrol==null)
            {
                throw new ArgumentNullException(nameof(autoclavequalitycontrol));
            }
            MainRepository.Update(autoclavequalitycontrol);
        }
        #endregion
    }
}
