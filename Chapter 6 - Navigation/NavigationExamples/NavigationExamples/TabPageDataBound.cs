using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class TabPageDatabound : TabbedPage
    {
        public TabPageDatabound()
        {
            this.Title = "Data-bound TabbedPage";

            this.ItemsSource = new TabItem[] {
                new TabItem ("First", 1),
                new TabItem ("Second", 2),
                new TabItem ("Third", 3),
                new TabItem ("Fourth", 4),
                new TabItem ("Fifth", 5),
                new TabItem ("Sixth", 6)
            };

            this.ItemTemplate = new DataTemplate(() =>
            {
                return new NumberPage();
            });
        }
    }

    class TabItem
    {
        public TabItem(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name { private set; get; }
        public int Number { private set; get; }

    }

    class NumberPage : ContentPage
    {
        public NumberPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Name");
            Label label = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 40
            };
            label.SetBinding(Label.TextProperty, "Number");

            this.Content = label;
        }
    }
}
