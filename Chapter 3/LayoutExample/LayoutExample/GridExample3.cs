using System;
using Xamarin.Forms;

namespace LayoutExample
{
	public class GridExample3 : ContentPage
	{
		public GridExample3 ()
		{
			Grid grid = new Grid
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions = 
				{
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = new GridLength(200, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = GridLength.Auto }
				},
				ColumnDefinitions = 
				{
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = GridLength.Auto }
				}
			};

			grid.Children.Add(new Label
				{
					Text = "I'm at 0,0",
                    FontSize = 30,
                    FontAttributes = FontAttributes.Bold
				}, 0, 0);

			grid.Children.Add(new Label
				{
					Text = "Me? 1, 1",
					FontSize = 30,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.Black,
					BackgroundColor = Color.Lime
				}, 1, 3, 1, 2);

			grid.Children.Add(new Label
				{
					Text = "2, 2 here",
					FontSize = 25,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.White,
					BackgroundColor = Color.Red
				}, 2, 3, 2, 4);

			grid.Children.Add(new Label
				{
					Text = "I'm at 0,3",
					FontSize = 30,
                    FontAttributes = FontAttributes.Bold,
				}, 0, 3);


			// Padding on edges and a bit more for iPhone top status bar
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			this.Content = grid;
		}
	}
}

