using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.Analytes
{
    interface IAnalyteService
    {
        #region [Methods]
        Analyte GetAnalyteByID(int analyteid);
        void DeleteAnalyte(Analyte analyte);
        IList<Analyte> GetAllAnalyte();
        void UpdateAnalyte(Analyte analyte);
        void InsertAnalyte(Analyte analyte);
        #endregion
    }
}
