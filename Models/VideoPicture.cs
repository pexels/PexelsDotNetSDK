using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class VideoPicture
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("picture")]
        public string picture { get; set; }

        [JsonProperty("nr")]
        public int nr { get; set; }
    }
}
