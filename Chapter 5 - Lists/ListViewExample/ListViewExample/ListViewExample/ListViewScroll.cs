using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewExample
{
    class ListViewScroll : ContentPage
    {
        public class ListItem {
			public string Title { get; set; }
			public string Description { get; set; }
		}

        public ListViewScroll()
		{
			var listView = new ListView();
			listView.ItemsSource = new ListItem [] { 
				new ListItem {Title = "First", Description="1st item"}, 
				new ListItem {Title = "Second", Description="2nd item"},
				new ListItem {Title = "Third", Description="3rd item"},
                new ListItem {Title = "Fourth", Description="4th item"}, 
				new ListItem {Title = "Fifth", Description="5th item"},
				new ListItem {Title = "Sixth", Description="6th item"} ,
                new ListItem {Title = "Seventh", Description="7th item"}, 
				new ListItem {Title = "Eighth", Description="8th item"},
				new ListItem {Title = "Ninth", Description="9th item"} ,
                new ListItem {Title = "Tenth", Description="10th item"}, 
				new ListItem {Title = "Eleventh", Description="11th item"},
				new ListItem {Title = "Twelfth", Description="12th item"} ,
                new ListItem {Title = "Thirteenth", Description="13th item"}, 
				new ListItem {Title = "Fourteenth", Description="14th item"},
				new ListItem {Title = "Fifteenth", Description="15th item"} ,
                new ListItem {Title = "Sixteenth", Description="16th item"}, 
				new ListItem {Title = "Seventeenth", Description="17th item"},
				new ListItem {Title = "Eighteenth", Description="18th item"} 
			};
			listView.ItemTemplate = new DataTemplate (typeof(TextCell));
			listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
			Content = listView;

			this.Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
		}

    }
}
