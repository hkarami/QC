using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.Units
{
    interface IUnitService
    {
        #region [Methods]
        Unit GetUnitById(int unitid);

        void DeleteUnit(Unit unit);
        IList<Unit> GetAllUnits();

        void InsertUnit(Unit unit);

        void UpdateUnit(Unit unit);

        #endregion
    }
}
