using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace ListViewExample.Xaml
{
    public partial class ListViewPerformance : ContentPage
    {
        public ListViewPerformance()
        {
            InitializeComponent();

            BindingContext = new ListViewPerformanceViewModel(DisplayAlert);
        }
    }

    public class ListViewPerformanceViewModel : BindableObject
    {
        Func<string, string, string, Task> displayAlertAction;

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
                if (selectedListItem != null)
                    displayAlertAction?.Invoke("Tapped", $"{selectedListItem.Title} was selected.", "OK"); 

            }
        }

        public ListViewPerformanceViewModel(Func<string, string, string, Task> displayAlertAction)
        {
            this.displayAlertAction = displayAlertAction;

            ListItems = Enumerable.Range(1, 500)
                .Select(index => new ListItem { Source = "first.png", Title = $"{index}", Description = $"item number {index}", Price = $"${index}.00" })
                .ToList();
        }

        public class ListItem : BindableObject
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }
    }
}

