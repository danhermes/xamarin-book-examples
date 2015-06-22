using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingExamples
{
	public partial class ItemPage : ContentPage
	{
		Item item;

		public ItemPage ()
		{
			InitializeComponent ();

			item = new Item { Title = "First", Description = "1st item" };

			this.BindingContext = item;
		}

		public async void ButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert("Item Object", "Title property:" +  item.Title.ToString(), "OK");
		}
	}
}

