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

namespace ListViewExamplesAndroid
{
    [Activity(Label = "ListAdapter")]
    public class ListGroupAdapter : BaseAdapter
    {
        private List<ListItem> itemList;
        private Activity context;

        public ListGroupAdapter(Activity context, List<ListItem> items)
            : base()
        {
           this.context = context;
           this.itemList = items;
        }

        public override int Count
        {
            get { return itemList.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            // Both the group header and list item views should really be custom layout classes
            // for two reasons: they can be customized to look good, and should be easier to reuse cells while also checking if (convertView != typeof(customView)) to recreate view
            View view;
            if (itemList[position].IsGroupHeader) // group header view
            {
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null); 
                view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = itemList[position].Title;
            }
            else // list item view
            {
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
                view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = itemList[position].Title;
                view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = itemList[position].Description;
            }
            return view;
        }

    }
}