using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingExamples
{
	public partial class ItemPageUsingItemBindable : ContentPage
	{
		ItemBindable itemBindable;

		public ItemPageUsingItemBindable ()
		{
			InitializeComponent ();

			itemBindable = new ItemBindable();
			itemBindable.Title = "First";
			this.BindingContext = itemBindable;
		}

		public async void DisplayButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert("Item Object", "Title property:" + itemBindable.Title.ToString(), "OK");
		}

		public async void UpdateButtonClicked(object sender, EventArgs args)
		{
			itemBindable.Title = "Updating the data model!";
			await DisplayAlert("Item Object", "Title property:" + itemBindable.Title.ToString(), "OK");
		}

	}
}

