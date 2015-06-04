using System;
using Android.App;
using Android.OS;

namespace NavigationExamplesAndroid
{
    [Activity(Label = "FragmentsActivity")]
    public class FragmentsActivity : Activity
	{
		public FragmentsActivity ()
		{
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.MainFragment);
		}
	}
}
	