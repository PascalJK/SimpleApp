using Newtonsoft.Json;

namespace SimpleApp.Models
{
    public class TimeModel
    {
        [JsonProperty("$id")]
        public long Id { get; set; }

        [JsonProperty("currentDateTime")]
        public string CurrentDateTime { get; set; }

        [JsonProperty("utcOffset")]
        public string UtcOffset { get; set; }

        [JsonProperty("dayOfTheWeek")]
        public string DayOfTheWeek { get; set; }

        [JsonProperty("timeZoneName")]
        public string TimeZoneName { get; set; }

        [JsonProperty("currentFileTime")]
        public double CurrentFileTime { get; set; }

        [JsonProperty("ordinalDate")]
        public string OrdinalDate { get; set; }

        [JsonProperty("serviceResponse")]
        public object ServiceResponse { get; set; }
    }
}
