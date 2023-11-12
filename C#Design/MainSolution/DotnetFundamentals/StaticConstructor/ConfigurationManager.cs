using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFundamentals.StaticConstructor
{
    public class ConfigurationManager
    {
        private static Dictionary<string, string> settings;

        // Static constructor
        /*only static methods and properties initialiesed*/
        static ConfigurationManager()
        {
            LoadConfiguration();
        }
        public ConfigurationManager()
        {
            
        }
        // Method to load configuration settings from a file (simulated for the example)
        private static void LoadConfiguration()
        {
            try
            {
                // Simulate loading configuration from a file
                settings = new Dictionary<string, string>();
                string[] lines = File.ReadAllLines("config.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();
                        settings[key] = value;
                    }
                }

                Console.WriteLine("Configuration loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading configuration: {ex.Message}");
            }
        }

        // Method to get a configuration setting by key
        public static string GetSetting(string key)
        {
            if (settings != null && settings.ContainsKey(key))
            {
                return settings[key];
            }
            else
            {
                Console.WriteLine($"Setting not found for key: {key}");
                return null;
            }
        }
    }
}
