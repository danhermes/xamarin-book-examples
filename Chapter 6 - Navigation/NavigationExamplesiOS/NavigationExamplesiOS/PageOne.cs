using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NavigationExamplesiOS
{
	
	partial class PageOne : UIViewController
	{
		public PageOne (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			buttonGoToTwo.TouchUpInside += (sender, ea) => {
				PageTwo pageTwo =	this.Storyboard.InstantiateViewController ("PageTwo") as PageTwo;
				NavigationController.PushViewController(pageTwo,true);
			};

			buttonModal.TouchUpInside += (sender, ea) => {
				PageModal pageModal = this.Storyboard.InstantiateViewController ("PageModal") as PageModal;
				this.PresentViewController(pageModal,true,null);
			};

			buttonAlert.TouchUpInside += (sender, ea) => {
				var alert = UIAlertController.Create("Important","Are you sure you want to do this irreversible thing?", UIAlertControllerStyle.Alert);
				alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, alertAction => {}));
				alert.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Default, alertAction => {}));
				this.PresentViewController(alert, true, null);
			};

			buttonPopup.TouchUpInside += (sender, ea) => {
				var popup = UIAlertController.Create("What is your choice?", null, UIAlertControllerStyle.ActionSheet);
				var firstChoice= UIAlertAction.Create ("First Choice",   UIAlertActionStyle.Default, alertAction => {});
				popup.AddAction(firstChoice);
				var secondChoice= UIAlertAction.Create ("Second Choice",   UIAlertActionStyle.Default, alertAction => {});
				popup.AddAction(secondChoice);
				popup.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, alertAction => {}));
				this.PresentViewController(popup, true, null);
			};
			
			ListItem item = new ListItem();
			item.Title = "Item Title";
			item.Description = "Detailed Information about this item";


			buttonPassProperty.TouchUpInside += (sender, ea) => {
				DetailPageProperty detailPageProperty =	this.Storyboard.InstantiateViewController ("DetailPageProperty") as DetailPageProperty;
				detailPageProperty.Item = item;
				NavigationController.PushViewController(detailPageProperty,true);
			};

			buttonPassConstructorParam.TouchUpInside += (sender, ea) => {
				DetailPage detailPage =	new DetailPage(item);
				NavigationController.PushViewController(detailPage,true);
			};

			buttonDrilldownList.TouchUpInside += (sender, ea) => {
				DrilldownList tabPage =	new DrilldownList();
				NavigationController.PushViewController(tabPage,true);
			};

			buttonTabs.TouchUpInside += (sender, ea) => {
				TabBarController tabPage =	new TabBarController();
				NavigationController.PushViewController(tabPage,true);
			};
			
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, 
			NSObject sender)
		{
			ListItem item = new ListItem();
			item.Title = "Item Title";
			item.Description = "Detailed Information about this item";

			base.PrepareForSegue (segue, sender);
			var detailPage = segue.DestinationViewController 
				as DetailPageProperty;
			if (detailPage != null) {
				detailPage.Item = item;
			}
		}

			
	}
}
