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
	[Register ("PageOne")]
	partial class PageOne
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonAlert { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonDrilldownList { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonGoToTwo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonModal { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonPassConstructorParam { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonPassProperty { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonPopup { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonSegue { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonTabs { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelFirst { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		PageOneView PageOneView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (buttonAlert != null) {
				buttonAlert.Dispose ();
				buttonAlert = null;
			}
			if (buttonDrilldownList != null) {
				buttonDrilldownList.Dispose ();
				buttonDrilldownList = null;
			}
			if (buttonGoToTwo != null) {
				buttonGoToTwo.Dispose ();
				buttonGoToTwo = null;
			}
			if (buttonModal != null) {
				buttonModal.Dispose ();
				buttonModal = null;
			}
			if (buttonPassConstructorParam != null) {
				buttonPassConstructorParam.Dispose ();
				buttonPassConstructorParam = null;
			}
			if (buttonPassProperty != null) {
				buttonPassProperty.Dispose ();
				buttonPassProperty = null;
			}
			if (buttonPopup != null) {
				buttonPopup.Dispose ();
				buttonPopup = null;
			}
			if (buttonSegue != null) {
				buttonSegue.Dispose ();
				buttonSegue = null;
			}
			if (buttonTabs != null) {
				buttonTabs.Dispose ();
				buttonTabs = null;
			}
			if (labelFirst != null) {
				labelFirst.Dispose ();
				labelFirst = null;
			}
			if (PageOneView != null) {
				PageOneView.Dispose ();
				PageOneView = null;
			}
		}
	}
}
