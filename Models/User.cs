using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class User
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }
}
