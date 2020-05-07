using System;
using System.Runtime.Serialization;

namespace LaboratoryQualityControl.Models.Api
{
    [DataContract]
    public class ApiRequest
    {
        #region [Ctor]
        public ApiRequest()
        {

        }
        #endregion

        #region  [Methods]
        public string FullTocken()
        {
            return LockSerial + ApiTocken.ToString();
        }
        #endregion

        #region [Properties]

        [DataMember]
        public string LockSerial { get; set; }

        [DataMember]
        public Guid ApiTocken { get; set; }

        public string HashData { get; set; }

        #endregion
    }
    [DataContract]
    public class ApiRequest<TRequiredModel> : ApiRequest
    {
        #region [Ctor]
        public ApiRequest() : base()
        {
        }
        #endregion


        #region [Properties]
        [DataMember]
        public TRequiredModel Data { get; set; }

        #endregion
    }
}