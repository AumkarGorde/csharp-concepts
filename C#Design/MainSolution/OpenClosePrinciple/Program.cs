// See https://aka.ms/new-console-template for more information
/*----------------------------------------
 * Open-Close Principle
 * ---------------------------------------
 * Software entities (such as classes, modules, functions, etc.) should be open for extension but closed for modification. 
 * In other words, you should be able to extend the behavior of a software entity without changing its existing source code. 
 * This principle encourages you to design your code in a way that makes it easy to add new functionality without modifying the existing code, 
 * which helps maintain the stability of the existing system.*/


/*----------------------------------------
 * Violating OCP Sccenario
 * ---------------------------------------
 * We have a system that calculates the price of various products, and we have a class that calculates the price of each product. 
 * To calculate the price, the class has a method called CalculatePrice() 
 * Now, we want to introduce a discount for products that are on sale. 
 * To do this, if we modified the existing Product class, by adding some if condition or something else we are violating the Open-Closed Principle 
 *----------------------------------------
 *Complying OCP
 *----------------------------------------
 * To comply with the Open-Closed Principle, we should use an ABSTRACT class or INTERFACE and create separate classes to handle different types of products.
 * We can introduce a IProduct interface, and we can create two classes, RegularProduct and DiscountedProduct, to represent different product types. 
 * Each class implements the CalculatePrice method in its own way. Now, when we want to add new types of products or pricing strategies, 
 * you can do so by creating new classes without modifying the existing code, thus adhering to the Open-Closed Principle.
 */

/*Creating an interface or abstract class is important to avoid OCP violation */