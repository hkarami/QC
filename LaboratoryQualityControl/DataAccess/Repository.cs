using LaboratoryQualityControl.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

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

            _entities.Update(entity);
            _context.SaveChanges();
        }
        #endregion

        #region [Properties]
        public IQueryable<TEntity> Table => _entities;

        #endregion
    }
}
