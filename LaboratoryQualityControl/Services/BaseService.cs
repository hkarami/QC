using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services
{
    public abstract class BaseService<TMainEntity> where TMainEntity : BaseEntity,new()
    {
        #region [Fields]
        private LaboratoryQCContext _dbContext;
        private IRepository<TMainEntity> _mainRepository;
        #endregion
        #region [Ctor]
        public BaseService(LaboratoryQCContext dbContext,IRepository<TMainEntity> repository)
        {
            _dbContext = dbContext;
            _mainRepository = repository;
        }
        #endregion

        #region [Properties]
        protected LaboratoryQCContext DbContext => _dbContext;
        protected IRepository<TMainEntity> MainRepository => _mainRepository;
        #endregion
    }
}
