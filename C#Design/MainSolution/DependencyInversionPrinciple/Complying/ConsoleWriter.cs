﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Complying
{
    public class ConsoleWriter : ILogWriter
    {
        public void Write(string message)
        {
            // Write the message to the console
        }
    }
}
