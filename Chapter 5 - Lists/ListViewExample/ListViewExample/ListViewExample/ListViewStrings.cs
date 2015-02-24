using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewExample
{
    class ListViewStrings : ContentPage // Binding to a List of Strings
	{
		public ListViewStrings()
		{
			var items = new List<String>() {"First","Second","Third"};
			var listView = new ListView();
			listView.ItemsSource = items;

            listView.ItemTapped += async (sender, e) =>
            {
                await DisplayAlert("Tapped", e.Item.ToString() + " was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            //// ItemSelected is an alternative to ItemTapped
            //listView.ItemSelected += async (sender, e) =>
            //{
            //    if (e.SelectedItem == null) return; 
            //    await DisplayAlert("Selected", e.SelectedItem.ToString() + " was selected.", "OK");
            //    ((ListView)sender).SelectedItem = null;
            //};

			this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

			this.Content = listView;
		}
	} 

}

