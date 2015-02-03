using System;
using Xamarin.Forms;

namespace LayoutExample
{
	public class AbsoluteLayoutExample : ContentPage
	{
		public AbsoluteLayoutExample ()
		{
			Label firstLabel;
			Label secondLabel;

			AbsoluteLayout absoluteLayout = new AbsoluteLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			firstLabel = new Label 
			{ 
				Text = "FirstLabel"
			};

			absoluteLayout.Children.Add(firstLabel);
			AbsoluteLayout.SetLayoutFlags(firstLabel,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(firstLabel,
				new Rectangle(0, 0,
					AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			// OR

			//absoluteLayout.Children.Add (FirstLabel, new Point(1,0));
			//AbsoluteLayout.SetLayoutFlags(FirstLabel,
			//	AbsoluteLayoutFlags.PositionProportional);


			//  OR 

			//absoluteLayout.Children.Add (FirstLabel, new Rectangle (0, 0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize), AbsoluteLayoutFlags.PositionProportional);

			secondLabel = new Label 
			{ 
				Text = "SecondLabel"
			};
			absoluteLayout.Children.Add(secondLabel);
			AbsoluteLayout.SetLayoutFlags(secondLabel,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(secondLabel,
				new Rectangle(0, 1,
					AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			this.Content = absoluteLayout;
		}
	}
}

