using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class ModalSecondPage : ContentPage
	{
		public ModalSecondPage ()
		{
			InitializeComponent ();
		}

		protected async void Navigate(object sender, EventArgs args) {
			await Navigation.PopModalAsync();
		}
	}
}

