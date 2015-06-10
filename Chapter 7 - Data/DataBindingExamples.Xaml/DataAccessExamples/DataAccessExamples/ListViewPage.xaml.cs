using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingExamples
{
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

			var items = new Item[] { 
				new Item {Title = "First", Description="1st item"}, 
				new Item {Title = "Second", Description="2nd item"},
				new Item {Title = "Third", Description="3rd item"} 
			};

			this.BindingContext = items;
		}

		public async void ListItemTapped(object sender, ItemTappedEventArgs e)
		{
			Item item = (Item)e.Item;
			await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
			((ListView)sender).SelectedItem = null;
		}

	}
}

