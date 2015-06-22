using System;
using Foundation;
using UIKit;

namespace iOSListExample
{
	public class ListSourceFromArray : UITableViewSource
	{
		protected string[] listItems;
		protected string CellId= "TableCell";

		public ListSourceFromArray(string[] items)
		{
			listItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return listItems.Length;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView("Row Selected", listItems[indexPath.Row], null, "OK", null).Show();
			tableView.DeselectRow (indexPath, true);  
		}


		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellId);
			if (cell == null)  cell = new UITableViewCell (UITableViewCellStyle.Default,  CellId);
			cell.TextLabel.Text = listItems[indexPath.Row];
			return cell;
		}

	}
}

