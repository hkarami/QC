using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Models;
using LaboratoryQualityControl.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Factories.DeviceTypes
{
    public interface IDeviceTypeModelFactory : IBaseMappingFactory<DeviceType, DeviceTypeModel>
    {

    }
}
