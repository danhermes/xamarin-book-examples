using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NavigationExamples
{
	class DrilldownListViewByPage : ContentPage
	{
        public DrilldownListViewByPage()
		{
            Title = "Drilldown List Using ListView";

			var listView = new ListView();
			listView.ItemsSource = new ListItemPage [] { 
				new ListItemPage {Title = "First", PageType= typeof(FirstPage)}, 
				new ListItemPage {Title = "Second", PageType= typeof(SecondPage)},
				new ListItemPage {Title = "Third", PageType= typeof(ThirdPage)} 
			};
			listView.ItemTemplate = new DataTemplate (typeof(TextCell));
			listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");

            listView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as ListItemPage;
                if (item == null) return;
                Page page = (Page)Activator.CreateInstance(item.PageType);
                await Navigation.PushAsync(page);
                listView.SelectedItem = null;
            };

			Content = listView;
		}

        public class ListItemPage
        {
            public string Title { get; set; }
            public Type PageType { get; set; }
        }

	} 

}

