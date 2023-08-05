using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace ParallelExecution
{
    public static class HelperClass
    {
        public static void CreateFile(string folderName, string fileName)
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string randomText = generateText();

            string filePath = Path.Combine(folderPath, $"{fileName}.txt");
            File.WriteAllText(filePath, randomText);
        }

        private static string generateText()
        {
            Thread.Sleep(2000);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 1000) // Generate 1000 characters
                .Select(s => s[random.Next(s.Length)])
                .ToArray());
        }
    }
}
