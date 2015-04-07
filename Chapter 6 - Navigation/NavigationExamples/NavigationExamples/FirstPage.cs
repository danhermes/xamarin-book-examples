using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class FirstPage : ContentPage
    {
        Button firstButton;
        public FirstPage()  
        {
            Title = "First Page";

            Label homeLabel = new Label
            {
                Text = "First Page",
                FontSize = 40
            };

            firstButton = new Button
            {
                Text = "Go to Second Page"
            };

            firstButton.Clicked += async (sendernav, args) =>
                await Navigation.PushAsync(new SecondPage());

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, firstButton }

            };

            this.Content = stackLayout;

            Application.Current.Properties["id"] = 12345;
        }

    }
}
