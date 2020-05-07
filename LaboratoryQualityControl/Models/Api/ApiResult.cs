using LaboratoryQualityControl.Models.Api;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LaboratoryQualityControl.Models
{

    [DataContract]
    public class ApiResult<TModel> where TModel : class, new()
    {
        #region [Ctor]
        public ApiResult()
        {
            Errors = new List<ApiError>();
            ResponseType = ApiResponseType.Data;
        }
        #endregion

        #region [Properties]

        [DataMember]
        public TModel Data { get; set; }

        [DataMember]
        public List<ApiError> Errors { get; set; }

        [DataMember]
        public ApiResponseType ResponseType { get; set; }

        [DataMember]
        public int RequestID { get; set; }

        #endregion
    }
}