// See https://aka.ms/new-console-template for more information
using LiskovSubstitutionPrinciple.Violating;

var ostrich = new Ostrich();
ostrich.Fly(); // Violating LSP

/*--------------------------------------
 * Liskov Principle
 * -------------------------------------
 * A child class should be able to substitute the parent class seamlessly during runntime polymorphism
 * --------------------------------------
 * Liskov Problem
 * --------------------------------------
 * Liskov problem arises when the requirements are not clear 
 * We have a system with a base class Bird and two derived classes, Ostrich and Penguin, representing different types of birds. 
 * The Bird class has a Fly method, as most birds can fly. However, ostriches and penguins cannot fly. 
 * In this example, we're ran into Liskov problem because the Ostrich and Penguin should not have any relation with flying.
 * When Liskov problem arises there is a need to change the base class, as our understanding was not clear or we had incomplete information
 */