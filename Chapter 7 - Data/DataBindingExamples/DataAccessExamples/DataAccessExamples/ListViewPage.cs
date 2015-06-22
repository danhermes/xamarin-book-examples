using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DataBindingExamples
{
    class ListViewPage: ContentPage
    {
        public ListViewPage()
        {
            var listView = new ListView();
            var items = new Item[] { 
				new Item {Title = "First", Description="1st item"}, 
				new Item {Title = "Second", Description="2nd item"},
				new Item {Title = "Third", Description="3rd item"} 
			};
            listView.ItemsSource = items;
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");

            listView.ItemTapped += async (sender, e) =>
            {
                Item item = (Item)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            Content = listView;

        }
    }

}
