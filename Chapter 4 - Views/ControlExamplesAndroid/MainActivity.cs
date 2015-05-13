using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ControlExamplesAndroid
{
    [Activity(Label = "ControlExamplesAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {

        List<ListItem> listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<ListItem> { 
				new ListItem {Title = "Spinner", PageType= typeof(SpinnerActivity)}, 
				new ListItem {Title = "Selection Controls", PageType= typeof(SelectionActivity)},
				new ListItem {Title = "Date Picker", PageType= typeof(DatePickerActivity)},
				new ListItem {Title = "Time Picker", PageType= typeof(TimePickerActivity)},
				new ListItem {Title = "Date/Time Picker", PageType= typeof(DateTimeActivity)} 
			};

            ListAdapter = new ListItemAdapter(this, listItems);

        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(listItems[position].PageType);
        }

    }
}

