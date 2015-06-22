using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOSLayoutExamples
{
	public partial class iOSLayoutExamplesViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public iOSLayoutExamplesViewController (IntPtr handle) : base (handle)
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

			var textView = new UITextField
			{
				Placeholder = "Your name",
				BorderStyle = UITextBorderStyle.RoundedRect,
				Frame = new RectangleF(10, 10, 200, 50)
			};

			//textView .AddConstraints (new[] {

				//size
			//	NSLayoutConstraint.Create (textView , NSLayoutAttribute.Height, NSLayoutRelation.Equal, null, NSLayoutAttribute.NoAttribute, 1, 14),
			//	NSLayoutConstraint.Create (textView , NSLayoutAttribute.Width, NSLayoutRelation.Equal, null, NSLayoutAttribute.NoAttribute, 1, 80),

				//location
			//	NSLayoutConstraint.Create (textView , NSLayoutAttribute.Left, NSLayoutRelation.Equal, mainView, NSLayoutAttribute.Left, 1, 10),
			//	NSLayoutConstraint.Create (textView , NSLayoutAttribute.Top, NSLayoutRelation.Equal, mainView, NSLayoutAttribute.Top, 1, 10),
			///
			//});

			this.View.AddSubview(textView);
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

