using System;
using System.Collections.Generic;

using Foundation;
using UIKit;


namespace iOSListExample
{
	public partial class ListModelGroupedViewController : UIViewController
	{
		public ListModelGroupedViewController () 
		{
		}

		List<Group> itemsGrouped;

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
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

