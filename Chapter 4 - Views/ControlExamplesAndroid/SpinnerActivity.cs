
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
    [Activity(Label = "SpinnerActivity")]
	public class SpinnerActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Spinner);
			Spinner spinner = FindViewById<Spinner> (Resource.Id.spinner);
			spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (spinner_ItemSelected);

			string[] options = {"one", "two", "three", "four", "five"} ;
			ArrayAdapter adapter = new ArrayAdapter (this,
				Resource.Layout.TextViewForSpinner, options);   
    
			spinner.Adapter = adapter;
		}

		private void spinner_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;

			string toast = string.Format ("Selection: {0}", spinner.GetItemAtPosition (e.Position));
			Toast.MakeText (this, toast, ToastLength.Long).Show ();
		}
	}
}

