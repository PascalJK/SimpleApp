using SimpleApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePg : ContentPage
    {
        private readonly TimePgVM vm = new();
        public TimePg()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            await vm.GetServerTime();
        }
    }
}