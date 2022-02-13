namespace SimpleApp.Models;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

public class Datum
{
    [JsonProperty("entry")]
    public Entry Entry;

    [JsonProperty("episodes")]
    public List<Episode> Episodes;

    [JsonProperty("region_locked")]
    public bool RegionLocked;
    public Episode Episode { get; set; } = new();

    public void FindLatestEdisode()
    {
        if (Episodes != null)
        {
            var episodes = Episodes.OrderByDescending(e => e.MalId);
            Episode = episodes.FirstOrDefault();
        }
    }
}

public class AnimeList
{
    [JsonProperty("data")]
    public List<Datum> Data;
}


