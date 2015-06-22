using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DatePickerExample
{
	public partial class DatePickerExampleViewController : UIViewController
	{
		public DatePickerExampleViewController (IntPtr handle) : base (handle)
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

			UIDatePicker datePicker = new UIDatePicker ();
			datePicker.Mode = UIDatePickerMode.Date;
			datePicker.BackgroundColor = UIColor.White;

			datePicker.MinimumDate = DateTime.Today.AddDays(-7);
			datePicker.MaximumDate = DateTime.Today.AddDays(7);

			UIToolbar toolbar = new UIToolbar();
			toolbar.BarStyle = UIBarStyle.Default;
			toolbar.Translucent = true;
			toolbar.SizeToFit();

			UIBarButtonItem doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done,
				(s, e) => {
					DateTime dateTime = DateTime.SpecifyKind(datePicker.Date, DateTimeKind.Unspecified);
					this.textField.Text = dateTime.ToString("MM-dd-yyyy");
					this.textField.ResignFirstResponder();
				});
			toolbar.SetItems(new UIBarButtonItem[]{doneButton}, true);

			this.textField.InputAccessoryView = toolbar;
			
			textField.InputView = datePicker;
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

