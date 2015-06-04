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
    [Activity(Label = "PassToActivity")]
    public class PassToActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Pass via JSON
            String json = Intent.GetStringExtra("MyData") ?? "No Data";
            DataModel data = Newtonsoft.Json.JsonConvert.DeserializeObject<DataModel>(json);

        }
    }
}