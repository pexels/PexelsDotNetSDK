using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PexelsDotNetSDK.Models
{
    public abstract class Page
    {
        [JsonPropertyName("page")]
        public int page { get; set; }

        [JsonPropertyName("per_page")]
        public int perPage { get; set; }

        [JsonPropertyName("total_results")]
        public int totalResults { get; set; }

        [JsonPropertyName("next_page")]
        public string nextPage { get; set; }

        [JsonPropertyName("rate_limits")]
        public RateLimit rateLimit { get; set; }

    }

    public class RateLimit
    {
        [JsonPropertyName("account_limit")]
        public long Limit { get; set; }

        [JsonPropertyName("account_remaining")]
        public long Remaining { get; set; }

        [JsonPropertyName("account_reset_date")]
        public DateTime? Reset { get; set; }
    }
}
