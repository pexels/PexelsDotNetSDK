using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class VideoPage : Page
    {
        [JsonPropertyName("videos")]
        public IEnumerable<Video> videos { get; set; }
    }
}
