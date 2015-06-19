using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace iOSListExample
{
	public class ListSourceStyles : UITableViewSource
	{

		protected List<ListItem> listItems;
		protected string CellId= "TableCell";

        public ListSourceStyles(List<ListItem> items)
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

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellId);
			if (cell == null)  cell = new UITableViewCell (UITableViewCellStyle.Default,  CellId);
			//if (cell == null)  cell = new UITableViewCell (UITableViewCellStyle.Subtitle ,  CellId);
			//if (cell == null)  cell = new UITableViewCell (UITableViewCellStyle.Value1,  CellId);
			//if (cell == null)  cell = new UITableViewCell (UITableViewCellStyle.Value2,  CellId);
			cell.TextLabel.Text = listItems[indexPath.Row].Title;
			//cell.DetailTextLabel.Text  = listItems[indexPath.Row].Description;
			cell.Accessory = UITableViewCellAccessory.DetailButton;
			return cell;
		}

		public override void AccessoryButtonTapped (UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView("DetailDisclosureButton Tapped" 
				, listItems[indexPath.Row].Title, null, "OK", null).Show();
		}

	}

}

