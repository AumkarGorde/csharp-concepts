using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.ViolatingRule
{
    /* We have a FileManager class that reads and writes data to files. 
     * This class combines two responsibilities: file reading and file writing. 
     * If there are changes required in how files are read or written, you would need to modify this class, which goes against the SRP.*/
    public class FileManager
    {
        public void ReadFile(string filePath)
        {
			try
			{
                Console.WriteLine($"Reading file {filePath}.... ");
            }
			catch (Exception)
			{
				throw;
			}
        } 

        public void WriteFile(string filePath)
        {
            try
            {
                Console.WriteLine($"Writing to file {filePath}.... ");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
