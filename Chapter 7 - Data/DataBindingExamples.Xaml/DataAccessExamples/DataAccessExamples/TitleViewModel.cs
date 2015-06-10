using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace DataBindingExamples
{
    public class TitleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        String title;
        
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
