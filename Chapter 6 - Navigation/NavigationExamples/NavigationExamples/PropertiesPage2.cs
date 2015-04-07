using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class PropertiesPage2 : ContentPage
    {
        public PropertiesPage2()  
        {
            Title = "Second Properties Page";

            var id = (int)Application.Current.Properties["id"];

            Label label = new Label
            {
                Text = "Persisted id: " + id.ToString() ,
                FontSize = 40
            };

            var stackLayout = new StackLayout
            {
                Children = { label }

            };

            this.Content = stackLayout;
        }

    }
}
