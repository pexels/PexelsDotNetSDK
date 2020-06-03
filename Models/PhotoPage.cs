using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class PhotoPage : Page
    {
        [JsonProperty("photos")]
        public List<Photo> photos { get; set; }
    }
}
