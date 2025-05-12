using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CloudflareDDNS_UpdaterGUI.Models;
using Newtonsoft.Json;

namespace CloudflareDDNS_UpdaterGUI.Services
{
    public class CloudflareService
    {
        private readonly HttpClient _httpClient;
        private readonly CloudflareConfig _config;
        private const string BaseUrl = "https://api.cloudflare.com/client/v4/";

        public CloudflareService(CloudflareConfig config)
        {
            _config = config;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("X-Auth-Email", _config.Email);
            _httpClient.DefaultRequestHeaders.Add("X-Auth-Key", _config.ApiKey);
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Domain>> GetDomainsAsync()
        {
            var zones = await GetZonesAsync();
            var domains = new List<Domain>();

            foreach (var zone in zones)
            {
                var domain = new Domain
                {
                    Id = zone.Id,
                    Name = zone.Name,
                    Status = zone.Status
                };

                var records = await GetDnsRecordsAsync(zone.Id);
                domain.Records = records;
                domains.Add(domain);
            }

            return domains;
        }

        private async Task<List<ZoneResponse>> GetZonesAsync()
        {
            string endpoint = $"{BaseUrl}zones";
            
            if (!string.IsNullOrEmpty(_config.DomainName))
            {
                endpoint += $"?name={_config.DomainName}";
            }

            var response = await _httpClient.GetStringAsync(endpoint);
            var result = JsonConvert.DeserializeObject<CloudflareResponse<List<ZoneResponse>>>(response);

            if (result?.Success == true && result.Result != null)
            {
                return result.Result;
            }

            throw new Exception("Failed to retrieve zones: " + 
                (result?.Errors.Count > 0 ? result.Errors[0].Message : "Unknown error"));
        }

        public async Task<List<DnsRecord>> GetDnsRecordsAsync(string zoneId)
        {
            string endpoint = $"{BaseUrl}zones/{zoneId}/dns_records";
            var response = await _httpClient.GetStringAsync(endpoint);
            var result = JsonConvert.DeserializeObject<CloudflareResponse<List<DnsRecordResponse>>>(response);

            if (result?.Success == true && result.Result != null)
            {
                var records = new List<DnsRecord>();
                foreach (var record in result.Result)
                {
                    records.Add(new DnsRecord
                    {
                        Id = record.Id,
                        ZoneId = record.ZoneId,
                        Name = record.Name,
                        Type = record.Type,
                        Content = record.Content,
                        Proxied = record.Proxied,
                        Ttl = record.Ttl
                    });
                }
                return records;
            }

            throw new Exception("Failed to retrieve DNS records: " + 
                (result?.Errors.Count > 0 ? result.Errors[0].Message : "Unknown error"));
        }

        public async Task<bool> UpdateDnsRecordAsync(DnsRecord record, string newIp)
        {
            string endpoint = $"{BaseUrl}zones/{record.ZoneId}/dns_records/{record.Id}";

            var updateData = new
            {
                type = record.Type,
                name = record.Name,
                content = newIp,
                ttl = record.Ttl,
                proxied = record.Proxied
            };

            var json = JsonConvert.SerializeObject(updateData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(endpoint, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<CloudflareResponse<DnsRecordResponse>>(responseContent);

            if (result?.Success == true)
            {
                record.Content = newIp;
                return true;
            }

            throw new Exception("Failed to update DNS record: " + 
                (result?.Errors.Count > 0 ? result.Errors[0].Message : "Unknown error"));
        }
    }
}
