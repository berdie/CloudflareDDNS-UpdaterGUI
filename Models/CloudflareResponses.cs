using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CloudflareDDNS_UpdaterGUI.Models
{
    public class CloudflareResponse<T>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errors")]
        public List<CloudflareError> Errors { get; set; } = new List<CloudflareError>();

        [JsonProperty("result")]
        public T? Result { get; set; }

        [JsonProperty("result_info")]
        public ResultInfo? ResultInfo { get; set; }
    }

    public class CloudflareError
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; } = string.Empty;
    }

    public class ResultInfo
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class ZoneResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class DnsRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("zone_id")]
        public string ZoneId { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        [JsonProperty("content")]
        public string Content { get; set; } = string.Empty;

        [JsonProperty("proxied")]
        public bool Proxied { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }
    }
}
