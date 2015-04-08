using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class DrilldownListViewByItem : ContentPage
	{
		public DrilldownListViewByItem ()
		{
			InitializeComponent ();

			itemList.ItemsSource = new ListItem [] { 
				new ListItem {Title = "First", Description="1st item"}, 
				new ListItem {Title = "Second", Description="2nd item"},
				new ListItem {Title = "Third", Description="3rd item"} 
			};
		}

		protected async void ItemTapped(object sender, ItemTappedEventArgs args) {
			var item = args.Item as ListItem;
			if (item == null) return;
			await Navigation.PushAsync(new DetailPage(item));
			itemList.SelectedItem = null;
		}
	}
}

