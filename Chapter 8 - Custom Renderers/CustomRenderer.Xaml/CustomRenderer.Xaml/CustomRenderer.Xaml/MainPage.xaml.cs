using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomRenderer
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

		public void ButtonClicked(object sender, EventArgs args) {
			DisplayAlert ("Congratulations", "This button was rendered in a platform-specific class.", "OK");
		}
	}
}

