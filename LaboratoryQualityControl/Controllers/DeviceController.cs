using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Factories;
using LaboratoryQualityControl.Models.Api;
using LaboratoryQualityControl.Models.Devices;
using LaboratoryQualityControl.Services.Devices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
namespace LaboratoryQualityControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        #region [Fields]
        private IDeviceService _deviceService;
        private IDeviceMappingFactory _deviceMappingFactory;
        #endregion

        #region [Ctor]
        public DeviceController(IDeviceService deviceService, IDeviceMappingFactory deviceMappingFactory)
        {
            _deviceService = deviceService;
            _deviceMappingFactory = deviceMappingFactory;
        }
        #endregion

        #region [Methods]
        // GET: api/Device
        [HttpGet]
        public DevicesResponseModel Get()
        {
            var deviceResponse = new DevicesResponseModel();
            try
            {
                var devices = _deviceService.GetAllDevice();

                foreach (var device in devices)
                {
                    var model = _deviceMappingFactory.ToModel(device);
                    deviceResponse.Data.Add(model);
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
        DeviceModel

        // GET: api/Device/5
        [HttpGet("{deviceId}", Name = "Get")]
        public DevicesResponseModel Get(int deviceId)
        {
            var deviceResponse = new DevicesResponseModel();

            try
            {
                var device = _deviceService.GetDeviceByID(deviceId);
                if (device == null)
                {
                    deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EntityNotFound));
                    return deviceResponse;
                }
                var model = _deviceMappingFactory.ToModel(device);
                deviceResponse.Data.Add(model);
            }
            catch (Exception e)
            {
                deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError));
            }

            return deviceResponse;
        }

        // POST: api/Device
        [HttpPost]
        public DevicesResponseModel Post([FromBody] DeviceModel deviceModel)
        {
            var deviceResponse = new DevicesResponseModel();
            try
            {

                if (deviceModel == null)
                    deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EmptyRequest));
                else
                {
                    var device = _deviceMappingFactory.ToDomain(deviceModel);
                    _deviceService.InsertDevice(device);
                    //await _deviceService.InsertDeviceAsync(device);
                    //var model = _deviceMappingFactory.ToModel(device);
                    deviceResponse.Data.Add(deviceModel);
                }
            }
            catch (Exception e)
            {
                deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError));
            }

            return deviceResponse;
        }
        //// POST: api/Device
        //[HttpPost]
        //public async Task<DevicesResponseModel> Post([FromBody] Device device)
        //{
        //    var deviceResponse = new DevicesResponseModel();
        //    try
        //    {

        //        if (device == null)
        //            deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EmptyRequest));
        //        else
        //        {
        //            await _deviceService.InsertDeviceAsync(device);
        //            var model = _deviceMappingFactory.ToModel(device);
        //            deviceResponse.Data.Add(model);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError));
        //    }

        //    return deviceResponse;
        //}

        // PUT: api/Device/5
        [HttpPut]
        public DevicesResponseModel Put([FromBody] Device device)
        {
            var deviceResponse = new DevicesResponseModel();
            try
            {

                if (device == null)
                    deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EmptyRequest));
                else
                {
                    _deviceService.UpdateDevice(device);
                    var model = _deviceMappingFactory.ToModel(device);
                    deviceResponse.Data.Add(model);
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
        public DevicesResponseModel Delete(int deviceId)
        {
            var deviceResponse = new DevicesResponseModel();
            try
            {
                var device = _deviceService.GetDeviceByID(deviceId);
                if (device == null)
                    deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.EmptyRequest));
                else
                {
                    _deviceService.DeleteDevice(device);
                    var model = _deviceMappingFactory.ToModel(device);
                    deviceResponse.Data.Add(model);
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
