using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class ThirdPage : ContentPage
    {
       
        public ThirdPage()  
        {
            Title = "Third Page";

            Label homeLabel = new Label
            {
                Text = "Third Page",
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
