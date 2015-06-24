using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListViewExample.Xaml
{
    public partial class ListViewButton : ContentPage
    {
        public ListViewButton()
        {
            InitializeComponent();

            BindingContext = new ListViewButtonViewModel(DisplayAlert);
        }
    }

    public class ListViewButtonViewModel : BindableObject
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
         

        public ListViewButtonViewModel(Func<string, string, string, Task> displayAlertAction)
        {
            this.displayAlertAction = displayAlertAction;

            ListItems = new List<ListItem> { 
                new ListItem {Title = "First", Description="1st item", Price="$100.00"}, 
                new ListItem {Title = "Second", Description="2nd item", Price="$200.00"},
                new ListItem {Title = "Third", Description="3rd item", Price="$300.00"}
            };

            MessagingCenter.Subscribe<ListItem>(this, "BuyRequested", BuyRequested);
        }

        void BuyRequested(ListItem listItem)
        {
            displayAlertAction.Invoke("Button", listItem.Title + " was clicked.", "OK");
        }
            
        public class ListItem : BindableObject
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }

            Command buyCommand;
            public Command BuyCommand
            {
                get
                {
                    return buyCommand;
                }
                set
                {
                    buyCommand = value;
                    OnPropertyChanged("BuyCommand");
                }
            }

            public ListItem()
            {
                BuyCommand = new Command(BuyRequested);
            }

            void BuyRequested()
            {
                MessagingCenter.Send<ListItem>(this, "BuyRequested");       
            }
        }
    }


       
}

