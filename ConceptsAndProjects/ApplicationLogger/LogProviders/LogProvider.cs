using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogger
{
    public enum LogProvider
    {
        SeriLog,
        Log4Net,
        AWSCloudWatch
    }
}
