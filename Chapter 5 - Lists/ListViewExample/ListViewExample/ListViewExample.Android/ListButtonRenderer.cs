using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using ListViewExample.Droid;

// Workaround for Android ListView/Button bug https://forums.xamarin.com/discussion/21913/button-inside-listview

[assembly: ExportRenderer(typeof(Button), typeof(ListButtonRenderer))]
namespace ListViewExample.Droid
{
    public class ListButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.Focusable = false;
        }
    }
    
}