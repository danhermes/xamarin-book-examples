using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ListViewExample
{
	class ListViewGrouped : ContentPage // Grouping
	{
		public class ListItem {
			public string Title { get; set; }
			public string Description { get; set; }
		}

		public ListViewGrouped()
		{
             List<Group> itemsGrouped = new List<Group> { 
                new Group ("Important", new List<ListItem> {
                new ListItem {Title = "First", Description="1st item"}, 
                new ListItem {Title = "Second", Description="2nd item"},
                            }), 

                new Group ("Less Important", new List<ListItem>{
                new ListItem {Title = "Third", Description="3rd item"} 
                })
            };

            ListView listView = new ListView()
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Key"),
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings = {
                        { TextCell.TextProperty, new Binding("Title") }, 
                        { TextCell.DetailProperty, new Binding("Description") } 
                        }
                }
            };

            listView.ItemsSource = itemsGrouped;

            Content = listView;

			this.Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
		}

        public class Group : List<ListItem>
        {
            public String Key { get; private set; }

            public Group(String key, List<ListItem> items)
            {
                Key = key;
                foreach (var item in items)
                    this.Add(item);
            }

        }

	} 

}

