using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class CollectionPage : Page
    {
        [JsonProperty("collections")]
        public List<Collection> collections { get; set; }
    }
}
