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

namespace ControlExamplesAndroid
{
    [Activity(Label = "TimePickerActivity")]
    public class TimePickerActivity : Activity
    {
        DateTime time;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Picker);

            var textView = FindViewById<TextView>(Resource.Id.textView);
            textView.Text = "Pick Time";

            textView.Click += delegate
            {
                ShowDialog(0);
            };

            time = DateTime.Today;
        }

        protected override Dialog OnCreateDialog(int id)
        {
            return new TimePickerDialog(this, HandleDateSet, time.Hour, time.Minute, false);
        }

        void HandleDateSet(object sender, TimePickerDialog.TimeSetEventArgs e)
        {
            var textView = FindViewById<TextView>(Resource.Id.textView);
            time = new DateTime(time.Year, time.Month, time.Day, e.HourOfDay, e.Minute, 0);

            textView.Text = time.ToString("h:mm:ss tt");
        }

    }

}