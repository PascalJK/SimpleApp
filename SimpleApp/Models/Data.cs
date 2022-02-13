namespace SimpleApp.Models;

public class Data
{
    [JsonProperty("mal_id")]
    public int MalId;

    [JsonProperty("url")]
    public string Url;

    [JsonProperty("images")]
    public Images Images;

    [JsonProperty("trailer")]
    public Trailer Trailer;

    [JsonProperty("title")]
    public string Title;

    [JsonProperty("title_english")]
    public string TitleEnglish;

    [JsonProperty("title_japanese")]
    public string TitleJapanese;

    [JsonProperty("title_synonyms")]
    public List<string> TitleSynonyms;

    [JsonProperty("type")]
    public string Type;

    [JsonProperty("source")]
    public string Source;

    [JsonProperty("episodes")]
    public object Episodes;

    [JsonProperty("status")]
    public string Status;

    [JsonProperty("airing")]
    public bool Airing;

    [JsonProperty("aired")]
    public Aired Aired;

    [JsonProperty("duration")]
    public string Duration;

    [JsonProperty("rating")]
    public string Rating;

    [JsonProperty("score")]
    public double Score;

    [JsonProperty("scored_by")]
    public int ScoredBy;

    [JsonProperty("rank")]
    public int Rank;

    [JsonProperty("popularity")]
    public int Popularity;

    [JsonProperty("members")]
    public int Members;

    [JsonProperty("favorites")]
    public int Favorites;

    [JsonProperty("synopsis")]
    public string Synopsis;

    [JsonProperty("background")]
    public object Background;

    [JsonProperty("season")]
    public string Season;

    [JsonProperty("year")]
    public int Year;

    [JsonProperty("broadcast")]
    public Broadcast Broadcast;

    [JsonProperty("studios")]
    public List<Studio> Studios;

    [JsonProperty("genres")]
    public List<Genre> Genres;
}
