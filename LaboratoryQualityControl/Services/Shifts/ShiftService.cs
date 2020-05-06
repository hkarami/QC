using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.Shifts
{
    public class ShiftService : BaseService<Shift>, IShiftService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public ShiftService(LaboratoryQCContext dbContext, IRepository<Shift> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteShift(Shift shift)
        {
            if (shift==null)
            {
                throw new ArgumentNullException(nameof(shift));
            }
            MainRepository.Delete(shift);
        }

        public IList<Shift> GetAllShifts()
        {
            return MainRepository.Table.ToList();
        }

        public Shift GetShiftById(int shiftid)
        {
            if (shiftid==0)
            {
                return null;
            }
            return MainRepository.GetById(shiftid);
        }

        public void InsertShift(Shift shift)
        {
            if (shift==null)
            {
                throw new ArgumentNullException(nameof(shift));
            }
            MainRepository.Insert(shift);
        }

        public void UpdateShift(Shift shift)
        {
            if (shift==null)
            {
                throw new ArgumentNullException(nameof(shift));
            }
            MainRepository.Update(shift);
        }
        #endregion
    }
}
