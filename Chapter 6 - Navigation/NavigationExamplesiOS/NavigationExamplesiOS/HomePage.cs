using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

// Chapter 5 - iOS UITableView Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace iOSListExample
{
	public partial class HomePage : UIViewController
	{
		protected List<ListMenuItem> listItems;

		public HomePage () 
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UITableView table = new UITableView(View.Bounds);
			listItems = new List<ListMenuItem> { 
				new ListMenuItem {Title = "List Bound to an Array", PageType = typeof(ListArrayViewController)}, 
				new ListMenuItem {Title = "List Bound to a Data Model", PageType = typeof(ListModelViewController)},
				new ListMenuItem {Title = "Custom List", PageType =typeof(ListCustomViewController)},
				new ListMenuItem {Title = "List with Grouping", PageType = typeof(ListModelGroupedViewController)}
			};

			table.Source = new ListMenuSource(listItems, this);
			Add (table);

			this.Title = "iOS UITableView - Chapter 5";
		}
	}
}

