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
    [Activity(Label = "DetailActivity")]
    public class PassStringToActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PassTo);

            TextView text1 = FindViewById<TextView>(Resource.Id.textPassed1);

            Button button = FindViewById<Button>(Resource.Id.MyButton);
            String text = Intent.GetStringExtra("MyData") ?? "No Data";
            text1.Text = text;
        }
    }
}