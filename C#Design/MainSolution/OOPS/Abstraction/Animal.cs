using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    /*--------------------ABSTRACT CLASS---------------------------*/
    /*---Cannot create instance of abstract class--*/
    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal");
        }
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public abstract void MakeSound();  // Abstract method
    }

    /*----------------------------------------------------------------------------------------------------------------*/
    public interface ISwimmable
    {
        void Swim();
    }

    /*-----------------------------------------------------------------------------------------------------------------*/
    public interface IFlyable
    {
        void Fly();
    }

    /*------------------------------------------------------------------------------------------------------------------*/
    // Concrete class implementing abstract class and interfaces
    // You can only have one abstract class to one derived class multiple inheritance not supported in C#
    public class Duck : Animal, ISwimmable, IFlyable
    {
        public Duck()
        {
            Console.WriteLine("Duck");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Quack!");
        }

        public void Swim()
        {
            Console.WriteLine("Duck is swimming.");
        }

        public void Fly()
        {
            Console.WriteLine("Duck is flying.");
        }
    }

}
