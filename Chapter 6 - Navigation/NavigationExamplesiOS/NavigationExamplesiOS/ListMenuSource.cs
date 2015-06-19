using System;
using System.Collections.Generic;
using Foundation;
using UIKit;


namespace iOSListExample
{
	public class ListMenuSource : UITableViewSource
	{

		protected List<ListMenuItem> listItems;
		protected string CellId= "TableCell";
		UIViewController parentController;

		public ListMenuSource (List<ListMenuItem> items, UIViewController parentController)
		{
			listItems = items;
			this.parentController = parentController;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var page = (UIViewController)Activator.CreateInstance(listItems[indexPath.Row].PageType);
			parentController.NavigationController.PushViewController(page,true);
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

