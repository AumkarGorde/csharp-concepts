using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogger
{
    public interface ICustomLogger
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message, Exception exception = null);
    }
}
