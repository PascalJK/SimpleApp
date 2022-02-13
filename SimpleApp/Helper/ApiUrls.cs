namespace SimpleApp.Helper;

public static class ApiUrls
{
    public static string _recentEpisodesUrl = "https://api.jikan.moe/v4/watch/episodes";

    public static string GetAnimeInfoById(string id)
    {
        return string.IsNullOrWhiteSpace(id) 
            ? throw new ArgumentNullException(nameof(id)) 
            : $"https://api.jikan.moe/v4/anime/{id}/moreinfo";
    }

    public static Root DeserializeRootJson(string json) 
        => JsonConvert.DeserializeObject<Root>(json);
}
