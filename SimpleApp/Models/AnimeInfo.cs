namespace SimpleApp.Models;

public class Jpg
{
    [JsonProperty("image_url")]
    public string ImageUrl;

    [JsonProperty("small_image_url")]
    public string SmallImageUrl;

    [JsonProperty("large_image_url")]
    public string LargeImageUrl;
}

public class Images
{
    [JsonProperty("jpg")]
    public Jpg Jpg;

    [JsonProperty("image_url")]
    public string ImageUrl;

    [JsonProperty("small_image_url")]
    public string SmallImageUrl;

    [JsonProperty("medium_image_url")]
    public string MediumImageUrl;

    [JsonProperty("large_image_url")]
    public string LargeImageUrl;

    [JsonProperty("maximum_image_url")]
    public string MaximumImageUrl;
}

public class Trailer
{
    [JsonProperty("youtube_id")]
    public string YoutubeId;

    [JsonProperty("url")]
    public string Url;

    [JsonProperty("embed_url")]
    public string EmbedUrl;

    [JsonProperty("images")]
    public Images Images;
}

public class From
{
    [JsonProperty("day")]
    public int Day;

    [JsonProperty("month")]
    public int Month;

    [JsonProperty("year")]
    public int Year;
}

public class To
{
    [JsonProperty("day")]
    public object Day;

    [JsonProperty("month")]
    public object Month;

    [JsonProperty("year")]
    public object Year;
}

public class Prop
{
    [JsonProperty("from")]
    public From From;

    [JsonProperty("to")]
    public To To;
}

public class Aired
{
    [JsonProperty("from")]
    public DateTime From;

    [JsonProperty("to")]
    public object To;

    [JsonProperty("prop")]
    public Prop Prop;

    [JsonProperty("string")]
    public string String;
}

public class Broadcast
{
    [JsonProperty("day")]
    public string Day;

    [JsonProperty("time")]
    public string Time;

    [JsonProperty("timezone")]
    public string Timezone;

    [JsonProperty("string")]
    public string String;
}

public class Studio
{
    [JsonProperty("mal_id")]
    public int MalId;

    [JsonProperty("type")]
    public string Type;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("url")]
    public string Url;
}

public class Genre
{
    [JsonProperty("mal_id")]
    public int MalId;

    [JsonProperty("type")]
    public string Type;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("url")]
    public string Url;
}
public class Entry
{
    [JsonProperty("mal_id")]
    public int MalId;

    [JsonProperty("url")]
    public string Url;

    [JsonProperty("images")]
    public Images Images;

    [JsonProperty("title")]
    public string Title;
}
public class Episode
{
    [JsonProperty("mal_id")]
    public int MalId;

    [JsonProperty("url")]
    public string Url;

    [JsonProperty("title")]
    public string Title;

    [JsonProperty("premium")]
    public bool Premium;
}

public class Root
{
    [JsonProperty("data")]
    public Data Data;
    [JsonProperty("entry")]
    public Entry Entry;
    [JsonProperty("episodes")]
    public List<Episode> Episodes;
}
