using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace NavigationDrawer
{
    [Activity(Label = "NavigationDrawer", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private DrawerLayout drawerLayout;
		private ListView drawerListView;
        private static readonly string[] Sections = new[] {
			"First", "Second"
		};

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            //this.title = this.drawerTitle = this.Title;
			this.drawerLayout = this.FindViewById<DrawerLayout> (Resource.Id.drawer_layout);
			this.drawerListView = this.FindViewById<ListView> (Resource.Id.left_drawer);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);
            //SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            //SupportActionBar.SetHomeButtonEnabled(true);

            //            this.title = this.drawerTitle = this.Title;

			this.drawerLayout = this.FindViewById<DrawerLayout> (Resource.Id.drawer_layout);
			this.drawerListView = this.FindViewById<ListView> (Resource.Id.left_drawer);

            //Create Adapter for drawer List
			this.drawerListView.Adapter = new ArrayAdapter<string> (this, Resource.Layout.item_menu, Sections);

			//Set click handler when item is selected
			this.drawerListView.ItemClick += (sender, args) => ListItemClicked (args.Position);

			//Set Drawer Shadow
			//this.drawerLayout.SetDrawerShadow (Resource.Drawable.drawer_shadow_dark, (int)GravityFlags.Start);

            ////DrawerToggle is the animation that happens with the indicator next to the actionbar
            //this.drawerToggle = new MyActionBarDrawerToggle (this, this.drawerLayout,
            //    this.Toolbar,
            //    Resource.String.drawer_open,
            //    Resource.String.drawer_close);

            ////Display the current fragments title and update the options menu
            //this.drawerToggle.DrawerClosed += (o, args) => {
            //    this.SupportActionBar.Title = this.title;
            //    this.InvalidateOptionsMenu ();
            //};

            ////Display the drawer title and update the options menu
            //this.drawerToggle.DrawerOpened += (o, args) => {
            //    this.SupportActionBar.Title = this.drawerTitle;
            //    this.InvalidateOptionsMenu ();
            //};

            ////Set the drawer lister to be the toggle.
            //this.drawerLayout.SetDrawerListener (this.drawerToggle);
        }

        private void ListItemClicked (int position)
		{
			Android.Support.V4.App.Fragment fragment = null;
			switch (position) {
			case 0:
				fragment = new FirstFragment();
				break;
			case 1:
				fragment = new SecondFragment();
				break;
			}

            //SupportFragmentManager.BeginTransaction ()
            //    .Replace (Resource.Id.content_frame, fragment)
            //    .Commit ();

            //this.drawerListView.SetItemChecked (position, true);
            //SupportActionBar.Title = this.title = Sections [position];
            //this.drawerLayout.CloseDrawers();
		}
    }
}

