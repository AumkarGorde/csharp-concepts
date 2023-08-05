using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandler
{
    public class ApplicationDependencyException: CustomBaseException
    {
        public object ErrorData { get; }
        public ApplicationDependencyException(ErrorCode errorCode, string errorDetails)
            :base($"ApplicationDependency Error -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}")
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
        }

        public ApplicationDependencyException(ErrorCode errorCode, string errorDetails, object errorData)
            : base($"ApplicationDependency Error -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}")
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
            ErrorData = errorData;
        }

        public ApplicationDependencyException(ErrorCode errorCode, string errorDetails, Exception innerException)
            : base($"ApplicationDependency Error -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}",innerException)
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
        }

        public ApplicationDependencyException(ErrorCode errorCode, string errorDetails, object errorData, Exception innerException)
            : base($"ApplicationDependency Error -> ErrorCode : {errorCode}, ErrorDetails : {errorDetails}", innerException)
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
            ErrorData = errorData;
        }
    }
}
