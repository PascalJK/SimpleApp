using SimpleApp.ViewModels.Base;

namespace SimpleApp.ViewModels;

public class TimePgVM : BaseVM
{
    private string _CurrentTime;
    private string _UtcOffset;
    private string _TimeZone;
    private string _JsonUntouched;
    public string Url { get; set; } = "http://worldclockapi.com/api/json/est/now";

    public string CurrentTime { get => _CurrentTime; set => SetProperty(ref _CurrentTime, value); }
    public string UtcOffset { get => _UtcOffset; set => SetProperty(ref _UtcOffset, value); }
    public string TimeZone { get => _TimeZone; set => SetProperty(ref _TimeZone, value); }
    public string JsonUntouched { get => _JsonUntouched; set => SetProperty(ref _JsonUntouched, value); }

    public async Task GetServerTime()
    {
        var httpClient = new HttpClient();
        HttpResponseMessage response = await httpClient.GetAsync(Url);
        var json = await response.Content.ReadAsStringAsync();

        TimeModel timeData = JsonConvert.DeserializeObject<TimeModel>(json);

        CurrentTime = timeData.CurrentDateTime;
        UtcOffset = timeData.UtcOffset;
        TimeZone = timeData.TimeZoneName;
        JsonUntouched = json;
    }
}
