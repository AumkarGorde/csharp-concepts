using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPattern.Adapter
{
    public class DataReaderClient
    {
        private IDataReaderClient _dataReaderClient;
        public DataReaderClient(IDataReaderClient dataReaderClient)
        {
            _dataReaderClient = dataReaderClient;
        }
        public void ProcessData()
        {
            _dataReaderClient.ReadData();
        }
    }
}
