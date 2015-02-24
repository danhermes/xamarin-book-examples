using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace ListViewExample
{
    class ListViewContextAction : ContentPage // Customizing List Rows
    {
        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public ListViewContextAction()
        {
            var listView = new ListView();
            listView.ItemsSource = new ListItem[] { 
				new ListItem {Title = "First", Description="1st item", Price="$100.00"}, 
				new ListItem {Title = "Second", Description="2nd item", Price="$200.00"},
				new ListItem {Title = "Third", Description="3rd item", Price="$300.00"}
			};
            listView.RowHeight = 80;
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
					FontSize = 12,
					TextColor = Color.White
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

                var moreAction = new MenuItem { Text = "More" };
                moreAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
                moreAction.Clicked += (sender, e) =>
                {
                    var mi = ((MenuItem)sender);
                    var item = (ListItem)mi.CommandParameter;
                    Debug.WriteLine("More clicked on row: " + item.Title.ToString());
                    //((ContentPage)((ListView)viewLayout.ParentView).ParentView).DisplayAlert("More Clicked", "On row: " + item.Title.ToString(), "OK");             
                };
                var deleteAction = new MenuItem { Text = "Delete", IsDestructive = true }; 
                deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
                deleteAction.Clicked += (sender, e) =>
                {
                    var mi = ((MenuItem)sender);
                    var item = (ListItem)mi.CommandParameter;
                    Debug.WriteLine("Delete clicked on row: " + item.Title.ToString());
                    //((ContentPage)((ListView)viewLayout.ParentView).ParentView).DisplayAlert("Delete Clicked", "On row: " + item.Title.ToString(), "OK");
                };
                ContextActions.Add(moreAction);
                ContextActions.Add(deleteAction);
            }

        }

    }

}

