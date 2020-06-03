using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class VideoPage : Page
    {
        [JsonProperty("videos")]
        public IEnumerable<Video> videos { get; set; }
    }
}
