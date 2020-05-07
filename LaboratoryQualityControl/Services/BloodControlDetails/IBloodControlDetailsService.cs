using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.BloodControlDetails
{
    interface IBloodControlDetailsService
    {
        #region [Methods]
        BloodControlDetail GetBloodControlDetailByID(int bloodcontroldetailsid);
        void DeleteBloodControlDetail(BloodControlDetail bloodcontroldetail);
        IList<BloodControlDetail> GetAllBloodControlDetail();
        void UpdateBloodControlDetail(BloodControlDetail bloodcontroldetail);
        void InsertBloodControlDetail(BloodControlDetail bloodcontroldetail);
        #endregion
    }
}
