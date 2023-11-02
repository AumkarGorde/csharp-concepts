using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Violating
{
    public interface IDocument
    {
        void Print();
        void Scan();
        void Fax(); // Not all documents can be faxed
    }
}
