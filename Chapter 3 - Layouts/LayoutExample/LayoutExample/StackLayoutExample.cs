using System;
using Xamarin.Forms;

namespace LayoutExample
{
	public class StackLayoutExample : ContentPage
	{
		public StackLayoutExample ()
		{
			StackLayout stackLayout = new StackLayout {
				Spacing = 0,
				//VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					new Label {
						Text = "Start is flush left",
						HorizontalOptions = LayoutOptions.Start,
					},
					new Label {
						Text = "Center",
						HorizontalOptions = LayoutOptions.Center
					},
					new Label {
						Text = "End is flush right",
						HorizontalOptions = LayoutOptions.End
					}
				}
				
			};

			StackLayout stackLayoutHorizontal = new StackLayout {
				Spacing = 0,
				Orientation = StackOrientation.Horizontal,
				Children = {
					new Label {
						Text = "Start------"
					},
					new Label {
						Text = "------Center------",
						HorizontalOptions = LayoutOptions.CenterAndExpand
					},
					new Label {
						Text = "------End"
					}
				}
			};

			this.Content = new StackLayout
			{
				Children = 
				{
					stackLayout,
					stackLayoutHorizontal
				}
			};

		}
	}
}



