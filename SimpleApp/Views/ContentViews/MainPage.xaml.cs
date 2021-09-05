using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp.Views.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentView
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Used to call from the flyoutPg.cs go chk
        public event EventHandler ToggleMenu;

        private void OnMenuTapped(object sender, EventArgs e) => ToggleMenu?.Invoke(sender, e);
    }
}