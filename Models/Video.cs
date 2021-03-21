using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class Video
    {

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }

        [JsonPropertyName("duration")]
        public int duration { get; set; }

        [JsonPropertyName("user")]
        public User user { get; set; }

        [JsonPropertyName("video_files")]
        public IEnumerable<VideoFile> videoFiles { get; set; }

        [JsonPropertyName("video_pictures")]
        public IEnumerable<VideoPicture> videoPictures { get; set; }
    }
}
