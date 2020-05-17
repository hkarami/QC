using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Models;
using LaboratoryQualityControl.Models.Analytes;
using LaboratoryQualityControl.Models.Api;
using LaboratoryQualityControl.Services.Analytes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoryQualityControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyteController : ControllerBase
    {
        #region [Fields]

        private IAnalyteService _analyteService;
        #endregion
        #region [Ctor]
        public AnalyteController(IAnalyteService analyteService)
        {
            _analyteService = analyteService;
        }
        #endregion
        #region [Utilities]
        private AnalyteModel ToModel(Analyte  analyte)
        {
            return  new AnalyteModel
            {
                AnalyteID=analyte.AnalyteID,
                AnalyteName= analyte.AnalyteName,
                Appedix=analyte.Appedix,
                Levels=analyte.Levels,
                UnitID=analyte.UnitID,
                UnitName=analyte.Unit?.UnitName,
                Decimals =analyte.Decimals,
                Min=analyte.Min,
                Max=analyte.Max,
                RulesQCID=analyte.RulesQCID,
                RulesQCName=analyte.RulesQC.Name,
                Visible =analyte.Visible,
                InOrder=analyte.InOrder,
                UserCode=analyte.UserCode,
                NikeName = analyte.User?.NickName,
                LastUpdateTime=analyte.LastUpdateTime,
                RecordTime=analyte.RecordTime
    };

        }
#endregion
        // GET: api/Analyte
        [HttpGet]
        public AnalyteResponseModel Get()
        {
            var analyteResponse=new AnalyteResponseModel();
            try
            {
                var analytes = _analyteService.GetAllAnalyte();
                foreach (var analyte in analytes)
                {
                    analyteResponse.Data.Add(ToModel(analyte));
                }

                analyteResponse.Count = analyteResponse.Data.Count;
                analyteResponse.Items = analyteResponse.Data;

            }
            catch (Exception e)
            {
                analyteResponse.Errors.Add(new ApiError(ErrorCodeEnum.UnknownError, "UnknownError"));
            }

            return analyteResponse;
        }

        // GET: api/Analyte/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Analyte
        [HttpPost]
        public void Post([FromBody] Analyte analyte)
        {

        }

        // PUT: api/Analyte/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
