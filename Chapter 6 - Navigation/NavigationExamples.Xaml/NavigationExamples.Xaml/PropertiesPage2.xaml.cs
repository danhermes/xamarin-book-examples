using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class PropertiesPage2 : ContentPage
	{
		public int Data { get; set; }

		public PropertiesPage2 ()
		{
			InitializeComponent ();

			Data = (int)Application.Current.Properties["id"];

			this.BindingContext = this;
		}

	}
}

