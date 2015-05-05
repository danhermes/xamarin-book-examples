using System;
using Xamarin.Forms;

// StackLayout Vertical example

namespace LayoutExample
{
	public class StackLayoutVertical : ContentPage
	{
        public StackLayoutVertical ()
		{
			StackLayout stackLayout = new StackLayout {
				Spacing = 0,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					new Label {
						Text = "Start is flush left",
						HorizontalOptions = LayoutOptions.Start,
					},
					new Label {
						Text = "Start 2",
						HorizontalOptions = LayoutOptions.Start,
					},
					new Label {
						Text = "Center",
						HorizontalOptions = LayoutOptions.Center
					},
					new Label {
						Text = "Center2",
						HorizontalOptions = LayoutOptions.Center
					},
					new Label {
						Text = "End1",
						HorizontalOptions = LayoutOptions.End
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
						Text = "Start 1 ---"
					},
					new Label {
						Text = "Start 2 ---"
					},
					new Label {
						Text = "---Center 1 ---",
						HorizontalOptions = LayoutOptions.CenterAndExpand
					},
					new Label {
						Text = "---Center 2 ---",
						HorizontalOptions = LayoutOptions.CenterAndExpand
					},
					new Label {
						Text = "---End 1 "
					},
					new Label {
						Text = "---End 2 "
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



