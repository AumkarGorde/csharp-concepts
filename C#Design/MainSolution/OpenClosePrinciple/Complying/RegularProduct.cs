using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.Complying
{
    public class RegularProduct : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double CalculatePrice(int quantity)
        {
            return Price * quantity;
        }
    }
}
