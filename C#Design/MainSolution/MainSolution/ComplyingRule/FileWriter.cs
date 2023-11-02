using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.ComplyingRule
{
    public class FileWriter
    {
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
