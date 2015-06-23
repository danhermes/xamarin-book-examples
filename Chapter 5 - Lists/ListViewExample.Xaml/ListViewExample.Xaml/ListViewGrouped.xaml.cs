using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListViewExample.Xaml
{
    public partial class ListViewGrouped : ContentPage
    {
        public ListViewGrouped()
        {
            InitializeComponent();

            this.BindingContext = new ListViewGroupedViewModel();
        }
    }


    public class ListViewGroupedViewModel : BindableObject
    {
        List<Group> itemsGrouped;
        public List<Group> ItemsGrouped
        {
            get
            {
                return itemsGrouped;
            }
            set
            {
                itemsGrouped = value;
                OnPropertyChanged("ItemsGrouped");
            }
        }

        public ListViewGroupedViewModel()
        {
            ItemsGrouped = new List<Group> { 
                new Group("Important", new List<ListItem>
                    {
                        new ListItem {Title = "First", Description="1st item"}, 
                        new ListItem {Title = "Second", Description="2nd item"}
                    }),
                new Group("Less Important", new List<ListItem>
                    {
                        new ListItem {Title = "Third", Description="3rd item"}
                    })
            };
        }

        public class ListItem 
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public class Group : List<ListItem>
        {
            public string Key {
                get;
                private set;
            }

            public Group (string key, List<ListItem> listItems)
            {
                Key = key;
                foreach (var item in listItems)
                    this.Add(item);
            }
        }
    }
}

