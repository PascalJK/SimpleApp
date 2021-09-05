using Newtonsoft.Json;
using SimpleApp.Models;
using SimpleApp.ViewModels.Base;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace SimpleApp.ViewModels
{
    public class CountriesVM : BaseVM
    {
        public ObservableRangeCollection<Country> CountriesCollection { get; set; } = new();

        public async Task GetCountries()
        {
            List<Country> countries = new();
            string url = "https://restcountries.eu/rest/v2/all?fields=name;capital;region;flag";

            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();

            IEnumerable<Country> countriesList = JsonConvert.DeserializeObject<IEnumerable<Country>>(json);

            foreach (Country item in countriesList)
            {
                countries.Add(item);
            }

            System.Console.WriteLine($"===================={ countries.Count }============================");

            CountriesCollection.ReplaceRange(countries);
        }
    }
}
