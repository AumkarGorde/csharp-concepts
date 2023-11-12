using StructuralDesignPattern.Adapter;
using StructuralDesignPattern.Adapter.AdapterImplementation;
using StructuralDesignPattern.Adapter.BluetoothDriver;
using StructuralDesignPattern.Adapter.Drivers;

Console.WriteLine("Adapter Pattern");

// This is normal way of calling the usb read data function 
USBDrive usbDriver = new USBDrive();
DataReaderClient dataReader = new DataReaderClient(usbDriver);
dataReader.ProcessData();

// This is via the adapter pattern as the 
BluetoothReader bluetoothReader = new BluetoothReader();
BluetoothAdapter dataReaderClient1 = new BluetoothAdapter(bluetoothReader);
DataReaderClient dataReader2 = new DataReaderClient(dataReaderClient1);
dataReader2.ProcessData();

Console.WriteLine();

/*
1. Identify the client class is using the target interface (IDataReaderClient) -> DataReaderClient
2. Identify the Adaptee: New interface that needs to be adapted -> IBluetoothReader
3. Create adapter class implementing target interface (BluetoothAdapter) and inject Adaptee interface IBluetoothReader
3. The cossumption should be done via the Client code -> DataReaderClient
 */