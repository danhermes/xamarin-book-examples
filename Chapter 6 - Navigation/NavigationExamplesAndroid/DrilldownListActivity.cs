using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace NavigationExamplesAndroid
{
    [Activity(Label = "DrilldownListActivity")]
    public class DrilldownListActivity : ListActivity
    {

        List<ListItem> listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<ListItem> { 
				new ListItem {Title = "First Page", PageType= typeof(DrilldownActivity1)}, 
				new ListItem {Title = "Second Page", PageType= typeof(DrilldownActivity2)},
				new ListItem {Title = "Third Page", PageType= typeof(DrilldownActivity3)}  
			};

            ListAdapter = new ListItemAdapter(this, listItems);

        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(listItems[position].PageType);
        }

    }
}

