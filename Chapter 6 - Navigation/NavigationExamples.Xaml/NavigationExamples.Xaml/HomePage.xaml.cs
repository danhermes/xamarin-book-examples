using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class HomePage : ContentPage
	{

		public HomePage ()
		{
			InitializeComponent ();
		}

		protected async void navigateToPage(object sender, EventArgs args) {
			string type = (string) ((TextCell)sender).CommandParameter;
			Type pageType = Type.GetType("NavigationExamples." + type + ", NavigationExamples");
			Page page = (Page)Activator.CreateInstance(pageType);
			await this.Navigation.PushAsync(page);
		}
	}
}

