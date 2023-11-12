// See https://aka.ms/new-console-template for more information
using OOPS.Abstraction;
using OOPS.Encapsulation;
using OOPS.Inheritance;
using OOPS.Polymorphism;

Console.WriteLine("---Using abstract class and interface together---");
Duck myDuck = new Duck();
myDuck.Name = "Donald";

myDuck.Eat();        // Calls the method from the abstract class
myDuck.MakeSound();  // Calls the abstract method
myDuck.Swim();       // Calls the method from ISwimmable
myDuck.Fly();        // Calls the method from IFlyable


// Using polymorphism
Console.WriteLine("---using Polymorphism---");
Shape circle = new Circle();
Shape square = new Square();

//Base -to--> Derived
//Derived ---!=--> Base

circle.Draw();  // Calls the Draw method of the Circle class
square.Draw();  // Calls the Draw method of the Square class
circle.test();
square.test();

// Using inheritance
Console.WriteLine("---using inheritance---");
Dog myDog = new Dog();
myDog.Eat();   // Inherited method
myDog.Bark();  // Derived class method

// Using encapsulation
Person person = new Person();
person.Name = "John";
person.Age = -30;
person.DisplayInfo();


Console.WriteLine("Hello, World!");

