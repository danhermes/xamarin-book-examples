using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace iOSListExample
{
	public class ListSourceFromCustomCell : UITableViewSource
	{

		protected List<ListItem> listItems;
		protected string CellId= "TableCell";

        public ListSourceFromCustomCell(List<ListItem> items)
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

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) 
        {
            var cell = tableView.DequeueReusableCell(CellId) as CustomCell;
            if (cell == null)
                cell = new CustomCell((NSString)CellId);
            cell.UpdateCell(listItems[indexPath.Row].Title
                , listItems[indexPath.Row].Description);
            return cell;
        }

	}

}

