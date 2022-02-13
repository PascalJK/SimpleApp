namespace SimpleApp.ViewModels;

public class RecentAnimeEpisodesViewModel : BaseVM
{
    public ObservableRangeCollection<Root> AnimeCollection { get; set; } = new();
    public ICommand LoadAnimeInfoCmd => new AsyncCommand<Root>(GetAnimeInfoAsync);

    public async Task GetRecentAnimeEpisodesAsync()
    {
        try
        {
            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(ApiUrls._recentEpisodesUrl);
            var json = await response.Content.ReadAsStringAsync();

            var recentAnimeList = JsonConvert.DeserializeObject<AnimeList>(json);
            int count = 0;
            foreach (var root in recentAnimeList.Data)
            {
                Console.WriteLine(root.Entry.Title);
                root.FindLatestEdisode();
                Console.WriteLine(root.Episode.Title);
                if (count < 8)
                {
                    if (root.Episode != null)
                        await DisplayAlert(root.Entry.Title, $"{root.Entry.Url}\n\n{root.Episode.Title}");
                    else
                        await DisplayAlert("Null", "Something went wrong!");
                    count++;
                }
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message);
        }
    }
    public async Task GetAnimeInfoAsync(Root root)
    {
        var httpClient = new HttpClient();
        HttpResponseMessage response = await httpClient.GetAsync(ApiUrls.GetAnimeInfoById($"{root.Data.MalId}"));
        var json = await response.Content.ReadAsStringAsync();
        Root animeInfo = JsonConvert.DeserializeObject<Root>(json);
        await DisplayAlert(animeInfo.Data.Title, animeInfo.Data.Synopsis);
    }
}
