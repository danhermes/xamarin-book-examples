using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ControlExamplesAndroid
{
    [Activity(Label = "DateTimeActivity")]
    public class DateTimeActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.DateTime);

			DatePicker datePicker = FindViewById<DatePicker> (Resource.Id.datePicker);
			TimePicker timePicker = FindViewById<TimePicker> (Resource.Id.timePicker);

            timePicker.TimeChanged += delegate(object sender, TimePicker.TimeChangedEventArgs e)
            {
                Toast.MakeText(this, "Hour: " + e.HourOfDay + " Minute: " + e.Minute, ToastLength.Short).Show();
            };


        }


	}
}


