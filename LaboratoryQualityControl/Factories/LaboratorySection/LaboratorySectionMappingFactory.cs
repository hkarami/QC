using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Factories.LaboratorySection
{
    public class LaboratorySectionMappingFactory : ILaboratorySectionMappingFactory
    {
        public Domain.LaboratorySection ToDomain(LaboratorySectionModel model)
        {
            return new Domain.LaboratorySection { 
                InOrder = model.InOrder,
                RecordTime=model.RecordTime,
                SectionCodeLab=model.SectionCodeLab,
                SectionNameLab=model.SectionNameLab
            };
        }

        public LaboratorySectionModel ToModel(Domain.LaboratorySection domain)
        {
            return new LaboratorySectionModel {
                InOrder = domain.InOrder,
                RecordTime=domain.RecordTime,
                SectionNameLab=domain.SectionNameLab,
                SectionCodeLab=domain.SectionCodeLab
            };
        }
    }
}
