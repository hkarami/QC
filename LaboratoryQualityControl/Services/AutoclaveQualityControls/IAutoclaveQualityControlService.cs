using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.AutoclaveQualityControls
{
    interface IAutoclaveQualityControlService
    {
        #region [Methods]
        AutoclaveQualityControl GetAutoclaveQualityControlByID(int autoclavequalitycontrolid);
        void DeleteAutoclaveQualityControl(AutoclaveQualityControl autoclavequalitycontrol);
        IList<AutoclaveQualityControl> GetAllAutoclaveQualityControl();
        void UpdateAutoclaveQualityControl(AutoclaveQualityControl autoclavequalitycontrol);
        void InsertAutoclaveQualityControl(AutoclaveQualityControl autoclavequalitycontrol);
        #endregion
    }
}
