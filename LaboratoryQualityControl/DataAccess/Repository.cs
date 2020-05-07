using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.DataAccess
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        #region [Fields]
        private LaboratoryQCContext _context;
        private DbSet<TEntity> _entities;
        #endregion
        #region [Ctor]
        public Repository(LaboratoryQCContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }
        #endregion

        #region [Fiels]

        public void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public TEntity GetById(Object entityId)
        {
            return _entities.Find(entityId);
        }

        public void Insert(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            //_context.Entry()
            _entities.Update(entity);
            _context.SaveChanges();
        }

        public async Task InsertAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Add(entity);
            await _context.SaveChangesAsync();
        }
        #endregion

        #region [Properties]
        public DbSet<TEntity> Table => _entities;

        #endregion
    }
}
