using System;
using Newtonsoft.Json;

namespace CloudflareDDNS_UpdaterGUI.Models
{
    public class CloudflareConfig
    {
        public string ApiKey { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string DomainName { get; set; } = string.Empty;

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(ApiKey) && 
                   !string.IsNullOrWhiteSpace(Email) && 
                   !string.IsNullOrWhiteSpace(DomainName);
        }
    }
}
