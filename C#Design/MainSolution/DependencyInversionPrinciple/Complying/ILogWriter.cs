using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Complying
{
    public interface ILogWriter
    {
        void Write(string message);
    }
}
