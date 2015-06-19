using System;
using System.Collections.Generic;

using Foundation;
using UIKit;


namespace iOSListExample
{
	public partial class ListModelViewControllerCellReuse : UIViewController
	{
		public ListModelViewControllerCellReuse () //: base ("ListModelViewController", null)
		{
		}

		List<ListItem> listItems;
		public static NSString CellId = new NSString ("CellId");

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			UITableView table = new UITableView(View.Bounds);
			listItems = new List<ListItem> { 
				new ListItem {Title = "First", Description="1st item"}, 
				new ListItem {Title = "Second", Description="2nd item"},
				new ListItem {Title = "Third", Description="3rd item"} 
			};
			table.RegisterClassForCellReuse (typeof(CustomCell), CellId);
			table.Source = new ListSourceFromModelCellReuse(listItems);
			Add (table); 
		} 

	}
}

