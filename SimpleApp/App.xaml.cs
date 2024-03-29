﻿using SimpleApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Svg;

namespace SimpleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SvgImageSource.RegisterAssembly();
            MainPage = new NavigationPage(new FlyoutPg());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
