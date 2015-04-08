using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class GlobalPage2 : ContentPage
	{
		public string Data { get; set; }

		public GlobalPage2 ()
		{
			InitializeComponent ();

			Data = Global.Instance.myData.ToString();

			this.BindingContext = this;
		}
	}
}

