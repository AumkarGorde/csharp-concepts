using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Complying
{
    public class Logger
    {
        private ILogWriter logWriter;

        public Logger(ILogWriter writer)
        {
            logWriter = writer;
        }

        public void Log(string message)
        {
            logWriter.Write(message);
        }
    }
}
