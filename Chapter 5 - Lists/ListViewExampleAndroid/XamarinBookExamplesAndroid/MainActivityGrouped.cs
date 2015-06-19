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
    [Activity(Label = "MainActivityGrouped", MainLauncher = false, Icon = "@drawable/icon")]
    public class MainActivityGrouped : ListActivity
    {
        List<ListItem> listItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            listItems = new List<ListItem>  { 
              new ListItem {Title = "Important", Description="", IsGroupHeader=true}, 
              new ListItem {Title = "First", Description="1st item", IsGroupHeader=false}, 
              new ListItem {Title = "Less Important", Description="", IsGroupHeader=true}, 
              new ListItem {Title = "Second", Description="2nd item", IsGroupHeader=false},
              new ListItem {Title = "Third", Description="3rd item", IsGroupHeader=false},
              new ListItem {Title = "Fourth", Description="4th item", IsGroupHeader=false},
              new ListItem {Title = "Fifth", Description="5th item", IsGroupHeader=false},
              new ListItem {Title = "Not Important", Description="", IsGroupHeader=true}, 
              new ListItem {Title = "Sixth", Description="6th item" , IsGroupHeader=false},
              new ListItem {Title = "Seventh", Description="7th item", IsGroupHeader=false}, 
              new ListItem {Title = "Eighth", Description="8th item", IsGroupHeader=false},
              new ListItem {Title = "Ninth", Description="9th item", IsGroupHeader=false},
              new ListItem {Title = "Tenth", Description="10th item", IsGroupHeader=false}, 
              new ListItem {Title = "Trivial", Description="", IsGroupHeader=true}, 
              new ListItem {Title = "Eleventh", Description="11th item", IsGroupHeader=false},
              new ListItem {Title = "Twelfth", Description="12th item", IsGroupHeader=false},
              new ListItem {Title = "Thirteenth", Description="13th item", IsGroupHeader=false}, 
              new ListItem {Title = "Fourteenth", Description="14th item", IsGroupHeader=false},
              new ListItem {Title = "Fifteenth", Description="15th item" , IsGroupHeader=false},
              new ListItem {Title = "Sixteenth", Description="16th item", IsGroupHeader=false}, 
              new ListItem {Title = "Seventeenth", Description="17th item", IsGroupHeader=false},
              new ListItem {Title = "Eighteenth", Description="18th item", IsGroupHeader=false} 
            };

            ListAdapter = new ListGroupAdapter(this, listItems);
  
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            String SelectedItem = listItems[position].Title;
            Android.Widget.Toast.MakeText(this, SelectedItem, Android.Widget.ToastLength.Short).Show();
        }

    }
}

