using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace NavigationExamplesiOS
{
	public class DrilldownListSource : UITableViewSource
	{

		protected List<ListItem> listItems;
		protected string CellId= "TableCell";
		protected UIViewController parentController;

		public DrilldownListSource (List<ListItem> items, UIViewController parentController) 
		{
			listItems = items;
			this.parentController = parentController;
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
		
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var detail = new DetailPage (listItems[indexPath.Row]);
		   parentController.NavigationController.PushViewController(detail,true);
		   tableView.DeselectRow (indexPath, true);
		}  


	}

}

