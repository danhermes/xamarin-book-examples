using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage (ListItem item)
		{
			InitializeComponent ();

			this.BindingContext = item;
		}
	}
}

