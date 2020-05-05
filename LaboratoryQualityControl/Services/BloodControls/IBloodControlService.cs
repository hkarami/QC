using LaboratoryQualityControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Services.BloodControls
{
    public interface IBloodControlService
    {
        #region [Methods]
        BloodControl GetBloodControlById(int bloodControlId);

        void DeleteBloodcontrol(BloodControl bloodControl);

        IList<BloodControl> GetAllBloodControls();

        void InsertBloodControl(BloodControl bloodControl);

        void UpdadteBloodControl(BloodControl bloodControl);

        #endregion
    }
}
