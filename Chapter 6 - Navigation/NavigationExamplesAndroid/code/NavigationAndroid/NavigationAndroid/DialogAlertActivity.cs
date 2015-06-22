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

namespace NavigationAndroid
{
    //[Activity(Label = "DialogAlertActivity", MainLauncher = true)]
    public class DialogAlertActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //DialogFragment
            var transaction = FragmentManager.BeginTransaction();
            var dialogFragment = new DialogFragmentAlert();
            dialogFragment.Show(transaction, "dialog_fragment");
        }
    }
}