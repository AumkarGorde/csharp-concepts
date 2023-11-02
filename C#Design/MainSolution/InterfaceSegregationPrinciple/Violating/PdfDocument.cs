using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Violating
{
    public class PdfDocument : IDocument
    {
        public void Print()
        {
            // PDF printing logic
        }

        public void Scan()
        {
            // PDF scanning logic
        }

        public void Fax()
        {
            // PDF faxing logic (may not be applicable)
        }
    }
}
