using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace NavigationAndroid
{
    //[Activity(Label = "NavigationAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    //[Activity(Label = "NavigationAndroid - no restart", MainLauncher = true , ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    //[Activity(Label = "NavigationAndroid - portrait", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    //[Activity(Label = "NavigationAndroid - landscape", MainLauncher = true, ScreenOrientation = ScreenOrientation.Landscape)] 
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate 
            {
              Intent intent = new Intent(this, typeof(DetailActivity));
              //intent.SetFlags(ActivityFlags.ReorderToFront);
              StartActivity (intent); // OR StartActivity(typeof(DetailActivity));

            };

            //Check rotation orientation
            var orientation = WindowManager.DefaultDisplay.Rotation;
            if (orientation == SurfaceOrientation.Rotation0 || orientation == SurfaceOrientation.Rotation180)
            {
                // Portrait
            }
            else
            {
                // Landscape 
            }

        }
    }
}

