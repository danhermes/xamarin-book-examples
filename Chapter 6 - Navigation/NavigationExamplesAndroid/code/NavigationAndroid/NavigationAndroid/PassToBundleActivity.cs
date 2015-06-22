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
    [Activity(Label = "PassToBundleActivity")]
    public class PassToBundleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            String text = Intent.GetStringExtra("MyData") ?? "No Data";
            String text2 = Intent.GetStringExtra("MyData2") ?? "No Data";

        }
    }
}