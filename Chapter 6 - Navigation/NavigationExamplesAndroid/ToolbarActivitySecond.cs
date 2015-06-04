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
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace NavigationExamplesAndroid
{
    [Activity(Label = "ToolbarActivitySecond")]
    public class ToolbarActivitySecond : ActionBarActivity 
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MainToolbarSecond);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Toolbar Second Page";
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            toolbar.MenuItemClick += (sender, e) =>
            {
                Toast.MakeText(this, "Toolbar pressed: " + e.Item.TitleFormatted, ToastLength.Short).Show();
            };

        }

        public override bool OnCreateOptionsMenu (IMenu menu)
        {
            MenuInflater.Inflate (Resource.Menu.popupmenu, menu);
            return base.OnCreateOptionsMenu (menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Android.Resource.Id.Home)
                Finish();
            return base.OnOptionsItemSelected(item);
        }
        //public override bool OnOptionsItemSelected(IMenuItem item)
        //{
        //    Intent intent = new Intent(typeof(ToolbarActivity));
        //    startActivity(intent);
        //    return true;
        //}


    }
}