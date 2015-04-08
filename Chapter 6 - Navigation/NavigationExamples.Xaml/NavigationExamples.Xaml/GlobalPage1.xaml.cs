using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class GlobalPage1 : ContentPage
	{
		public GlobalPage1 ()
		{
			InitializeComponent ();

			Global.Instance.myData = "12345";
		}

		protected async void Navigate(object sender, EventArgs args) {
			await Navigation.PushAsync(new GlobalPage2()); 
		}
	}
}

