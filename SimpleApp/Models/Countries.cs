using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimpleApp.Models
{
    public class Country
    {
        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }
    }
}
