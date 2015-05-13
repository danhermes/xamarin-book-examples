
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
    [Activity(Label = "SelectionActivity")]
	public class SelectionActivity : Activity
	{
        RadioButton radio1;
        RadioButton radio2;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Selection);

			SeekBar seekBar = FindViewById<SeekBar> (Resource.Id.seekBar);
            seekBar.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) =>
            {
                if (e.FromUser)
                {
                    Toast.MakeText(this, "Value: " + e.Progress, ToastLength.Short).Show();
                }
            }; 

            CheckBox checkBox1 = FindViewById<CheckBox> (Resource.Id.checkBox1);
			CheckBox checkBox2 = FindViewById<CheckBox> (Resource.Id.checkBox2);
            checkBox1.Click += (o, e) =>
            {
                if (checkBox1.Checked)
                    Toast.MakeText(this, "Box 1 Checked", ToastLength.Short).Show();
                else
                    Toast.MakeText(this, "Box 1 Not checked", ToastLength.Short).Show();
            };
            checkBox2.Click += (o, e) =>
            {
                if (checkBox2.Checked)
                    Toast.MakeText(this, "Box 2 Checked", ToastLength.Short).Show();
                else
                    Toast.MakeText(this, "Box 2 Not checked", ToastLength.Short).Show();
            };

			Switch switch1 = FindViewById<Switch> (Resource.Id.switch1);
            switch1.CheckedChange += delegate(object sender, CompoundButton.CheckedChangeEventArgs e)
            {
                var toast = Toast.MakeText(this, "Selection:" + (e.IsChecked ? "On" : "Off"), ToastLength.Short);
                toast.Show();
            };

            radio1 = FindViewById<RadioButton>(Resource.Id.radio1);
            radio2 = FindViewById<RadioButton>(Resource.Id.radio2);
            radio1.Click += RadioButtonClick;
            radio2.Click += RadioButtonClick; 

		}

        private void RadioButtonClick(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            Toast.MakeText(this, rb.Text, ToastLength.Short).Show();
        } 

	}
}

