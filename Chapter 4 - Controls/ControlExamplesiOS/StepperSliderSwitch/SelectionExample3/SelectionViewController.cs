using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SelectionExample3
{
	public partial class SelectionExample3ViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public SelectionExample3ViewController (IntPtr handle) : base (handle)
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

			slider.MinValue = -1;
			slider.MaxValue = 2;
			slider.Value = 0.5f;
			slider.SetThumbImage(UIImage.FromBundle("thumb.png"),UIControlState.Normal);
			slider.ThumbTintColor = UIColor.Brown;
			slider.MinimumTrackTintColor = UIColor.LightGray;
			slider.MaximumTrackTintColor = UIColor.Green;
			slider.ValueChanged += (sender, e) => sliderLabel.Text = ((UISlider)sender).Value.ToString ();

			stepper.MinimumValue = 0;
			stepper.MaximumValue = 11;
			stepper.StepValue = 2;
			stepper.ValueChanged += (object sender, EventArgs e) => stepperLabel.Text = stepper.Value.ToString ();

			thisSwitch.On = false;
			thisSwitch.TintColor = UIColor.Blue;
			thisSwitch.OnTintColor = UIColor.Black;
			bool state = thisSwitch.On;
			thisSwitch.ValueChanged += (sender, e) => switchLabel.Text = thisSwitch.On.ToString();

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

