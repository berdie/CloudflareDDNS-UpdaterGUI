using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudflareDDNS_UpdaterGUI.Services
{
    public class IpService
    {
        private readonly HttpClient _httpClient;

        public IpService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetCurrentIpAsync()
        {
            try
            {
                // Try the first service
                var ip = await TryGetIpFromService("https://ipv4.icanhazip.com/");
                if (!string.IsNullOrWhiteSpace(ip))
                    return ip;

                // Try the second service as fallback
                return await TryGetIpFromService("https://api.ipify.org");
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve current IP address", ex);
            }
        }

        private async Task<string> TryGetIpFromService(string url)
        {
            try
            {
                var response = await _httpClient.GetStringAsync(url);
                return response.Trim();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
