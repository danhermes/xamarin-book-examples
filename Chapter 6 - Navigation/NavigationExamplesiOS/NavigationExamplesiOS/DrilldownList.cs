using System;
using System.Collections.Generic;

using Foundation;
using UIKit;


namespace NavigationExamplesiOS
{
	public partial class DrilldownList : UITableViewController
	{

		List<ListItem> listItems;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			UITableView table = new UITableView(View.Bounds);
			listItems = new List<ListItem> { 
				new ListItem {Title = "First", Description="1st item"}, 
				new ListItem {Title = "Second", Description="2nd item"},
				new ListItem {Title = "Third", Description="3rd item"} 
			};

			table.Source = new DrilldownListSource(listItems, this);
			Add (table); 
		} 

	}
}

