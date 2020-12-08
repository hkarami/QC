using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaboratoryQualityControl.Services.DeviceTypes;
using LaboratoryQualityControl.Models.Devices;
using LaboratoryQualityControl.Factories;
using LaboratoryQualityControl.Factories.DeviceTypes;
using LaboratoryQualityControl.Models.Api;
using LaboratoryQualityControl.Models.DeviceTypes;

namespace LaboratoryQualityControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceTypesController : ControllerBase
    {
        #region [Fields]
        private IDeviceTypeServie _deviceTypeServie;
        private IDeviceTypeModelFactory _deviceTypeModelFactory;
        //private readonly LaboratoryQCContext _context;
        #endregion
        #region [Ctor]
        public DeviceTypesController(IDeviceTypeServie deviceTypeServie,IDeviceTypeModelFactory deviceTypeModelFactory)
        {
            _deviceTypeServie = deviceTypeServie;
            _deviceTypeModelFactory = deviceTypeModelFactory;
        }
        #endregion
        #region [Methods]
        // GET: api/DeviceType
        [HttpGet]
        public DeviceTypesResponseModel Get()
        {
            var deviceTypeResponse = new DeviceTypesResponseModel();
            try
            {
                var deviceTypes = _deviceTypeServie.GetAllDeviceTypes();

                foreach (var deviceType in deviceTypes)
                {
                    var model = _deviceTypeModelFactory.ToModel(deviceType);
                    deviceTypeResponse.Data.Add(model);
                }

                deviceTypeResponse.Count = deviceTypeResponse.Data.Count;
                deviceTypeResponse.Items = deviceTypeResponse.Data;
                //deviceResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError, "UnknownError"));
            }
            catch (Exception e)
            {
                deviceTypeResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError, "UnknownError"));
            }

            return deviceTypeResponse;
        }
        #endregion

    }
}
