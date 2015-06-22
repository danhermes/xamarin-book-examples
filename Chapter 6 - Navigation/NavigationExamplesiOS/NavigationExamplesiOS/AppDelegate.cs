using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace NavigationExamplesiOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		public static UIStoryboard Storyboard = UIStoryboard.FromName ("NavigationStory", null);
		public static UIViewController firstViewController;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			firstViewController = Storyboard.InstantiateInitialViewController () as UIViewController;
			UINavigationController navController = new UINavigationController (firstViewController);

			window.RootViewController = navController;
			window.MakeKeyAndVisible ();

			return true;
		}

	}
}

