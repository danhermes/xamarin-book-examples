using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ControlExamplesAndroid
{
    [Activity(Label = "DatePickerActivity")]
    public class DatePickerActivity : Activity
    {
        DateTime date;
        
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            SetContentView (Resource.Layout.Picker);

            var textView = FindViewById<TextView>(Resource.Id.textView);
            
            textView.Click += delegate {
                ShowDialog (0);
            };

            date = DateTime.Today;
        }
        
        protected override Dialog OnCreateDialog (int id)
        {
            return new DatePickerDialog (this, HandleDateSet, date.Year, date.Month - 1, date.Day); 
        }
        
        void HandleDateSet (object sender, DatePickerDialog.DateSetEventArgs e)
        {
            var textView = FindViewById<TextView>(Resource.Id.textView);
            date = e.Date;
            textView.Text = date.ToString("d");
        }


    }
}