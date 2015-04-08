using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			InitializeComponent ();
		}

		protected async void Navigate(object sender, EventArgs args) {
			await Navigation.PushAsync(new SecondPage());
		}
	}
}

