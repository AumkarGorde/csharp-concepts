using System;

namespace cConstructorChaining
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int QuantityInStock { get; }

        public Product() : this("Default Product", 0.0, 0)
        {
            // Additional default initialization logic
        }

        public Product(string name) : this(name, 0.0, 0)
        {
            // Additional initialization logic for setting the name
        }

        public Product(string name, double price) : this(name, price, 0)
        {
            // Additional initialization logic for setting the name and price
        }
        /// <summary>
        /// This constructor is invoked first, no matter in whatever way you create an object, after that the parameter specific constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="quantityInStock"></param>
        public Product(string name, double price, int quantityInStock)
        {
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
            // Common initialization logic
        }

        /* 
     * 1. Constructor chaining in C# refers to the practice of calling one constructor from another constructor within the same class or in a derived class.
     * 2. It allows you to avoid duplicating initialization code and promotes code reuse by centralizing the common initialization logic in one place. 
       3.  Constructor chaining helps ensure that the essential setup for an object is performed consistently, regardless of which constructor is used to create an instance.
       4. In C#, you can achieve constructor chaining using the this keyword to invoke other constructors within the same class, or the base keyword to invoke constructors in the base class (for derived classes).*/
    }
}
