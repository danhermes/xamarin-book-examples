using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace iOSListExample
{
	public class CustomCell : UITableViewCell  {

		UILabel titleLabel, descriptionLabel;

		public CustomCell (IntPtr p):base(p) // for the new cell reuse
		{
			SelectionStyle = UITableViewCellSelectionStyle.Blue;
			ContentView.BackgroundColor = UIColor.FromRGB (27, 16, 117);

			titleLabel = new UILabel () 
			{
				Font = UIFont.FromName("Helvetica-Bold", 25f),
				TextColor = UIColor.White,
				BackgroundColor = UIColor.Clear
			};

			descriptionLabel = new UILabel () 
			{
				Font = UIFont.FromName("Helvetica-Light", 12f),
				TextColor = UIColor.FromRGB (179, 179, 186),
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.Clear
			};

			ContentView.AddSubviews (new UIView[] { titleLabel, descriptionLabel });
		}

		public CustomCell (NSString cellId) : base (UITableViewCellStyle.Default, cellId)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Blue;
			ContentView.BackgroundColor = UIColor.FromRGB (27, 16, 117);

			titleLabel = new UILabel () 
			{
				Font = UIFont.FromName("Helvetica-Bold", 25f),
				TextColor = UIColor.White,
				BackgroundColor = UIColor.Clear
			};

			descriptionLabel = new UILabel () 
			{
				Font = UIFont.FromName("Helvetica-Light", 12f),
				TextColor = UIColor.FromRGB (179, 179, 186),
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.Clear
			};

			ContentView.AddSubviews (new UIView[] { titleLabel, descriptionLabel });

		}

		public void UpdateCell (string title, string description)
		{
			titleLabel.Text = title;
			descriptionLabel.Text = description;
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
			titleLabel.Frame = new RectangleF(5, 4, (float)ContentView.Bounds.Width - 63, 25);
			descriptionLabel.Frame = new RectangleF(100, 18, 100, 20);
		}

	}
}

