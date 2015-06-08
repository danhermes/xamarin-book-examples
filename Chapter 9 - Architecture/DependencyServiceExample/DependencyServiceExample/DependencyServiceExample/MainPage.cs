using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DependencyServiceExample
{
    class MainPage : ContentPage
    {

        public MainPage()
        {
            var button = new Button
            {
                Text = "Go Native!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            button.Clicked += (sender, e) =>
            {
                var text = DependencyService.Get<ICustomClass>().GoNative("platform-specific implementation complete!");
                DisplayAlert("GoNative Called", text, "OK");
            };
            Content = button;

        }

    }
}
