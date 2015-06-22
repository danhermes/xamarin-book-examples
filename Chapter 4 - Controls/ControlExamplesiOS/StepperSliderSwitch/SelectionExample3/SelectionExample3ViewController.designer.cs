// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace SelectionExample3
{
	[Register ("SelectionExample3ViewController")]
	partial class SelectionExample3ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider slider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel sliderLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIStepper stepper { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel stepperLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel switchLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch thisSwitch { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (slider != null) {
				slider.Dispose ();
				slider = null;
			}
			if (sliderLabel != null) {
				sliderLabel.Dispose ();
				sliderLabel = null;
			}
			if (stepper != null) {
				stepper.Dispose ();
				stepper = null;
			}
			if (stepperLabel != null) {
				stepperLabel.Dispose ();
				stepperLabel = null;
			}
			if (switchLabel != null) {
				switchLabel.Dispose ();
				switchLabel = null;
			}
			if (thisSwitch != null) {
				thisSwitch.Dispose ();
				thisSwitch = null;
			}
		}
	}
}
