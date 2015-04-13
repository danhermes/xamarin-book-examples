using System;

using Xamarin.Forms;
using LayoutExample.Xaml.Views;

namespace LayoutExample.Xaml
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new Choices());
            // The root page of your application
            //MainPage = new GridExample1();
            //MainPage = new GridExample2();
            //MainPage = new GridExample3();
            //MainPage = new StackLayoutExample();
            //MainPage = new StackLayoutExample2();
            //MainPage = new FrameExample();
            //MainPage = new ContentViewExample();
            //MainPage = new AbsoluteLayoutExample();
            //MainPage = new RelativeLayoutExample();
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

