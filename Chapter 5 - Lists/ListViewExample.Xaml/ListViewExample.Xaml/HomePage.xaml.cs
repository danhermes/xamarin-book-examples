using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Windows.Input;

namespace ListViewExample.Xaml
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomePageViewModel(Navigation);
        }
    }


    public class HomePageViewModel : BindableObject
    {

        private readonly INavigation navigation;

        public Command<string> NavigateCommand
        {
            get;
            set;
        }

        public HomePageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            NavigateCommand = new Command<string>(NagivigateRequested);
        }


        async void NagivigateRequested(string pageName)
        {
            var pageType = Type.GetType("ListViewExample.Xaml." + pageName);
            Page page = (Page)Activator.CreateInstance(pageType);
            await navigation.PushAsync(page);
        }
    }
}

