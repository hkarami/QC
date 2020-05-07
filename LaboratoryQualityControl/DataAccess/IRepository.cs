using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.DataAccess
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        #region [Methods]
        TEntity GetById(object entityId);

        void Insert(TEntity entity);

        Task InsertAsync(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        #endregion
        #region [Properties]
        DbSet<TEntity> Table { get; }
        #endregion
    }
}
