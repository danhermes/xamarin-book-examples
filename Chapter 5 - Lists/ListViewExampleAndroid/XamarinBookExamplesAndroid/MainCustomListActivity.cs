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
    [Activity(Label = "MainCustomListActivity", MainLauncher = false, Icon = "@drawable/icon")]
    public class MainCustomListActivity : Activity
    {
        List<ListItem> listItems;
        ListView listView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<ListItem> { 
                new ListItem {Title = "First", Description="1st item"}, 
                new ListItem {Title = "Second", Description="2nd item"},
                new ListItem {Title = "Third", Description="3rd item"} 
            };

            SetContentView(Resource.Layout.HomeLayout); 
            listView = FindViewById<ListView>(Resource.Id.listItems); 
            listView.Adapter = new ListCustomAdapter(this, listItems);
            listView.ItemClick += OnListItemClick;  
  
        }

        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            String SelectedItem = listItems[e.Position].Title;
            Android.Widget.Toast.MakeText(this, SelectedItem, Android.Widget.ToastLength.Short).Show();
        }

    }
}

