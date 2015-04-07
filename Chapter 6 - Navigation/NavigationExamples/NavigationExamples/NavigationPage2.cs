using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class NavigationPage2 : ContentPage
    {
        public NavigationPage2()  
        {
            Title = "Hierarchical Navigation";
            
            Label homeLabel = new Label
            {
                Text = "Second Page",
                FontSize = 40
            };

            var stackLayout = new StackLayout
            {
                Children = { homeLabel }
            };

            this.Content = stackLayout;
        }

    }
}
