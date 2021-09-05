using Newtonsoft.Json;
using SimpleApp.Helper;
using SimpleApp.ViewModels.Base;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace SimpleApp.ViewModels
{
    public class CurrencyPgVM : BaseVM
    {
        private bool canCalculate;

        private string _Value_1;
        private string _Value_2;
        private string _Result;

        private double _Ans;
        private double _CalcAns;
        private double _Calcul;

        public bool CanCalculate { get => canCalculate; set => SetProperty(ref canCalculate, value); }

        public string Value_1 { get => _Value_1; set => SetProperty(ref _Value_1, value); }
        public string Value_2 { get => _Value_2; set => SetProperty(ref _Value_2, value); }
        public string Result { get => _Result; set => SetProperty(ref _Result, value); }

        public double Calcul { get => _Calcul; set => SetProperty(ref _Calcul, value); }
        public double CalcAns { get => _CalcAns; set => SetProperty(ref _CalcAns, value); }

        public ICommand ConvertCmd => new AsyncCommand(ConvertValueAsync);
        public ICommand CalculateValueCmd => new Command(CalculateValue);

        private async Task ConvertValueAsync()
        {
            try
            {
                var val = $"{Value_1}_{Value_2}";
                ApiErrorConverter.val = val.ToUpper();
                string url = $"currconv.com/api/v7/convert?q={val}&compact=ultra&apiKey=6c1f1e15a4b429df3e73";
                var httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync($"https://free.{url}");
                var json = await response.Content.ReadAsStringAsync();

                CurrencyModel currency = JsonConvert.DeserializeObject<CurrencyModel>(json);
                _Ans = Math.Round(currency.UsdNad, 2);
                Result = $"1 {Value_1} = {currency.UsdNad:0.00} {Value_2}";
                var ans = 1 * _Ans;
                CalcAns = Math.Round(ans, 2);
                CanCalculate = true;
            }
            catch (Exception x)
            {
                CanCalculate = false;
                await DisplayAlert("Error", x.Message);
            }
        }

        private void CalculateValue()
        {
            var ans = Calcul * _Ans;
            CalcAns = Math.Round(ans, 2);
        }
    }

    [JsonConverter(typeof(ApiErrorConverter))]
    public class CurrencyModel
    {
        [JsonProperty("value")]
        public double UsdNad { get; set; }
    }
}
