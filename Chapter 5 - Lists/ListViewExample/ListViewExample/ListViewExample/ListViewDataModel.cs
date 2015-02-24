using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewExample
{
    class ListViewDataModel : ContentPage
    {
        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public ListViewDataModel()
        {
            var listView = new ListView();
            listView.ItemsSource = new ListItem[] { 
				new ListItem {Title = "First", Description="1st item"}, 
				new ListItem {Title = "Second", Description="2nd item"},
				new ListItem {Title = "Third", Description="3rd item"} 
			};
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");

			this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            Content = listView;

            listView.ItemTapped += async (sender, e) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

        }
    }

}
