using System;
using System.Collections.Generic;

using Foundation;
using UIKit;


namespace iOSListExample
{
	public partial class ListModelGroupedViewController : UIViewController
	{
		public ListModelGroupedViewController () //: base ("ListModelGroupedViewController", null)
		{
		}

		List<Group> itemsGrouped;

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			UITableView table = new UITableView(View.Bounds, UITableViewStyle.Grouped);
			itemsGrouped = new List<Group> { 
				new Group ("Important", new List<ListItem> {
					new ListItem {Title = "First", Description="1st item"}, 
					new ListItem {Title = "Second", Description="2nd item"},
				}), 

				new Group ("Less Important", new List<ListItem>{
					new ListItem {Title = "Third", Description="3rd item"} 
				})
			};
			table.Source = new ListSourceFromModelGrouped(itemsGrouped);
			Add (table); 
		} 

	}
}

