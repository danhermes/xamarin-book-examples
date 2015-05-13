using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CustomRenderer
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            CustomButton button = new CustomButton
            {
                Text = "Custom Button",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            button.Clicked += (sender, args) =>
            {
                DisplayAlert("Congratulations", "This button was rendered in a platform-specific class.", "OK");
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    button
				}
            };

        }
    }
}
