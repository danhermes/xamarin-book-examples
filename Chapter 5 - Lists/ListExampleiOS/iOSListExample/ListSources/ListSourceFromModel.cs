using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace iOSListExample
{
	public class ListSourceFromModel : UITableViewSource
	{

		protected List<ListItem> listItems;
		protected string CellId= "TableCell";

		public ListSourceFromModel (List<ListItem> items)
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
            UITableViewCell cell = tableView.DequeueReusableCell(CellId);
            if (cell == null) cell = new UITableViewCell(UITableViewCellStyle.Default, CellId);
            cell.TextLabel.Text = listItems[indexPath.Row].Title;
            return cell;
        }

	}

}

