using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace SimpleApp.ViewModels.Base
{
    public class BaseVM : INotifyPropertyChanged
    {
        private bool _IsBusy;
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigation Navigation => Application.Current.MainPage.Navigation;

        public bool IsBusy { get => _IsBusy; set => SetProperty(ref _IsBusy, value); }

        public ICommand ClosePageCmd { get; set; }

        public BaseVM()
        {
            ClosePageCmd = new AsyncCommand(PopNavigationPage, allowsMultipleExecutions: false);
        }

        public async Task DisplayAlert(string title, string message, string cancel = "OK") => await Application.Current.MainPage.DisplayAlert(title, message, cancel);

        #region Page Func
        public void LoadMainPage(Page page) => Application.Current.MainPage = new NavigationPage(page);
        public async Task PushNavigationPage(Page page) => await Navigation.PushAsync(page);
        public async Task PopNavigationPage() => await Navigation.PopAsync();
        #endregion

        #region PropertyChanged
        public bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value)) return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
