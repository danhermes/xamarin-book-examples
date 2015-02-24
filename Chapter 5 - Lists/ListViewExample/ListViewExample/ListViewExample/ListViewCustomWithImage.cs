using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewExample
{
    class ListViewCustomWithImage : ContentPage // Customizing List Rows including Image
	{
		public class ListItem {
            public string Source { get; set; }
			public string Title { get; set; }
			public string Description { get; set; }
            public string Price { get; set; }
		}

        public ListViewCustomWithImage()
		{
            var listView = new ListView();
            listView.ItemsSource = new ListItem[] { 
				new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$300.00"}
            };
            listView.RowHeight = 85;
			listView.BackgroundColor = Color.Black;
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
                Image image = new Image
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                };
                image.SetBinding(Image.SourceProperty, "Source");
                
                Label titleLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    FontSize = 15,
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


                Label priceLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    FontSize = 25,
                    TextColor = Color.Aqua
                };
                priceLabel.SetBinding(Label.TextProperty, "Price");

                StackLayout viewLayoutImage = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.Start,
                    Orientation = StackOrientation.Vertical,
                    Padding = 3,
                    Children = { image }
                };

                StackLayout viewLayoutItem = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Orientation = StackOrientation.Vertical,
                    Padding = 15,
                    Children = { titleLabel, descLabel }
                };

                StackLayout viewLayoutPrice = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.End,
                    VerticalOptions = LayoutOptions.Center,
                    Orientation = StackOrientation.Vertical,
                    Padding = 25,
                    Children = { priceLabel }
                };

                StackLayout viewLayout = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Orientation = StackOrientation.Horizontal,
					BackgroundColor = Color.Black,
                    Children = { viewLayoutImage, viewLayoutItem, viewLayoutPrice }
                };

                View = viewLayout;

			}

        }
           
		}

}

