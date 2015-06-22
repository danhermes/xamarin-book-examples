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

namespace NavigationExamplesAndroid
{
    [Activity(Label = "DialogViewActivity")]
    public class DialogViewActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //DialogFragment
            var transaction = FragmentManager.BeginTransaction();
            var dialogFragment = new DialogFragmentView();
            dialogFragment.Show(transaction, "dialog_fragment");
        }
    }
}