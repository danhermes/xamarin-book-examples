using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListViewExample.Xaml
{
    public partial class ListViewDataModel : ContentPage
    {
        public ListViewDataModel()
        {
            InitializeComponent();

            BindingContext = new ListViewDataModelViewModel();

        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public class ListViewDataModelViewModel : BindableObject
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

            public ListViewDataModelViewModel()
            {
                ListItems = new List<ListItem>
                    {
                        new ListItem
                        {
                            Title = "First",
                            Description = "1st Item"
                        },
                        new ListItem
                        {
                            Title = "Second",
                            Description = "2nd Item"
                        },
                        new ListItem
                        {
                            Title = "Third",
                            Description = "3rd Item"
                        },
                    };
            }
        }
    }
}

