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
    [Activity(Label = "TableViewActivity", MainLauncher = false, Icon = "@drawable/icon")]
    public class TableViewCodeActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);

            var tableLayout = new TableLayout(this);
            tableLayout.LayoutParameters = new TableLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            TableRow tableRow1 = new TableRow(this);
            TableRow tableRow2 = new TableRow(this);

            var aTextView1 = new TextView(this);
            aTextView1.Text = "A TextView";

            var aTextView2 = new TextView(this);
            aTextView2.Text = "And another!";

            tableRow1.AddView(aTextView1, 0);
            tableRow1.AddView(aTextView2, 1);


            var aButton1 = new Button(this);
            aButton1.Text = "Click Me!";

            var aButton2 = new Button(this);
            aButton2.Text = "Or Me!";

            tableRow2.AddView(aButton1, 0);
            tableRow2.AddView(aButton2, 1);

            tableLayout.AddView(tableRow1, 0);
            tableLayout.AddView(tableRow2, 1);

            SetContentView(tableLayout);
        }

    }
}