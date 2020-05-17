using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models.Analytes
{
    public class AnalyteResponseModel:ApiResult<List<AnalyteModel>>
    {
        public AnalyteResponseModel()
        {
            Data=new List<AnalyteModel>();
        }
    }
}
