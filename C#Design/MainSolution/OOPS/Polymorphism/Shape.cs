using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Polymorphism
{
    public class Shape
    {
        public void test()
        {
            Console.WriteLine("Base Shape test called");
        }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    // Derived classes
    public class Circle : Shape
    {
        //example of method hidding this test method is never called but base test method is called
        // even if you remove the new keyword base test method is called
        public new void test()
        {
            Console.WriteLine("Deried -circle called");
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    public class Square : Shape
    {
        public new void test()
        {
            Console.WriteLine("Deried -sqaure called");
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
