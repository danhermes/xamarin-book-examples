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
    public class MenuListItem
    {
        public string Title { get; set; }
        public Type PageType { get; set; }
    }
}