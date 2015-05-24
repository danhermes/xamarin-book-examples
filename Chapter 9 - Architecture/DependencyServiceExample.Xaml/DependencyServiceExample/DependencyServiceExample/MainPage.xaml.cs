using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DependencyServiceExample
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

		public void ButtonClick(object sender, EventArgs args)
		{
			var text = DependencyService.Get<CustomClass>().GoNative("platform-specific implementation complete!");
			DisplayAlert("GoNative Called", text, "OK");
		}
	}
}

