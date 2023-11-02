using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.Complying
{
    public class DiscountedProduct : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public double CalculatePrice(int quantity)
        {
            double discountedPrice = Price - (Discount * Price);
            return discountedPrice * quantity;
        }
    }
}
