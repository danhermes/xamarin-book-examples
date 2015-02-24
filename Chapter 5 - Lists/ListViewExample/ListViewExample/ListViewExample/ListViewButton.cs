using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewExample
{

    // public class ListButton : Button { } // Workaround for Android ListView/Button bug https://forums.xamarin.com/discussion/21913/button-inside-listview

    class ListViewButton : ContentPage // Customizing List Rows
    {
        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public ListViewButton()
        {
            var listView = new ListView();
            listView.ItemsSource = new ListItem[] { 
				new ListItem {Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Title = "Third", Description="3rd item", Price="$300.00"}
			};
            listView.RowHeight = 100;
			listView.BackgroundColor = Color.Black;
            listView.HasUnevenRows = true;
            listView.ItemTemplate = new DataTemplate(typeof(ListItemCell));
            Content = listView;

            listView.ItemTapped += async (sender, e) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

			this.Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

        }

        class ListItemCell : ViewCell
        {
            public ListItemCell()
            {

                Label titleLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.Start,
                    FontSize = 20,
                    FontAttributes = Xamarin.Forms.FontAttributes.Bold,
                    TextColor = Color.White
                };
                titleLabel.SetBinding(Label.TextProperty, "Title");

                Label descLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.Start,
					FontSize = 12,
					TextColor = Color.White
                };
                descLabel.SetBinding(Label.TextProperty, "Description");


                StackLayout viewLayoutItem = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.Start,
                    Orientation = StackOrientation.Vertical,
                    WidthRequest = 120,
                    Children = { titleLabel, descLabel }
                };

                Label priceLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    FontSize = 25,
                    TextColor = Color.Aqua
                };
                priceLabel.SetBinding(Label.TextProperty, "Price");

                var button = new Button //ListButton // Android workaround
                {
                    Text = "Buy Now",
                    BackgroundColor = Color.Teal,
                    HorizontalOptions = LayoutOptions.EndAndExpand
                };
                button.SetBinding(Button.CommandParameterProperty, new Binding("."));
                button.Clicked += (sender, e) =>
                {
                    var b = (Button)sender;
                    var item = (ListItem)b.CommandParameter;
                    ((ContentPage)((ListView)((StackLayout)((StackLayout)b.ParentView).ParentView).ParentView).ParentView).DisplayAlert("Clicked", item.Title.ToString() + " button was clicked", "OK");
                };

                StackLayout viewButton = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    Orientation = StackOrientation.Horizontal,
                    WidthRequest = 260,
                    Children = { priceLabel, button }
                };


                StackLayout viewLayout = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Orientation = StackOrientation.Horizontal,
                    Padding = new Thickness(5, 10, 5, 15),
                    Children = { viewLayoutItem, viewButton }
                };

                View = viewLayout;
            }

        }

    }

}

