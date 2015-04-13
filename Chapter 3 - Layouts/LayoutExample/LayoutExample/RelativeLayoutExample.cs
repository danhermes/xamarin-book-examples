using System;
using Xamarin.Forms;

namespace LayoutExample
{
public class RelativeLayoutExample  : ContentPage
	{
		public RelativeLayoutExample ()
		{
			RelativeLayout relativeLayout = new RelativeLayout();

			Label upperLeft = new Label
			{
				Text = "Upper Left",
                FontSize = 20    
			};

			relativeLayout.Children.Add (upperLeft,
				Constraint.Constant (0),
				Constraint.Constant (0));

            Label below = new Label
            {
                Text = "Below Upper Left",
                FontSize = 15
            };

            relativeLayout.Children.Add(below,
                Constraint.Constant(0),
                Constraint.RelativeToView(upperLeft, (parent, sibling) =>
                                    {
                                        return sibling.Y + sibling.Height;
                                    })
                );
				

			Label constantLabel = new Label
			{
				Text = "Constants are Absolute",
				FontSize = 20
			};

					relativeLayout.Children.Add (constantLabel,
						Constraint.Constant (100),
						Constraint.Constant (100),
						Constraint.Constant (50),
						Constraint.Constant (200));

			Label halfwayDown = new Label
			{
				Text = "Halfway down and across",
                FontSize = 15
			};

			relativeLayout.Children.Add (halfwayDown ,
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Width / 2;
					}),
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Height / 2;
					})
			); 


			BoxView boxView = new BoxView {
				Color = Color.Accent,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.StartAndExpand
			};

			relativeLayout.Children.Add (boxView,
				Constraint.Constant (0),
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Height / 2;
					}), 
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Width / 2;
					}), 
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Height / 2;
					})
			);


			Content = relativeLayout;
		}
	}
}

