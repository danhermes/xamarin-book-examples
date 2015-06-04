using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewExample
{
    class ListViewPerformance : ContentPage 
    {
        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public ListViewPerformance()
        {
            var listView = new ListView();
            var listItemSource = new ListItem[] { // lots of rows for performance testing (yes, they repeat...deal with it :) )
				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
                new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
                new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
                new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"} ,
                new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
                new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
                new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
                new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"}, 
  				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"},
   				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$200.00"} 
			};

            listView.ItemsSource = listItemSource;
            listView.RowHeight = 80;
			listView.BackgroundColor = Color.Black;
            listView.ItemTemplate = new DataTemplate(typeof(ListItemCell));

            ListItem goItem = listItemSource[25];
            listView.ScrollTo(goItem, ScrollToPosition.End, true);

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
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    FontSize = 25,
                    FontAttributes = Xamarin.Forms.FontAttributes.Bold,
                    TextColor = Color.White
                };
                titleLabel.SetBinding(Label.TextProperty, "Title");

                Label descLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    FontSize = 12
                };
                descLabel.SetBinding(Label.TextProperty, "Description");


                StackLayout viewLayoutItem = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Orientation = StackOrientation.Vertical,
                    Children = { titleLabel, descLabel }
                };

                Label priceLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.End,
                    FontSize = 25,
                    TextColor = Color.Aqua
                };
                priceLabel.SetBinding(Label.TextProperty, "Price");

                StackLayout viewLayout = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Orientation = StackOrientation.Horizontal,
                    Padding = new Thickness(25, 10, 55, 15),
                    Children = { viewLayoutItem, priceLabel }
                };

                View = viewLayout;
            }

        }

    }

}

