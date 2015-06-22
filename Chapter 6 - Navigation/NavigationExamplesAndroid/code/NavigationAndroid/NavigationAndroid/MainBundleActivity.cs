using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NavigationAndroid
{
    //[Activity(Label = "MainBundleActivity", MainLauncher = true)]
    public class MainBundleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // using Bundles
            Bundle thisBundle = new Bundle();
            thisBundle.PutString("MyData", "A string of data.");
            thisBundle.PutString("MyData2", "Another string of data.");
            var intent = new Intent(this, typeof(PassToBundleActivity));
            intent.PutExtras(thisBundle);
            StartActivity(intent);
        }
    }
}