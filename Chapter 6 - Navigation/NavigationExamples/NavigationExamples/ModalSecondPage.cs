using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class ModalSecondPage : ContentPage
    {
        Button secondButton;
        public ModalSecondPage()  
        {
            Title = "Modal Navigation";

            Label homeLabel = new Label
            {
                Text = "Second Page",
                FontSize = 40
            };

            secondButton = new Button
            {
                Text = "Pop back to First Page"
            };

            secondButton.Clicked += async (sendernav, args) =>
                await Navigation.PopModalAsync(false);

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, secondButton }

            };

            this.Content = stackLayout;
        }

    }
}
