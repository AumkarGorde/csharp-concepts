using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandler.ExceptionTypes
{
    public class BusinessRuleException: CustomBaseException
    {
        public object ErrorData { get; }
        public BusinessRuleException(ErrorCode errorCode, string errorDetails) :
            base($"BusinessRule Failed -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}")
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
        }

        public BusinessRuleException(ErrorCode errorCode, string errorDetails, object errorData)
            : base($"BusinessRule Failed -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}")
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
            ErrorData = errorData;
        }

        public BusinessRuleException(ErrorCode errorCode, string errorDetails, Exception innerException)
            : base($"BusinessRule Failed -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}", innerException)
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
        }

        public BusinessRuleException(ErrorCode errorCode, string errorDetails, object errorData, Exception innerException)
            : base($"BusinessRule Failed -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}", innerException)
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
            ErrorData = errorData;
        }
    }
}
