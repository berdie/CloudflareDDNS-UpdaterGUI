using System;
using System.Collections.Generic;

namespace CloudflareDDNS_UpdaterGUI.Models
{
    public class Domain
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public List<DnsRecord> Records { get; set; } = new List<DnsRecord>();

        public override string ToString()
        {
            return Name;
        }
    }
}
