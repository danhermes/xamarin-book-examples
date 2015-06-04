using System;
using Xamarin.Forms;

// Chapter 5 - Xamarin.Forms ListView Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace ListViewExample
{

    class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Xamarin.Forms ListView - Chapter 5";

            var listView = new ListView();
            listView.ItemsSource = new ListItemPage[] { 
				new ListItemPage {Title = "Bind to a List of Strings", PageType= typeof(ListViewStrings)}, 
				new ListItemPage {Title = "Bind to a Data Model", PageType= typeof(ListViewDataModel)},
				new ListItemPage {Title = "Add Image", PageType= typeof(ListViewImageCell)},
                new ListItemPage {Title = "Customize ListView", PageType= typeof(ListViewCustom)}, 
				new ListItemPage {Title = "Customize with Image", PageType= typeof(ListViewCustomWithImage)},
				new ListItemPage {Title = "Customize with Button", PageType= typeof(ListViewButton)}, 
                new ListItemPage {Title = "Add ContextAction", PageType= typeof(ListViewContextAction)}, 
				new ListItemPage {Title = "Grouping Headers", PageType= typeof(ListViewGrouped)},
				new ListItemPage {Title = "Customize Grouping Headers", PageType= typeof(ListViewGroupingTemplate)},
                new ListItemPage {Title = "Scroll the List", PageType= typeof(ListViewScroll)}, 
				new ListItemPage {Title = "Optimize Performance", PageType= typeof(ListViewPerformance)}
			};
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
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
