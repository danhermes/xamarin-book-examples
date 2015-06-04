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
    [Activity(Theme = "@android:style/Theme.Material", Label = "TabMenuActivity")] // don't use MyTheme for this activity as it's not compatible with ActionBar
    public class TabMenuActivity : Activity 
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.TabMain);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            var tab = ActionBar.NewTab();
            tab.SetText("First Item");
            var tabFirst = new TabFirstFragment();
            tab.TabSelected += delegate(object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null)
                    e.FragmentTransaction.Remove(fragment);
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, tabFirst);
            };

            tab.TabUnselected += delegate(object sender, ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Remove(tabFirst);
            };

            ActionBar.AddTab(tab);

            var tab2 = ActionBar.NewTab();
            tab2 = ActionBar.NewTab();
            tab2.SetText("Second Item");
            var tabSecond = new TabSecondFragment();
            tab2.TabSelected += delegate(object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null)
                    e.FragmentTransaction.Remove(fragment);
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, tabSecond);
             };

            tab.TabUnselected += delegate(object sender, ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Remove(tabFirst);
            };

            ActionBar.AddTab(tab2);

        }
    }
}