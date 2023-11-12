using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPattern.Adapter
{
    // Existing interface expected by client code
    public interface IDataReaderClient
    {
        void ReadData();
    }
}
