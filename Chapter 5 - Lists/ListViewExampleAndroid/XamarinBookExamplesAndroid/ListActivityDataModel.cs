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
    [Activity(Label = "ListActivityDataModel", MainLauncher = false, Icon = "@drawable/icon")]
    public class ListActivityDataModel : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var listItems = new List<ListItem> { 
                new ListItem {Title = "First", Description="1st item"}, 
                new ListItem {Title = "Second", Description="2nd item"},
                new ListItem {Title = "Third", Description="3rd item"} 
            };
            ListAdapter = new ListItemAdapter(this, listItems);
            
        }

    }
}

