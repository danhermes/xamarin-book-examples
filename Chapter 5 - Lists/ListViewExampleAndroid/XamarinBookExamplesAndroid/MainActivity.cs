using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

// Chapter 5 - Android ListView Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace ListViewExamplesAndroid
{
    [Activity(Label = "Android ListView - Chapter 5", MainLauncher = true)]
    public class MainActivity : ListActivity
    {

        List<MenuListItem> listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<MenuListItem> { 
				new MenuListItem {Title = "Bind to Array of Strings", PageType= typeof(ListActivityArray)}, 
				new MenuListItem {Title = "Bind to Data Model", PageType= typeof(ListActivityDataModel)},
				new MenuListItem {Title = "Customize List", PageType= typeof(MainCustomListActivity)},
				new MenuListItem {Title = "Grouping a list", PageType= typeof(MainActivityGrouped)}
			};

            ListAdapter = new MenuListItemAdapter(this, listItems);

        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(listItems[position].PageType);
        }

    }
}

