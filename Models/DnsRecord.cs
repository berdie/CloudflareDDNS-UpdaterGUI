using System;

namespace CloudflareDDNS_UpdaterGUI.Models
{
    public class DnsRecord
    {
        public string Id { get; set; } = string.Empty;
        public string ZoneId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public bool Proxied { get; set; }
        public int Ttl { get; set; }

        public bool NeedsUpdate(string newIp)
        {
            return Type == "A" && Content != newIp;
        }

        public override string ToString()
        {
            return $"{Name} ({Type}): {Content}";
        }
    }
}
