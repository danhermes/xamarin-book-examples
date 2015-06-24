using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace ListViewExample.Xaml
{
    public partial class ListViewStrings : ContentPage
    {
        public ListViewStrings()
        {
            InitializeComponent();

            BindingContext = new ListViewStringsViewModel();
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            string item = (string)e.Item;
            await DisplayAlert("Tapped", item + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListViewStringsViewModel : BindableObject
        {
            List<string> items;
            public List<string> Items
            {
                get
                {
                    return items;
                }
                set
                {
                    items = value;
                    OnPropertyChanged("Items");
                }
            }

            public ListViewStringsViewModel()
            {
                Items = new List<string> 
                    {
                        "First",
                        "Second",
                        "Third"
                    };
            }
        }
    }
}

