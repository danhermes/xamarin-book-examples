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

            BindingContext = new ListViewStringsViewModel(DisplayAlert);
        }

    }

    public class ListViewStringsViewModel : BindableObject
    {
        readonly Func<string, string, string, Task> displayAlertAction;

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

        string selectedItem;
        public string SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
                if (selectedItem != null)
                    displayAlertAction.Invoke("Tapped", selectedItem + " was selected.", "OK");
            }
        }

        public ListViewStringsViewModel(Func<string, string, string, Task> displayAlertAction)
        {
            this.displayAlertAction = displayAlertAction;
            Items = new List<string> 
                {
                    "First",
                    "Second",
                    "Third"
                };
        }
    }
}

