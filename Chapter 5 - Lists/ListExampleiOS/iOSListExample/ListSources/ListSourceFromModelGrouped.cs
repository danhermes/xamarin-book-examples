using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace iOSListExample
{
	public class ListSourceFromModelGrouped : UITableViewSource
	{

		List<Group> groups;
		protected string cellId= "TableCell";

		public ListSourceFromModelGrouped (List<Group> items)
		{
			groups = items;
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return groups.Count;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			List<ListItem> list = groups [(int)section];
			return list.Count;
		}

		public override string TitleForHeader (UITableView tableView, nint section)
		{
			return groups[(int)section].Key;
		}

		public override string TitleForFooter (UITableView tableView, nint section)
		{
			List<ListItem> list = groups [(int)section];
			return list.Count + " items";
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			List<ListItem> list = groups [indexPath.Section];
			new UIAlertView("Row Selected"
				, list[indexPath.Row].Title
				, null, "OK", null).Show();
			tableView.DeselectRow (indexPath, true);
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellId);
			List<ListItem> list = groups [indexPath.Section];
			ListItem item = list[indexPath.Row];
			if (cell == null)
			{ cell = new UITableViewCell (UITableViewCellStyle.Default, cellId); }
			cell.TextLabel.Text = item.Title;

			return cell;
		}
	}

}

