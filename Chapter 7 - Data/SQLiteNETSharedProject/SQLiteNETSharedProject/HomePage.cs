using System;
using System.Collections.Generic;
using Xamarin.Forms;

// Chapter 7 - Xamarin.Forms SQLite.NET examples from
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace SQLiteNETSharedProject
{
	class HomePage : ContentPage
	{
        public HomePage()
		{
            Title = "SQLite.NET: Chapter 7";

			var listView = new ListView();
			listView.ItemsSource = new ListItemPage [] { 
				new ListItemPage {Title = "Basic Repository", PageType= typeof(DataAccessPageDatabase)}, 
				new ListItemPage {Title = "Advanced Repository", PageType= typeof(DataAccessPageRepository)}, 
				new ListItemPage {Title = "Access the Person Table", PageType= typeof(DataAccessPagePerson)} 
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

