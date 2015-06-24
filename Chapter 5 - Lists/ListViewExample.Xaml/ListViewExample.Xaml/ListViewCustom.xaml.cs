using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListViewExample.Xaml
{
    public partial class ListViewCustom : ContentPage
    {
        public ListViewCustom()
        {
            InitializeComponent();

            BindingContext = new ListViewCustomViewModel();
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListItem : BindableObject
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public class ListViewCustomViewModel : BindableObject
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

            public ListViewCustomViewModel()
            {
                ListItems = new List<ListItem> { 
                    new ListItem {Title = "First", Description="1st item", Price="$100.00"}, 
                    new ListItem {Title = "Second", Description="2nd item", Price="$200.00"},
                    new ListItem {Title = "Third", Description="3rd item", Price="$300.00"}
                };
            }           
        }
    }
}

