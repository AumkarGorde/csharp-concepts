using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Complying
{
    public class PdfDocument : IPrintable, IScannable
    {
        public void Print()
        {
            // PDF printing logic
        }

        public void Scan()
        {
            // PDF scanning logic
        }
    }
}
