using System;

using Xamarin.Forms;
using LayoutExample.Xaml.Views;

namespace LayoutExample.Xaml
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

