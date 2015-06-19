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
	[Register ("DetailPageProperty")]
	partial class DetailPageProperty
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView DetailPagePropertyView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel LabelDescription { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel LabelTitle { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (DetailPagePropertyView != null) {
				DetailPagePropertyView.Dispose ();
				DetailPagePropertyView = null;
			}
			if (LabelDescription != null) {
				LabelDescription.Dispose ();
				LabelDescription = null;
			}
			if (LabelTitle != null) {
				LabelTitle.Dispose ();
				LabelTitle = null;
			}
		}
	}
}
