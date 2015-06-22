using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewExamplesAndroid
{
    [Activity(Label = "ListActivityArray", MainLauncher = false, Icon = "@drawable/icon")]
    public class ListActivityArray : ListActivity
    {
        string[] listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new string[] { "First", "Second", "Third" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, listItems);
            
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            String SelectedItem = listItems[position];
            Android.Widget.Toast.MakeText(this, SelectedItem, Android.Widget.ToastLength.Short).Show();
        }

    }
}

