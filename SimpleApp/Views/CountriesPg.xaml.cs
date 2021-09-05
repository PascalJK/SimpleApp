using SimpleApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountriesPg : ContentPage
    {
        private readonly CountriesVM vm = new();
        public CountriesPg()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            if (vm.CountriesCollection.Count <= 0)
                await vm.GetCountries();
        }
    }
}