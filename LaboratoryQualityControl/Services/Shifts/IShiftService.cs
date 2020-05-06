using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.Shifts
{
    interface IShiftService
    {
        #region [Methods]
        Shift GetShiftById(int shiftid);

        void DeleteShift(Shift shift);
        IList<Shift> GetAllShifts();

        void InsertShift(Shift shift);

        void UpdateShift(Shift shift);

        #endregion
    }
}
