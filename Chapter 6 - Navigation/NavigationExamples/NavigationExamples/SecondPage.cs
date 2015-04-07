using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class SecondPage : ContentPage
    {
        Button secondButton;
        public SecondPage()  
        {
            Title = "Second Page";

            Label homeLabel = new Label
            {
                Text = "Second Page",
                FontSize = 40
            };

            secondButton = new Button
            {
                Text = "Go to Third Page"
            };

            secondButton.Clicked += async (sendernav, args) =>
                await Navigation.PushAsync(new ThirdPage());

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, secondButton }

            };

            this.Content = stackLayout;
        }

    }
}
