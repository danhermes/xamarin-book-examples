using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NavigationExamplesiOS
{
	partial class DetailPage : UIViewController
	{
		private ListItem item;

		public DetailPage(ListItem itemPassed)
		{
			item = itemPassed;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Title = item.Title;
		}

	}
}
