using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace LayoutExample.Xaml.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            SetTitleFont(UIColor.Red);

            return base.FinishedLaunching(app, options);
        }

        public void SetTitleFont (UIColor foregroundColor)
        {
            var TitleAttr = new UIStringAttributes {
                ForegroundColor = foregroundColor,
               // Font = UIFont.FromName (fontName, fontSize),
                KerningAdjustment = 2
            }; 

            UINavigationBar.Appearance.TitleTextAttributes = TitleAttr;
        }
    }
}

