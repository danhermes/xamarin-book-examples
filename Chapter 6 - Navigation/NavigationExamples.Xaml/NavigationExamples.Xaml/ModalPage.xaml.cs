using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class ModalPage : ContentPage
	{
		public ModalPage ()
		{
			InitializeComponent ();
		}

		protected async void Navigate(object sender, EventArgs args) {
			await Navigation.PushModalAsync(new ModalSecondPage(), false);
		}
	}
}

