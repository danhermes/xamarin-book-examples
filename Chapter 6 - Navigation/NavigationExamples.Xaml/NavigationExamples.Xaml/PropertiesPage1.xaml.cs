using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class PropertiesPage1 : ContentPage
	{
		public PropertiesPage1 ()
		{
			InitializeComponent ();

			Application.Current.Properties["id"] = 12345;
		}

		protected async void Navigate(object sender, EventArgs args) {
			await Navigation.PushAsync(new PropertiesPage2()); 
		}

	}
}

