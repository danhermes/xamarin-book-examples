using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOSLayoutExample2
{
	public partial class iOSLayoutExample2ViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public iOSLayoutExample2ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

//			var textView = new UITextField
//			{
//				Placeholder = "Your name",
//				BorderStyle = UITextBorderStyle.RoundedRect,
//				Frame = new RectangleF(10, 30, 200, 50)
//			};
//
//			Add (textView);

			var textView  = new UITextField
			{
				Placeholder = "Your name",
				BorderStyle = UITextBorderStyle.RoundedRect
			};

			textView.TranslatesAutoresizingMaskIntoConstraints = false;

			textView .AddConstraints (new[] {

				//size
				NSLayoutConstraint.Create (textView , NSLayoutAttribute.Height, NSLayoutRelation.Equal, null, NSLayoutAttribute.NoAttribute, 1, 50),
				NSLayoutConstraint.Create (textView , NSLayoutAttribute.Width, NSLayoutRelation.Equal, null, NSLayoutAttribute.NoAttribute, 1, 200),
			});

			Add(textView);

			View.AddConstraints (new[] {
				//location
				NSLayoutConstraint.Create (textView, NSLayoutAttribute.Left, NSLayoutRelation.Equal, View, NSLayoutAttribute.Left, 1, 10),
				NSLayoutConstraint.Create (textView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1, 30)
			});
		
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

