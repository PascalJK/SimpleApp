using SimpleApp.ViewModels.Base;
using SimpleApp.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;

namespace SimpleApp.ViewModels
{
    internal class Page1VM : BaseVM
    {
        public ICommand LoadPg2Cmd => new AsyncCommand(LoadPg2, allowsMultipleExecutions: false);
        private async Task LoadPg2() => await PushNavigationPage(new Page2());
    }
}
