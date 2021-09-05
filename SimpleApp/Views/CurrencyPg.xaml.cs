using SimpleApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrencyPg : ContentPage
    {
        private readonly CurrencyPgVM vm = new();
        public CurrencyPg()
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}