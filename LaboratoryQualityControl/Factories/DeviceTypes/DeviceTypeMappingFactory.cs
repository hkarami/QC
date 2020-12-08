using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Factories.DeviceTypes
{
    public class DeviceTypeMappingFactory : IDeviceTypeModelFactory
    {
        public DeviceType ToDomain(DeviceTypeModel model)
        {
            return new DeviceType {
                //Devices = model.Devices,
                DeviceTypeID = model.DeviceTypeID,
                DeviceTypeName = model.DeviceTypeName,
                InOrder=model.InOrder,
                RecordTime=model.RecordTime
            };
        }

        public DeviceTypeModel ToModel(DeviceType domain)
        {
            return new DeviceTypeModel
            {
                //Devices=domain.Devices,
                DeviceTypeID = domain.DeviceTypeID,
                DeviceTypeName = domain.DeviceTypeName,
                InOrder = domain.InOrder,
                RecordTime = domain.RecordTime

            };
        }
    }
}
