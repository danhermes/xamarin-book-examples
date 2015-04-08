using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class NavigationPage1 : ContentPage
	{
		public NavigationPage1 ()
		{
			InitializeComponent ();
		}

		protected async void Navigate(object sender, EventArgs args) {
			await Navigation.PushAsync(new NavigationPage2());
		}
	}
}

