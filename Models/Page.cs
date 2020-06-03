using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{ 
    public abstract class Page
    {
        [JsonProperty("page")]
        public int page { get; set; }

        [JsonProperty("per_page")]
        public int perPage { get; set; }

        [JsonProperty("total_results")]
        public int totalResults { get; set; }

        [JsonProperty("next_page")]
        public string nextPage { get; set; }

        [JsonProperty("rate_limits")]
        public RateLimit rateLimit { get; set; }

    }

    public class RateLimit
    {
        [JsonProperty("account_limit")]
        public long Limit { get; set; }

        [JsonProperty("account_remaining")]
        public long Remaining { get; set; }

        [JsonProperty("account_reset_date")]
        public DateTime? Reset { get; set; }
    }
}
