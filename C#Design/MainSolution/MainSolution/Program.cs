// See https://aka.ms/new-console-template for more information
/* ----------------------------------------
 * Single Responsibility Principle
 * ----------------------------------------
 * A class should have only one reason to change. 
 * In other words, a class should have a single responsibility or purpose, and it should encapsulate(completely cover) that responsibility.  */

/* -----------------------------------------
 * Violating SRP 
 * -----------------------------------------
 * We have a FileManager class that reads and writes data to files. 
 * This class combines two responsibilities: file reading and file writing. 
 * If there are changes required in how files are read or written, you would need to modify this class, which goes against the SRP.*/

/* -----------------------------------------
 * Complying SRP
 * -----------------------------------------
 * We have separated the responsibilities of reading and writing files into two distinct classes: FileReader and FileWriter. 
 * This adheres to the SRP, making the code more maintainable and easier to understand, as each class now has a single, well-defined responsibility. 
 * If you need to change how file reading or writing is handled, you can do so without affecting the other responsibility.*/