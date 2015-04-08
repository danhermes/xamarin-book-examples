using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();
		}

		protected async void Navigate(object sender, EventArgs args) {
			await Navigation.PushAsync(new ThirdPage());
		}
	}
}

