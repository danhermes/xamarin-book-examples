using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class PopupMenu : ContentPage
	{
		public PopupMenu ()
		{
			InitializeComponent ();
		}

		protected async void ShowMenu(object sender, EventArgs args) {
			String action = await DisplayActionSheet ("Options", "Cancel", null, "Here", "There", "Everywhere");
			Message.Text = "Action is :" + action;
		}

	}
}

