using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NavigationExamplesiOS
{
	partial class DetailPageProperty : UIViewController
	{
		private ListItem _item;
		public ListItem Item 
		{ 
			get { return _item;}
			set { _item = value;}
		}

		public DetailPageProperty (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			LabelTitle.Text = _item.Title;
			LabelDescription.Text = _item.Description;
		}

	}
}
