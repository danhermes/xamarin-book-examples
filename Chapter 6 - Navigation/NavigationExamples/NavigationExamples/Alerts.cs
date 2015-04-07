using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class Alerts : ContentPage
    {
        public Alerts()
        {
            Title = "Alerts Using DisplayAlert";

            Button button = new Button { Text = "Show Alert" }; 
            button.Clicked += async (sender, e) =>
            {
                await DisplayAlert("Hey", "You really should know about this.", "OK");
                //Boolean answer = await DisplayAlert("Start", "Are you ready to begin?", "Yes", "No");
            };

            StackLayout stackLayout = new StackLayout
            {
                Children = { button }

            };

            this.Content = stackLayout;

        }
    }
}
