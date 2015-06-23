using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace ListViewExample.Xaml
{
    public partial class ListViewScroll : ContentPage
    {
        public ListViewScroll()
        {
            InitializeComponent();

            BindingContext = new ListViewScrollViewModel();
        }
    }

    public class ListViewScrollViewModel : BindableObject
    {
        List<ListItem> listItems;
        public List<ListItem> ListItems
        {
            get
            {
                return listItems;
            }
            set
            {
                listItems = value;
                OnPropertyChanged("ListItems");
            }
        }

        public ListViewScrollViewModel()
        {
            ListItems = new List<ListItem>
            {
                new ListItem { Title = "First", Description = "1st item" }, 
                new ListItem { Title = "Second", Description = "2nd item" },
                new ListItem { Title = "Third", Description = "3rd item" },
                new ListItem { Title = "Fourth", Description = "4th item" }, 
                new ListItem { Title = "Fifth", Description = "5th item" },
                new ListItem { Title = "Sixth", Description = "6th item" },
                new ListItem { Title = "Seventh", Description = "7th item" }, 
                new ListItem { Title = "Eighth", Description = "8th item" },
                new ListItem { Title = "Ninth", Description = "9th item" },
                new ListItem { Title = "Tenth", Description = "10th item" }, 
                new ListItem { Title = "Eleventh", Description = "11th item" },
                new ListItem { Title = "Twelfth", Description = "12th item" },
                new ListItem { Title = "Thirteenth", Description = "13th item" }, 
                new ListItem { Title = "Fourteenth", Description = "14th item" },
                new ListItem { Title = "Fifteenth", Description = "15th item" },
                new ListItem { Title = "Sixteenth", Description = "16th item" }, 
                new ListItem { Title = "Seventeenth", Description = "17th item" },
                new ListItem { Title = "Eighteenth", Description = "18th item" } 
            };
        }

        public class ListItem : BindableObject
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }
    }
}

