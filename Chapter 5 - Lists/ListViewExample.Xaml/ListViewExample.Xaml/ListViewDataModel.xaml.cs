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

            BindingContext = new ListViewDataModelViewModel(DisplayAlert);
        }
    }

    public class ListViewDataModelViewModel : BindableObject
    {
        readonly Func<string, string, string, Task> displayAlertAction;

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

        ListItem selectedListItem;
        public ListItem SelectedListItem
        {
            get
            {
                return selectedListItem;
            }
            set
            {
                selectedListItem = value;
                OnPropertyChanged("SelectedListItem");
                if(selectedListItem != null)
                    displayAlertAction?.Invoke("Tapped", $"{selectedListItem.Title} was selected.", "OK");
            }
        }

        public ListViewDataModelViewModel(Func<string, string, string, Task> displayAlertAction)
        {
            this.displayAlertAction = displayAlertAction;

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

    public class ListItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

