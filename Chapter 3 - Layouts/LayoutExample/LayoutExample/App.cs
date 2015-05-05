using System;
using Xamarin.Forms;

namespace LayoutExample
{
	public class App : Application
	{
		public App()
		{
			MainPage = new NavigationPage(new HomePage());
		}
	}
}

