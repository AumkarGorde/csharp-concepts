// See https://aka.ms/new-console-template for more information

/*--------------------------------
 * Interface Segregation Principle
 * -------------------------------
 * Clients (classes or objects that use an interface) should not be forced to depend on methods they do not use. 
 * In other words, an interface should contain only the methods that are relevant to its implementing classes.
 */

/*----------------------------------
 *Violating ISP
 *----------------------------------
 *The IDocument interface mandates the Fax method, even though not all document types (e.g., PDF) can be faxed. 
 *This forces implementing classes like PdfDocument to provide an empty or irrelevant implementation for the Fax method, violating the ISP.
 */

/*----------------------------------
 *Complying ISP
 *----------------------------------
 *We've split the large IDocument interface into smaller interfaces (IPrintable, IScannable, and IFaxable) that focus on specific functionalities. 
 *Each document class now implements only the interfaces it needs. For example, PdfDocument implements IPrintable and IScannable, 
 *and WordDocument implements all three interfaces. This adheres to the ISP, ensuring that classes are not forced to implement methods they don't need.
 */

/* Here the most important part is spliting the interface */