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
    [Activity(Label = "StateActivity")]
    public class StateActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Intent intent = new Intent(this, typeof(DetailActivity));
            intent.PutExtra("MyData", "A string of data");
            StartActivity(intent); 

        }
    }
}