using System;
using Android.App;
using Android.OS;

namespace FragmentExample
{
    [Activity(Label = "FragmentExample", MainLauncher = true)]
	public class SampleFragmentActivity : Activity
	{
		public SampleFragmentActivity ()
		{
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
		}
	}
}
	