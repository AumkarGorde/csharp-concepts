using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPattern.Adapter.Drivers
{
    public class USBDrive : IDataReaderClient
    {
        public void ReadData()
        {
            Console.WriteLine("Reading data from USB drive");
        }
    }
}
