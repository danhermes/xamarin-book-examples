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
	[Register ("PageModal")]
	partial class PageModal
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		PageModalView PageModalView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (PageModalView != null) {
				PageModalView.Dispose ();
				PageModalView = null;
			}
		}
	}
}
