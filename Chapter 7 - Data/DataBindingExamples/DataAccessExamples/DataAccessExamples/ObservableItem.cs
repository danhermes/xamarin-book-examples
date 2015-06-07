using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace DataBindingExamples
{
    class ObservableItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Item item;

        public ObservableItem()
        {
            item = new Item();
        }

        public string Title
        {
            set
            {
                if (!value.Equals(item.Title, StringComparison.Ordinal))
                {
                    item.Title = value;
                    OnPropertyChanged("Title");
                }
            }
            get
            {
                return item.Title;
            }
        }

        public string Description
        {
            set
            {
                if (!value.Equals(item.Description, StringComparison.Ordinal))
                {
                    item.Description = value;
                    OnPropertyChanged("Description");
                }
            }
            get
            {
                return item.Description;
            }
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
