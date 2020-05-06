using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.BloodControlDetails
{
    public class BloodControlDetailsService:BaseService<BloodControlDetail>,IBloodControlDetailsService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public BloodControlDetailsService(LaboratoryQCContext dbContext, IRepository<BloodControlDetail> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteBloodControlDetail(BloodControlDetail bloodcontroldetail)
        {
            if (bloodcontroldetail==null)
            {
                throw new ArgumentNullException(nameof(bloodcontroldetail));
            }
            MainRepository.Delete(bloodcontroldetail);
        }

        public IList<BloodControlDetail> GetAllBloodControlDetail()
        {
            return MainRepository.Table.ToList();
        }

        public BloodControlDetail GetBloodControlDetailByID(int bloodcontroldetailsid)
        {
            if (bloodcontroldetailsid==0)
            {
                return null;
            }
           return MainRepository.GetById(bloodcontroldetailsid);
        }

        public void InsertBloodControlDetail(BloodControlDetail bloodcontroldetail)
        {
            if (bloodcontroldetail==null)
            {
                throw new ArgumentNullException(nameof(bloodcontroldetail));
            }
            MainRepository.Insert(bloodcontroldetail);
        }

        public void UpdateBloodControlDetail(BloodControlDetail bloodcontroldetail)
        {
            if (bloodcontroldetail == null)
            {
                throw new ArgumentNullException(nameof(bloodcontroldetail));
            }
            MainRepository.Update(bloodcontroldetail);
        }
        #endregion
    }
}
