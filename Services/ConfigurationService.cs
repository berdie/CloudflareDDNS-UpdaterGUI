using System;
using System.IO;
using CloudflareDDNS_UpdaterGUI.Models;
using Newtonsoft.Json;

namespace CloudflareDDNS_UpdaterGUI.Services
{
    public class ConfigurationService
    {
        private readonly string _configFilePath;

        public ConfigurationService()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(appDataPath, "CloudflareDDNSUpdater");
            
            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }

            _configFilePath = Path.Combine(appFolder, "config.json");
        }

        public void SaveConfig(CloudflareConfig config)
        {
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(_configFilePath, json);
        }

        public CloudflareConfig LoadConfig()
        {
            if (File.Exists(_configFilePath))
            {
                string json = File.ReadAllText(_configFilePath);
                try
                {
                    var config = JsonConvert.DeserializeObject<CloudflareConfig>(json);
                    return config ?? new CloudflareConfig();
                }
                catch
                {
                    return new CloudflareConfig();
                }
            }
            return new CloudflareConfig();
        }
    }
}
