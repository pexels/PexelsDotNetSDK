using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class VideoFile
    {

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("quality")]
        public string quality { get; set; }

        [JsonPropertyName("file_type")]
        public string fileType { get; set; }

        [JsonPropertyName("width")]
        public int? width { get; set; }

        [JsonPropertyName("height")]
        public int? height { get; set; }

        [JsonPropertyName("link")]
        public string link { get; set; }
    }
}
