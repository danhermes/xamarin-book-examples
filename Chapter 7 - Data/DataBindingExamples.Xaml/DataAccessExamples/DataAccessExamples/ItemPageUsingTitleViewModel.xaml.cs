using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingExamples
{
	public partial class ItemPageUsingTitleViewModel : ContentPage
	{
		TitleViewModel titleViewModel;

		public ItemPageUsingTitleViewModel ()
		{
			InitializeComponent ();

			titleViewModel = new TitleViewModel ();
			titleViewModel.Title = "First";
			this.BindingContext = titleViewModel;
		}

		public async void DisplayButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert("Item Object", "Title property:" + titleViewModel.Title.ToString(), "OK");
		}

		public async void UpdateButtonClicked(object sender, EventArgs args)
		{
			titleViewModel.Title = "Data Model Updated";
			await DisplayAlert("Item Object", "Title property:" + titleViewModel.Title.ToString(), "OK");
		}
	}
}

