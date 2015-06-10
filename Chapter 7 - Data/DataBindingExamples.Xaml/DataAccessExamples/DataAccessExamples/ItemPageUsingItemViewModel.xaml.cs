using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingExamples
{
	public partial class ItemPageUsingItemViewModel : ContentPage
	{
		ItemViewModel itemViewModel;

		public ItemPageUsingItemViewModel ()
		{
			InitializeComponent ();

			itemViewModel = new ItemViewModel();
			itemViewModel.Title = "First";
			this.BindingContext = itemViewModel;
		}

		public async void DisplayButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert("Item Object", "Title property:" + itemViewModel.Title.ToString(), "OK");
		}

		public async void UpdateButtonClicked(object sender, EventArgs args)
		{
			itemViewModel.Title = "Updating the data model!";
			await DisplayAlert("Item Object", "Title property:" + itemViewModel.Title.ToString(), "OK");
		}
	}
}

