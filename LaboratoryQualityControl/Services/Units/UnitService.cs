using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.Units
{
    public class UnitService : BaseService<Unit>, IUnitService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public UnitService(LaboratoryQCContext dbContext, IRepository<Unit> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteUnit(Unit unit)
        {
            if (unit==null)
            {
                throw new ArgumentNullException(nameof(unit));
            }
            MainRepository.Delete(unit);
        }

        public IList<Unit> GetAllUnits()
        {
            return MainRepository.Table.ToList();
        }

        public Unit GetUnitById(int unitid)
        {
            if (unitid==0)
            {
                return null;
            }
            return MainRepository.GetById(unitid);
        }

        public void InsertUnit(Unit unit)
        {
            if (unit==null)
            {
                throw new ArgumentNullException(nameof(unit));
            }
            MainRepository.Insert(unit);
        }

        public void UpdateUnit(Unit unit)
        {
            if (unit==null)
            {
                throw new ArgumentNullException(nameof(unit));
            }
            MainRepository.Update(unit);
        }
        #endregion
    }
}
