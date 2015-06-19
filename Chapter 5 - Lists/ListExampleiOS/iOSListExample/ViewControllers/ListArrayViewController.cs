
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace iOSListExample
{
	public partial class ListArrayViewController : UIViewController
	{
		public ListArrayViewController () 
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{

			base.ViewDidLoad();
			UITableView table = new UITableView(View.Bounds);
			string[] tableItems = new string[] {"First","Second","Third","Fourth","Fifth"};
			table.Source = new ListSourceFromArray(tableItems);
			//table.SeparatorStyle = UITableViewCellSeparatorStyle.None;
			Add (table); 

		}
	}
}

