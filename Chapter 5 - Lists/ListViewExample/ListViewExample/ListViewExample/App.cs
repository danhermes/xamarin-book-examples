using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

// Chapter 5 - Xamarin.Forms ListView Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace ListViewExample
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new HomePage());
        }
    }
}
