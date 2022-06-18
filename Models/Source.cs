using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class Source
    {
        [JsonPropertyName("original")]
        public string original { get; set; }

        [JsonPropertyName("large")]
        public string large { get; set; }

        [JsonPropertyName("large2x")]
        public string large2x { get; set; }

        [JsonPropertyName("medium")]
        public string medium { get; set; }

        [JsonPropertyName("small")]
        public string small { get; set; }

        [JsonPropertyName("portrait")]
        public string portrait { get; set; }

        [JsonPropertyName("landscape")]
        public string landscape { get; set; }

        [JsonPropertyName("tiny")]
        public string tiny { get; set; }
    }
}
