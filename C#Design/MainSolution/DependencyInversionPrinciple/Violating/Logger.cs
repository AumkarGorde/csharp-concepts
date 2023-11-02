using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Violating
{
    public class Logger
    {
        private FileWriter fileWriter = new FileWriter();

        public void Log(string message)
        {
            fileWriter.WriteToFile(message);
        }
    }
}
