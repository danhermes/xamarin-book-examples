using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NavigationExamples
{
    class DrilldownListViewByItem : ContentPage
	{
        public DrilldownListViewByItem()
		{
            Title = "Drilldown List Using ListView";

			var listView = new ListView();
			listView.ItemsSource = new ListItem [] { 
				new ListItem {Title = "First", Description="1st item"}, 
				new ListItem {Title = "Second", Description="2nd item"},
				new ListItem {Title = "Third", Description="3rd item"} 
			};
			listView.ItemTemplate = new DataTemplate (typeof(TextCell));
			listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");

            listView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as ListItem;
                if (item == null) return;
                await Navigation.PushAsync(new DetailPage(item));
                listView.SelectedItem = null;
            };

			Content = listView;
		}

	} 

}

