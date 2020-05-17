using System;
using LaboratoryQualityControl.Services.Devices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Models.Api;
using LaboratoryQualityControl.Models.Devices;
using Microsoft.EntityFrameworkCore;
namespace LaboratoryQualityControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        #region [Fields]
        private IDeviceService _deviceService;
        #endregion

        #region [Utilities]

        private DeviceModel ToModel(Device device)
        {
            return new DeviceModel
            {
                DeviceCode = device.DeviceCode,
                DeviceName = device.DeviceName,
                DeviceTypeID = device.DeviceTypeId,
                DeviceTypeName = device.DeviceType?.DeviceTypeName,
                Factory = device.Factory,
                Model = device.Model,
                ManufacturingCountry = device.ManufacturingCountry,
                SerialNumber = device.SerialNumber,
                SupportCompany = device.SupportCompany,
                Location = device.Location,
                FeaturedUsers = device.FeaturedUsers,
                IdentificationCode = device.IdentificationCode,
                DateSubmittedToLab = device.DateSubmittedToLab,
                SectionLaunchDate = device.SectionLaunchDATE,
                DeliveryStatus = device.DeliveryStatus,
                SpecialCharacteristic = device.SpecialCharacteristic,
                RelatedEquipment = device.RelatedEquipment,
                PhoneToSupportCompany = device.PhoneToSupportCompany,
                SectionCodeLab = device.SectionCodeLab,
                LaboratorySectionName = device.LaboratorySections?.SectionNameLab,
                Other = device.Other,
                UserCode = device.UserCode,
                UserFullName = device.User?.NickName,
                UpdateRecordTime = device.UpdateRecordTime,
                RecordTime = device.RecordTime
            };
        }

        private Device FromModel(DeviceModel deviceModel)
        {
            return new Device
            {
                DeviceCode = deviceModel.DeviceCode,
                DeviceName = deviceModel.DeviceName,
                DeviceTypeId = deviceModel.DeviceTypeID,
                Factory = deviceModel.Factory,
                Model = deviceModel.Model,
                ManufacturingCountry = deviceModel.ManufacturingCountry,
                SerialNumber = deviceModel.SerialNumber,
                SupportCompany = deviceModel.SupportCompany,
                Location = deviceModel.Location,
                FeaturedUsers = deviceModel.FeaturedUsers,
                IdentificationCode = deviceModel.IdentificationCode,
                DateSubmittedToLab = deviceModel.DateSubmittedToLab,
                SectionLaunchDATE = deviceModel.SectionLaunchDate,
                DeliveryStatus = deviceModel.DeliveryStatus,
                SpecialCharacteristic = deviceModel.SpecialCharacteristic,
                RelatedEquipment = deviceModel.RelatedEquipment,
                PhoneToSupportCompany = deviceModel.PhoneToSupportCompany,
                SectionCodeLab = deviceModel.SectionCodeLab,
                Other = deviceModel.Other,
                UserCode = deviceModel.UserCode,
                UpdateRecordTime = deviceModel.UpdateRecordTime,
                RecordTime = deviceModel.RecordTime
            };
        }

        #endregion

        #region [Ctor]
        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }
        #endregion

        #region [Methods]
        // GET: api/Device
        [HttpGet]
        public DeviceResponseModel Get()
        {
            var deviceResponse = new DeviceResponseModel();
            try
            {
                var devices = _deviceService.GetAllDevice();

                foreach (var device in devices)
                {
                    deviceResponse.Data.Add(ToModel(device));
                }

                deviceResponse.Count = deviceResponse.Data.Count;
                deviceResponse.Items = deviceResponse.Data;
                //deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError, "UnknownError"));
            }
            catch (Exception e)
            {
                deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError, "UnknownError"));
            }

            return deviceResponse;
        }

        // GET: api/Device/5
        [HttpGet("{deviceId}", Name = "Get")]
        public DeviceResponseModel Get(int deviceId)
        {
            var deviceResponse = new DeviceResponseModel();

            try
            {
                var device = _deviceService.GetDeviceByID(deviceId);
                if (device == null)
                {
                    deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EntityNotFound));
                    return deviceResponse;
                }

                deviceResponse.Data.Add(ToModel(device));
            }
            catch (Exception e)
            {
                deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError));
            }

            return deviceResponse;
        }

        // POST: api/Device
        [HttpPost]
        public async Task<DeviceResponseModel> Post([FromBody] Device device)
        {
            var deviceResponse = new DeviceResponseModel();
            try
            {

                if (device == null)
                    deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EmptyRequest));
                else
                {
                    await _deviceService.InsertDeviceAsync(device);
                    deviceResponse.Data.Add(ToModel(device));
                }
            }
            catch (Exception e)
            {
                deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError));
            }

            return deviceResponse;
        }

        // PUT: api/Device/5
        [HttpPut]
        public DeviceResponseModel Put([FromBody] Device device)
        {
            var deviceResponse = new DeviceResponseModel();
            try
            {

                if (device == null)
                    deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EmptyRequest));
                else
                {
                    _deviceService.UpdateDevice(device);
                    deviceResponse.Data.Add(ToModel(device));
                }
            }
            catch (Exception e)
            {
                deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError));
            }

            return deviceResponse;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{deviceId}")]
        public DeviceResponseModel Delete(int deviceId)
        {
            var deviceResponse = new DeviceResponseModel();
            try
            {
                var device = _deviceService.GetDeviceByID(deviceId);
                if (device == null)
                    deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EmptyRequest));
                else
                {
                    _deviceService.DeleteDevice(device);
                    deviceResponse.Data.Add(ToModel(device));
                }
            }
            catch (Exception e)
            {
                deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError));
            }

            return deviceResponse;
        }
        #endregion
    }
}
