using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Complying
{
    public class WordDocument : IPrintable, IScannable, IFaxable
    {
        public void Print()
        {
            // Word printing logic
        }

        public void Scan()
        {
            // Word scanning logic
        }

        public void Fax()
        {
            // Word faxing logic
        }
    }
}
