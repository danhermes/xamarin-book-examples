using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingExamples
{
	public partial class ListPropertiesPage : ContentPage
	{
		List<ObservableItem> items;

		public ListPropertiesPage ()
		{
			InitializeComponent ();

			items = new List<ObservableItem> { 
				new ObservableItem {Title = "First", Description="1st item"}, 
				new ObservableItem {Title = "Second", Description="2nd item"},
				new ObservableItem {Title = "Third", Description="3rd item"} 
			};

			this.BindingContext = items;

		}

		public async void EditClicked(object sender, EventArgs e) {
			items[0].Title = "First Edited";
			await DisplayAlert("Item Object", "First row edited", "OK");
		}

		public async void ListItemTapped(object sender, ItemTappedEventArgs e)
		{
			ObservableItem item = (ObservableItem)e.Item;
			await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
			((ListView)sender).SelectedItem = null;
		}
	}
}

