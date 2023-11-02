// See https://aka.ms/new-console-template for more information
/*-----------------------------------------
 *Dependency Inversion Principle
 *-----------------------------------------
 * High-level modules should not depend on low-level modules; both should depend on abstractions. 
 * In other words, you should depend on abstractions, not concretions
 */


/*----------------------------------
 * Violating DIP
 *----------------------------------
 *In this example, the Logger class has a direct dependency on the FileWriter class, 
 *which is a specific implementation for writing log messages to a file. 
 *This violates the DIP because the high-level Logger module is tightly coupled to the low-level FileWriter.
 */

/*-----------------------------------
 * Complying
 *-----------------------------------
 * ILogWriter interface that defines the Write method for writing log messages. 
 * Both the FileWriter and ConsoleWriter classes implement this interface. 
 * The Logger class no longer directly depends on a specific implementation; instead, it depends on the ILogWriter abstraction.
 */