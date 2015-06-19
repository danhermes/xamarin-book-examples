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

namespace LayoutAndroidExample
{
    [Activity(Label = "LinearLayoutActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class LinearLayoutCodeActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);

            var linearLayout = new LinearLayout(this);
            linearLayout.Orientation = Orientation.Vertical;

            var aTextView = new TextView(this);
            aTextView.Text = " A TextView ";


            var aButtonMe = new Button(this);
            aButtonMe.Text = "Click Me!";

            var aButtonOrMe = new Button(this);
            aButtonOrMe.Text = "Or Me!";

            linearLayout.AddView(aTextView);
            linearLayout.AddView(aButtonMe);
            linearLayout.AddView(aButtonOrMe);

            SetContentView(linearLayout);
        }

    }
}