using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.Violating
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double CalculatePrice(int quantity)
        {
            return Price * quantity;
        }
    }
    // Later, we want to introduce a discount for products on sale. Same class Product upadted,
    // here name is changed from Product to ProductUpdated to avoid compile time error, but the same class will be updated
    public class ProductUpdated
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; } // New property for discount

        public double CalculatePrice(int quantity)
        {
            double discountedPrice = Price - (Discount * Price);
            return discountedPrice * quantity;
        }
    }

}
