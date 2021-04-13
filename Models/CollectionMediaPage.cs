using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class CollectionMediaPage : Page
    {
        [JsonProperty("media")]
        public List<CollectionMedia> media { get; set; }
    }
}
