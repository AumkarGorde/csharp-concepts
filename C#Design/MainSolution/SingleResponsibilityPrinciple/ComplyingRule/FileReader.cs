using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.ComplyingRule
{
    public class FileReader
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
    }
}
