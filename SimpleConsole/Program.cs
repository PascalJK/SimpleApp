/*using SimpleApp.Helper;
using SimpleApp.Models;

var httpClient = new HttpClient();
//HttpResponseMessage response = await httpClient.GetAsync(ApiUrls._recentEpisodesUrl);
HttpResponseMessage response = await httpClient.GetAsync(ApiUrls.GetAnimeInfoById("48997"));
var json = await response.Content.ReadAsStringAsync();

*//*IEnumerable<Root> countriesList = JsonConvert.DeserializeObject<IEnumerable<Root>>(json);
foreach (var item in countriesList)
{

}*//*
Root animeInfo = ApiUrls.DeserializeRootJson(json);
Console.WriteLine(animeInfo.Data.Title);
Console.ReadKey();*/
