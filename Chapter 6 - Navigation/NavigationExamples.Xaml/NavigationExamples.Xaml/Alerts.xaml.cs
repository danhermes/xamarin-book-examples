using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class Alerts : ContentPage
	{
		public Alerts ()
		{
			InitializeComponent ();
		}

		protected async void ShowAlert(object sender, EventArgs args) {
			await DisplayAlert("Hey", "You really should know about this.", "OK");
		}
	}
}

