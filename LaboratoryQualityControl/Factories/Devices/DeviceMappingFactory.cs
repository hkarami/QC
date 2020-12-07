using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Factories.Devices
{
    public class DeviceMappingFactory : IDeviceMappingFactory
    {
        #region[Fields]
        #endregion

        #region [Ctor]
        public DeviceMappingFactory()
        {

        }
        #endregion

        #region [Methods] 
        public Device ToDomain(DeviceModel model)
        {
            return new Device
            {
                DeviceCode = model.DeviceCode,
                DeviceName = model.DeviceName,
                DeviceTypeId = model.DeviceTypeID,
                Factory = model.Factory,
                Model = model.Model,
                ManufacturingCountry = model.ManufacturingCountry,
                SerialNumber = model.SerialNumber,
                SupportCompany = model.SupportCompany,
                Location = model.Location,
                FeaturedUsers = model.FeaturedUsers,
                IdentificationCode = model.IdentificationCode,
                DateSubmittedToLab = model.DateSubmittedToLab,
                SectionLaunchDATE = model.SectionLaunchDate,
                DeliveryStatus = model.DeliveryStatus,
                SpecialCharacteristic = model.SpecialCharacteristic,
                RelatedEquipment = model.RelatedEquipment,
                PhoneToSupportCompany = model.PhoneToSupportCompany,
                SectionCodeLab = model.LaboratorySectionId,
                Other = model.Other,
                UserCode = model.UserId,
                UpdateRecordTime = model.UpdateRecordTime,
                RecordTime = model.RecordTime
            };
        }

        public DeviceModel ToModel(Device domain)
        {
            return new DeviceModel
            {
                DeviceCode = domain.DeviceCode,
                DeviceName = domain.DeviceName,
                DeviceTypeID = domain.DeviceTypeId,
                DeviceTypeName = domain.DeviceType?.DeviceTypeName,
                Factory = domain.Factory,
                Model = domain.Model,
                ManufacturingCountry = domain.ManufacturingCountry,
                SerialNumber = domain.SerialNumber,
                SupportCompany = domain.SupportCompany,
                Location = domain.Location,
                FeaturedUsers = domain.FeaturedUsers,
                IdentificationCode = domain.IdentificationCode,
                DateSubmittedToLab = domain.DateSubmittedToLab,
                SectionLaunchDate = domain.SectionLaunchDATE,
                DeliveryStatus = domain.DeliveryStatus,
                SpecialCharacteristic = domain.SpecialCharacteristic,
                RelatedEquipment = domain.RelatedEquipment,
                PhoneToSupportCompany = domain.PhoneToSupportCompany,
                LaboratorySectionId = domain.SectionCodeLab,
                LaboratorySectionName = domain.LaboratorySections?.SectionNameLab,
                Other = domain.Other,
                UserId = domain.UserCode,
                UserFullName = domain.User?.NickName,
                UpdateRecordTime = domain.UpdateRecordTime,
                RecordTime = domain.RecordTime,

            };
        }
        #endregion
    }
}
