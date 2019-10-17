using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LaboratoryQualityControl.DataAccess
{
    interface IRepository<TEntity> where TEntity : class, new()
    {
        #region [Methods]
        TEntity GetById(object entityId);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        #endregion
        #region [Properties]
        IQueryable<TEntity> Table { get; }
        #endregion
    }
}
