using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class VideoPicture
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("picture")]
        public string picture { get; set; }

        [JsonPropertyName("nr")]
        public int nr { get; set; }
    }
}
