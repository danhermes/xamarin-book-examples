using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

// Chapter 3 - Android Layout Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace LayoutAndroidExample
{
    [Activity(Label = "Android Layouts - Chapter 3", MainLauncher = true)]
    public class MainActivity : ListActivity
    {

        List<ListItem> listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<ListItem> { 
				new ListItem {Title = "LinearLayout", PageType= typeof(LinearLayoutActivity)}, 
   				new ListItem {Title = "LinearLayout in Code", PageType= typeof(LinearLayoutCodeActivity)}, 
  				new ListItem {Title = "RelativeLayout", PageType= typeof(RelativeLayoutActivity)},
                new ListItem {Title = "TableLayout", PageType= typeof(TableLayoutActivity)},
				new ListItem {Title = "TableView", PageType= typeof(TableViewActivity)},
				new ListItem {Title = "TableView in Code", PageType= typeof(TableViewCodeActivity)},
                new ListItem {Title = "GridLayout", PageType= typeof(GridLayoutActivity)},
  				new ListItem {Title = "GridLayout Specifying Row and Column", PageType= typeof(GridRowColActivity)},
                new ListItem {Title = "GridLayout Multi-cell", PageType= typeof(GridMultiCellActivity)},
  				new ListItem {Title = "FrameLayout", PageType= typeof(FrameLayoutActivity)}
			};

            ListAdapter = new ListItemAdapter(this, listItems);

        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(listItems[position].PageType);
        }

    }
}

