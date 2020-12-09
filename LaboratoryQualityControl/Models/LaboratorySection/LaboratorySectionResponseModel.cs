using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models.LaboratorySection
{
    public class LaboratorySectionResponseModel:ApiResult<List<LaboratorySectionModel>>
    {
        public LaboratorySectionResponseModel()
        {
            Data = new List<LaboratorySectionModel>();
        }
    }
}
