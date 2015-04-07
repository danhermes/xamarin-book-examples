using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class GlobalPage2 : ContentPage
    {
        public GlobalPage2()  
        {
            Title = "Second Global Page";

            var myData = Global.Instance.myData;

            Label label = new Label
            {
                Text = "Persisted id: " + myData.ToString(),
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
