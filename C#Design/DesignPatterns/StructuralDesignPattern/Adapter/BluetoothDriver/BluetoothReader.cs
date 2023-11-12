using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPattern.Adapter.BluetoothDriver
{
    public class BluetoothReader : IBluetoothReader
    {
        public void GetData()
        {
            Console.WriteLine("Getting data from Bluetooth device");
        }
    }
}
