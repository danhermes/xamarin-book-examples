using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingExamples
{
    class ItemBindable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string title;
        string description;

        public string Title
        {
            set
            {
                if (!value.Equals(title, StringComparison.Ordinal))
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
            get
            {
                return title;
            }
        }

        public string Description
        {
            set
            {
                if (!value.Equals(description, StringComparison.Ordinal))
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            }
            get
            {
                return description;
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
