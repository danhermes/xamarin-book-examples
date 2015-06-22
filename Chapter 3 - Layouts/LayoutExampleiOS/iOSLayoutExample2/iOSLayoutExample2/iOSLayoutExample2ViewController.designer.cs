// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace iOSLayoutExample2
{
	[Register ("iOSLayoutExample2ViewController")]
	partial class iOSLayoutExample2ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider slider { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (slider != null) {
				slider.Dispose ();
				slider = null;
			}
		}
	}
}
