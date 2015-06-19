// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NavigationExamplesiOS
{
	[Register ("PageTwo")]
	partial class PageTwo
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		PageTwoView PageTwoView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (PageTwoView != null) {
				PageTwoView.Dispose ();
				PageTwoView = null;
			}
		}
	}
}
