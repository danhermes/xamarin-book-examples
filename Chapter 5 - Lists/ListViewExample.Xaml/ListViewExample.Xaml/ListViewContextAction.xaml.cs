using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListViewExample.Xaml
{
    public partial class ListViewContextAction : ContentPage
    {
        public ListViewContextAction()
        {
            InitializeComponent();

            BindingContext = new ListVieContextActionViewModel(DisplayAlert);
        }
    }

    public class ListVieContextActionViewModel : BindableObject
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


        public ListVieContextActionViewModel(Func<string, string, string, Task> displayAlertAction)
        {
            this.displayAlertAction = displayAlertAction;

            ListItems = new List<ListItem> { 
                new ListItem {Title = "First", Description="1st item", Price="$100.00"}, 
                new ListItem {Title = "Second", Description="2nd item", Price="$200.00"},
                new ListItem {Title = "Third", Description="3rd item", Price="$300.00"}
            };

            MessagingCenter.Subscribe<ListItem>(this, "MoreRequested", MoreRequested);
            MessagingCenter.Subscribe<ListItem>(this, "DeleteRequested", DeleteRequested);
        }

        void MoreRequested(ListItem listItem)
        {
            displayAlertAction?.Invoke("More", $"{listItem.Title} more was clicked.", "OK");
        }

        void DeleteRequested(ListItem listItem)
        {
            displayAlertAction?.Invoke("Delete", $"{listItem.Title} delete was clicked.", "OK");
        }


        public class ListItem : BindableObject
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }

            Command moreCommand;
            public Command MoreCommand
            {
                get
                {
                    return moreCommand;
                }
                set
                {
                    moreCommand = value;
                    OnPropertyChanged("MoreCommand");
                }
            }
                
            Command deleteCommand;
            public Command DeleteCommand
            {
                get
                {
                    return deleteCommand;
                }
                set
                {
                    deleteCommand = value;
                    OnPropertyChanged("DeleteCommand");
                }
            }

            public ListItem()
            {
                MoreCommand = new Command(MoreRequested);
                DeleteCommand = new Command(DeleteRequested);
            }

            void MoreRequested()
            {
                MessagingCenter.Send<ListItem>(this, "MoreRequested");       
            }

            void DeleteRequested()
            {
                MessagingCenter.Send<ListItem>(this, "DeleteRequested");       
            }
        }
    }
}

