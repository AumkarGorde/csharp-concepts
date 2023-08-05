using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandler
{
    public enum ErrorCode
    {
        /*Application Dependency Error Code*/
        HTTP_FAILURE = 1001,
        FTP_FAILURE = 1002,

        /*Validation Failure*/
        NAME_VALIDATION_FAILED = 2001,

        /*Business Rule Failure*/
        DATA_ENTRY_RULE_FAILED = 3001,

        UNKOWN_ERROR=1
    }
}
