using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Singleton
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static readonly object lockObject = new object();
        private Dictionary<string, string> settings;
        // Private constructor to prevent instantiation from outside
        private ConfigurationManager()
        {
            // Initialize settings (this could be loaded from a configuration file, database, etc.)
            settings = new Dictionary<string, string>
            {
                { "ConnectionString", "your_connection_string" },
                { "LogLevel", "Info" }
            };
        }

        // A public getter to create an intance
        public static ConfigurationManager Instance
        {
            get
            {
                // Double-check locking to ensure thread safety
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new ConfigurationManager();
                        }
                    }
                }
                return instance;
            }
        }

        //exposed the main method here
        public string GetSetting(string key)
        {
            // Get a configuration setting by key
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            else
            {
                return string.Empty; // or throw an exception, handle accordingly
            }
        }
    }
}
