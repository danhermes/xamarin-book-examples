using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class NavigationPage1 : ContentPage
    {
        Button homeButton;
        public NavigationPage1()
        {
            Title = "Hierarchical Navigation";

            //NavigationPage.SetHasNavigationBar(this, false);
            Label homeLabel = new Label
            {
                Text = "Home Page",
                FontSize = 40
            };
            
            //NavigationPage.SetBackButtonTitle(this, "We are home");
            homeButton = new Button
            {
                Text = "Go to Second Page"
            };

            homeButton.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new NavigationPage2());

            StackLayout stackLayout = new StackLayout
            {
                Children = { homeLabel, homeButton }

            };

            this.Content = stackLayout;
        }
    }
}
