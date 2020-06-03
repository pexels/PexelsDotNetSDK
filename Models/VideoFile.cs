using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class VideoFile
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("quality")]
        public string quality { get; set; }

        [JsonProperty("file_type")]
        public string fileType { get; set; }

        [JsonProperty("width")]
        public int? width { get; set; }

        [JsonProperty("height")]
        public int? height { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }
}
