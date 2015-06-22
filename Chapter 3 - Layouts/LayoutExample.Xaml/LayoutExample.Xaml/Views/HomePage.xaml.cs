using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutExample.Xaml.Views
{
	public partial class HomePage : ContentPage
	{

		public HomePage ()
		{
			InitializeComponent ();
		}

		protected async void navigateToPage(object sender, EventArgs args) {
            string type = (string) ((TextCell)sender).CommandParameter;
            Type pageType = Type.GetType("LayoutExample.Xaml.Views." + type);
            Page page = (Page)Activator.CreateInstance(pageType);
            await this.Navigation.PushAsync(page);
		}
	}
}
