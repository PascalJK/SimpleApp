using SimpleApp.ViewModels.Base;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace SimpleApp.ViewModels
{
    public class MainPgVM : BaseVM
    {
        public ObservableRangeCollection<MainPgModel> MenuTabsColl { get; set; } = new();
        public ICommand LoadPageCmd => new AsyncCommand<MainPgModel>(LoadPage);

        public MainPgVM()
        {
            MenuTabsColl = new()
            {
                new MainPgModel { PageName = "TimePg", PageTitle = "Time Api Page" },
                new MainPgModel { PageName = "CountriesPg", PageTitle = "Countries Page" },
                new MainPgModel { PageName = "CurrencyPg", PageTitle = "Currency Api Page" },
                new MainPgModel { PageName = "Page1", PageTitle = "Page_1" },
                new MainPgModel { PageName = "Page2", PageTitle = "Page_2" },
            };
        }

        private async Task LoadPage(MainPgModel arg)
        {
            object obj = arg.PageName;
            var pageType = Type.GetType($"SimpleApp.Views.{obj}");
            var page = Activator.CreateInstance(pageType) as Page;
            await PushNavigationPage(page);
        }
    }


    public class MainPgModel
    {
        public string PageTitle { get; set; }
        public string PageName { get; set; }
    }
}
