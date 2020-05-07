using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;

namespace LaboratoryQualityControl.Services.RulesQCs
{
    interface IRulesQCService
    {
        #region [Methods]
        RulesQC GetRulesQCById(int rulesqcid);

        void DeleteRulesQC(RulesQC rulesqc);
        IList<RulesQC> GetAllRulesQCs();

        void InsertRulesQC(RulesQC rulesqc);

        void UpdateRulesQC(RulesQC rulesqc);

        #endregion
    }
}
