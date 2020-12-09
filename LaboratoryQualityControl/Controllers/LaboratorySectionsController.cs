using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Factories.LaboratorySection;
using LaboratoryQualityControl.Models.Api;
using LaboratoryQualityControl.Models.LaboratorySection;
using LaboratoryQualityControl.Services.LaboratorySections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace LaboratoryQualityControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratorySectionsController : ControllerBase
    {
        #region [Fields]
        private ILaboratorySectionService _laboratorySectionService;
        private ILaboratorySectionMappingFactory _laboratorySectionMappingFactory;

        //private readonly LaboratoryQCContext _context;
        #endregion
        #region [Ctor]
        public LaboratorySectionsController(ILaboratorySectionService laboratorySectionService,ILaboratorySectionMappingFactory laboratorySectionMappingFactory)
        {
            _laboratorySectionService = laboratorySectionService;
            _laboratorySectionMappingFactory = laboratorySectionMappingFactory;
            //_context = context;
        }
        #endregion
        #region [Methods]
        // GET: api/LaboratorySections
        [HttpGet]
        public LaboratorySectionResponseModel Get()
        {
            var laboratorySectionResponseModel = new LaboratorySectionResponseModel();
            try
            {
                var laboratorySections = _laboratorySectionService.GetAllLaboratorySections();
                foreach (LaboratorySection laboratorySection in laboratorySections)
                {
                    var model = _laboratorySectionMappingFactory.ToModel(laboratorySection);
                    laboratorySectionResponseModel.Data.Add(model);
                }
                laboratorySectionResponseModel.Count = laboratorySectionResponseModel.Data.Count;
                laboratorySectionResponseModel.Items = laboratorySectionResponseModel.Data;
            }
            catch(Exception e)
            {
                laboratorySectionResponseModel.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError, "UnknownError"));
            }
            return laboratorySectionResponseModel;
        }
        #endregion

    }
}
