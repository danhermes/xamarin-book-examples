using System;
using Xamarin.Forms;

namespace LayoutExample
{
	class ContentViewExample : ContentPage
	{
		public ContentViewExample()
		{
            ContentView contentView = new ContentView
            {
                BackgroundColor = Color.Teal,
                Padding = new Thickness(40),
                HorizontalOptions = LayoutOptions.Fill,
                Content = new Label
                {
                    Text = "a view, such as a label, a layout, or a layout of layouts",
                    FontSize = 20,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.White
                }
            }; 


			// Padding on edges and a bit more for iPhone top status bar
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			this.Content = new StackLayout
			{
				Children = 
				{
					contentView
				}
				};
		}
	}
}




