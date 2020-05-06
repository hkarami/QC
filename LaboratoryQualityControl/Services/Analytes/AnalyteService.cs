using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Services.Analytes
{
    public class AnalyteService : BaseService<Analyte>, IAnalyteService
    {
        #region [Fields]
        #endregion
        #region [Ctor]
        public AnalyteService(LaboratoryQCContext dbContext, IRepository<Analyte> repository) : base(dbContext, repository)
        {
        }
        #endregion
        #region [Methods]
        public void DeleteAnalyte(Analyte analyte)
        {
            if (analyte == null)
            {
                throw new ArgumentNullException(nameof(analyte));
            }
            MainRepository.Delete(analyte);
        }

        public IList<Analyte> GetAllAnalyte()
        {
            return MainRepository.Table.ToList();
        }

        public Analyte GetAnalyteByID(int analyteID)
        {
            if (analyteID==0)
            {
                return null;
            }
            return MainRepository.GetById(analyteID);
        }

        public void InsertAnalyte(Analyte analyte)
        {
            if (analyte==null)
            {
                throw new ArgumentNullException(nameof(analyte));
            }
            MainRepository.Insert(analyte);        }

        public void UpdateAnalyte(Analyte analyte)
        {
            if (analyte==null)
            {
                throw new ArgumentNullException(nameof(analyte));
            }
            MainRepository.Insert(analyte);
        }
        #endregion
    }
}
