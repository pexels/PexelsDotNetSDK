using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class PhotoPage : Page
    {
        [JsonPropertyName("photos")]
        public List<Photo> photos { get; set; }
    }
}
