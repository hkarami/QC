using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.AnalyteMaterials
{
    interface IAnalyteMaterialService
    {
        #region [Methods]
        AnalyteMaterial GetAnalyteMaterialByID(int analytematerialid);
        void DeleteAnalyteMaterial(AnalyteMaterial analytematerial);
        IList<AnalyteMaterial> GetAllAnalyteMaterial();
        void UpdateAnalyteMaterial(AnalyteMaterial analytematerial);
        void InsertAnalyteMaterial(AnalyteMaterial analytematerial);
        #endregion
    }
}
