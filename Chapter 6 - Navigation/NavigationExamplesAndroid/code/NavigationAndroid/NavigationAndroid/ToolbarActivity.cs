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
    //[Activity(Label = "ToolbarActivity",  MainLauncher = true) ]
    public class ToolbarActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Toolbar);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "Page Title";
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.setHomeButtonEnabled(true);

            //toolbar.MenuItemClick += (sender, e) =>
            //{
            //    Toast.MakeText(this, "Toolbar pressed: " + e.Item.TitleFormatted, ToastLength.Short).Show();
            //};

        }

        public override bool OnCreateOptionsMenu (IMenu menu)
        {
            //MenuInflater.Inflate (Resource.Menu.home, menu);
            return base.OnCreateOptionsMenu (menu);
        }
        public override bool OnOptionsItemSelected (IMenuItem item)
        {
            Toast.MakeText(this, "Top ActionBar pressed: " + item.TitleFormatted, ToastLength.Short).Show();
            return base.OnOptionsItemSelected (item);
        }

    }
}