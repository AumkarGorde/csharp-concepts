using StructuralDesignPattern.Adapter.BluetoothDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPattern.Adapter.AdapterImplementation
{
    public class BluetoothAdapter : IDataReaderClient
    {
        private IBluetoothReader _bluetoothReader;
        public BluetoothAdapter(IBluetoothReader bluetoothReader)
        {
            _bluetoothReader = bluetoothReader;
        }
        public void ReadData()
        {
            // Adapt the method call to match the existing interface
            _bluetoothReader.GetData();
        }
    }
}
