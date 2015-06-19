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
    //[Activity(Label = "MenuListItemAdapter")]
    public class MenuListItemAdapter : BaseAdapter
    {
        private List<MenuListItem> itemList;
        private Activity context;

        public MenuListItemAdapter(Activity context, List<MenuListItem> items)
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
            View view = convertView; 
            if (view == null) 
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = itemList[position].Title;
            return view;
        }

    }
}