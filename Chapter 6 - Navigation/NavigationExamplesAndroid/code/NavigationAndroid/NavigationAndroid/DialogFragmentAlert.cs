using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace NavigationAndroid
{

    public class DialogFragmentAlert : DialogFragment
    {
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            //EventHandler<DialogClickEventArgs> okhandler;
            var builder = new AlertDialog.Builder(Activity)
                .SetMessage("This is an AlertDialog.")
                .SetPositiveButton("Ok", (sender, args) =>
                {
                    // Handles button click
                })
                .SetTitle("DialogFragment");
            return builder.Create();
        }
    }

}