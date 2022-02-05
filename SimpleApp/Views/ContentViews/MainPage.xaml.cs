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
            htmlLbl.Text = "Use this Xamarin.Forms plugin to display HTML content into a label https://github.com/matteobortolazzo/HtmlLabelPlugin Look it up. +268 1879 2222";
        }

        // Used to call from the flyoutPg.cs go chk
        public event EventHandler ToggleMenu;

        private void OnMenuTapped(object sender, EventArgs e) => ToggleMenu?.Invoke(sender, e);
    }
}