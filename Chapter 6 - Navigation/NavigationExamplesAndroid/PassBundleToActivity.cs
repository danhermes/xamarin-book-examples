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

namespace NavigationExamplesAndroid
{
    [Activity(Label = "PassToBundleActivity")]
    public class PassBundleToActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PassTo);

            TextView text1 = FindViewById<TextView>(Resource.Id.textPassed1);
            TextView text2 = FindViewById<TextView>(Resource.Id.textPassed2);

            text1.Text = Intent.GetStringExtra("MyData") ?? "No Data";
            text2.Text = Intent.GetStringExtra("MyData2") ?? "No Data";

        }
    }
}