using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class CollectionMedia
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("width")]
        public int width { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }
        
        [JsonProperty("duration")]
        public int duration { get; set; }

        [JsonProperty("full_res")]
        public string fullRes { get; set; }

        [JsonProperty("tags")]
        public string[] tags { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("avg_color")]
        public string avgColor { get; set; }

        [JsonProperty("user")]
        public User user { get; set; }

        [JsonProperty("video_files")]
        public IEnumerable<VideoFile> videoFiles { get; set; }

        [JsonProperty("video_pictures")]
        public IEnumerable<VideoPicture> videoPictures { get; set; }

        [JsonProperty("photographer")]
        public string photographer { get; set; }

        [JsonProperty("photographer_url")]
        public string photographerUrl { get; set; }

        [JsonProperty("photographer_id")]
        public string photographerId { get; set; }

        [JsonProperty("src")]
        public Source source { get; set; }

        [JsonProperty("liked")]
        public bool liked { get; set; }

    }
}
