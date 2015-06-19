using System;
using System.Collections.Generic;

using Foundation;
using UIKit;
using iOSListExample;

namespace iOSListExample
{
	public class ListSourceFromModelCellReuse : UITableViewSource
	{

		protected List<ListItem> listItems;

		public ListSourceFromModelCellReuse (List<ListItem> items)
		{
			listItems = items;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView("Row Selected", listItems[indexPath.Row].Title, null, "OK", null).Show();
			tableView.DeselectRow (indexPath, true);  
		}


		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return listItems.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)  // uses CustomCell new Cell Reuse post-iOS 6
		{
			var cell = tableView.DequeueReusableCell (ListModelViewControllerCellReuse.CellId) as CustomCell;
			cell.UpdateCell (listItems [indexPath.Row].Title
				, listItems [indexPath.Row].Description);
			return cell;
		}

	}

}

