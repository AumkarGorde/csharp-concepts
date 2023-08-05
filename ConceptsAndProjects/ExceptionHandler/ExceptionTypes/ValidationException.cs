using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandler
{
    public class ValidationException: CustomBaseException
    {
        public object ErrorData { get; }
        public ValidationException(ErrorCode errorCode, string errorDetails) :
            base($"Validation Failed -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}")
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
        }

        public ValidationException(ErrorCode errorCode, string errorDetails, object errorData)
            : base($"Validation Failed -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}")
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
            ErrorData = errorData;
        }

        public ValidationException(ErrorCode errorCode, string errorDetails, Exception innerException)
            : base($"Validation Failed -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}", innerException)
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
        }

        public ValidationException(ErrorCode errorCode, string errorDetails, object errorData, Exception innerException)
            : base($"Validation Failed -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}", innerException)
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
            ErrorData = errorData;
        }
    }
}
