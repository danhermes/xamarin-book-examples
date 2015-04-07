using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class DetailPage : ContentPage
    {

        public DetailPage(ListItem item)
		{ 
            Label titleLabel = new Label
            {
                Text = item.Title,
                FontSize = 40
            };

            Label descLabel = new Label
            {
                Text = item.Description,
                FontSize = 40
            };

            var stackLayout = new StackLayout
            {
                Children = { titleLabel, descLabel }
            };

            this.Content = stackLayout;

        }
    }
}
