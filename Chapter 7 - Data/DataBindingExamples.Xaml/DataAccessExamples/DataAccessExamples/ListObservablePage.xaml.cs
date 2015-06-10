using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace DataBindingExamples
{
	public partial class ListObservablePage : ContentPage
	{
		ObservableCollection<Item> items;

		public ListObservablePage ()
		{
			InitializeComponent ();

			items = new ObservableCollection<Item> { 
				new Item {Title = "First", Description="1st item"}, 
				new Item {Title = "Second", Description="2nd item"},
				new Item {Title = "Third", Description="3rd item"} 
			};

			this.BindingContext = items;

		}

		public async void DeleteClicked(object sender, EventArgs e) {
			items.RemoveAt(0);
			await DisplayAlert("Item Object", "Row deleted", "OK");
		}

		public async void ListItemTapped(object sender, ItemTappedEventArgs e)
		{
			Item item = (Item)e.Item;
			await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
			((ListView)sender).SelectedItem = null;
		}

	}
}

