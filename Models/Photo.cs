using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class Photo
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("photographer")]
        public string photographer { get; set; }

        [JsonPropertyName("photographer_url")]
        public string photographerUrl { get; set; }
        [JsonPropertyName("photographer_id")]
        public string photographerId { get; set; }

        [JsonPropertyName("src")]
        public Source source { get; set; }

        [JsonPropertyName("liked")]
        public bool liked { get; set; }
    }
}
