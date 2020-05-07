using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.RulesQCs
{
    public class RulesQCService : BaseService<RulesQC>, IRulesQCService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public RulesQCService(LaboratoryQCContext dbContext, IRepository<RulesQC> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteRulesQC(RulesQC rulesqc)
        {
            if (rulesqc==null)
            {
                throw new ArgumentNullException(nameof(rulesqc));
            }
            MainRepository.Delete(rulesqc);
        }

        public IList<RulesQC> GetAllRulesQCs()
        {
            return MainRepository.Table.ToList();
        }

        public RulesQC GetRulesQCById(int rulesqcid)
        {
            if (rulesqcid==0)
            {
                return null;
            }
            return MainRepository.GetById(rulesqcid);
        }

        public void InsertRulesQC(RulesQC rulesqc)
        {
            if (rulesqc==null)
            {
                throw new ArgumentNullException(nameof(rulesqc));
            }
            MainRepository.Insert(rulesqc);
        }

        public void UpdateRulesQC(RulesQC rulesqc)
        {
            if (rulesqc==null)
            {
                throw new ArgumentNullException(nameof(rulesqc));
            }
            MainRepository.Update(rulesqc);
        }
        #endregion
    }
}
