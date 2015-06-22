using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NavigationExamplesiOS
{
    public class TabBarController : UITabBarController {
		
         UIViewController tabFirst, tabSecond, tabThird;
        
		public TabBarController ()
        {
            tabFirst = new UIViewController();
            tabFirst.Title = "Purple";
			//tabFirst.TabBarItem = new UITabBarItem (UITabBarSystemItem.Favorites, 0);
			tabFirst.View.BackgroundColor = UIColor.Purple;

            tabSecond = new UIViewController();
			tabSecond.Title = "Black";
			//tabSecond.TabBarItem = new UITabBarItem ();
			//tabSecond.TabBarItem.Image = UIImage.FromFile ("second.png");

			tabSecond.View.BackgroundColor = UIColor.Black;

            tabThird = new UIViewController();
			tabThird.Title = "Blue";
			//tabThird.TabBarItem.BadgeValue = "New";
			tabThird.View.BackgroundColor = UIColor.Blue;

            var tabs = new UIViewController[] {
				tabFirst, tabSecond, tabThird
            };

            ViewControllers = tabs;
        }
		
    }

}
