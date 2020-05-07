using System.Runtime.Serialization;

namespace LaboratoryQualityControl.Models.Api
{
    [DataContract]
    public class ApiError
    {
        #region [Ctor]
        public ApiError()
        {
        }
        public ApiError(ErrorCodeEnum errorCode)
        {
            ErrorCode = errorCode;
            //ErrorDescription = ErrorMessageService.ErrorMessage(errorCode);
        }
        public ApiError(ErrorCodeEnum errorCode, string errorDescription)
        {
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
        }
        #endregion

        #region [Properties]
        [DataMember]
        public ErrorCodeEnum ErrorCode { get; set; }

        [DataMember]
        public string ErrorDescription { get; set; }

        #endregion
    }

    [DataContract]
    public enum ErrorCodeEnum
    {
        UnknownError,
        EntityNotFound,
        EmptyRequest,
        InvalidTocken,
        NotFoundStore,
        InvalidTockenAndSerial,
        InvalidChecksum,
        InvalidRequestData,

        InsuranceBaseCodeIsEmpty = 21
    }
}