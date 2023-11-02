using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.Complying
{
    public interface IProduct
    {
        double CalculatePrice(int quantity);
    }
}
