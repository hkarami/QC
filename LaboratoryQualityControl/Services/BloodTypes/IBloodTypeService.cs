using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.BloodTypes
{
    interface IBloodTypeService
    {
        #region [Methods]
        BloodType GetBloodTypeById(int BloodTypeID);

        void DeleteBloodType(BloodType bloodControl);

        IList<BloodType> GetAllBloodTypes();

        void InsertBloodType(BloodType bloodControl);

        void UpdadteBloodType(BloodType bloodControl);

        #endregion
    }
}
