using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class Collection
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("private")]
        public bool isPrivate { get; set; }

        [JsonProperty("media_count")]
        public int mediaCount { get; set; }

        [JsonProperty("photos_count")]
        public int photosCount { get; set; }

        [JsonProperty("videos_count")]
        public int videosCount { get; set; }
    }
}
